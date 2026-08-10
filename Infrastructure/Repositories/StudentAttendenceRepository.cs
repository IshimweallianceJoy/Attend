using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.ValueObject;
using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class StudentAttendenceRepository : IStudentAttendence
    {
     
         private readonly ApplicationDbContext _dbcontext;
        public StudentAttendenceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public async Task <List<GetStudentAttendenceDTO>> GetStudentAttendencesAsync()
        {
              return await _dbcontext.StudentAttendences
                .Include(a => a.Student)
                .Include(a => a.Attendence)
                .Select(at => new GetStudentAttendenceDTO
            {
                Id= at.Id,
                StudentId= at.StudentId,
                Student= at.Student,
                 AttendenceId= at.AttendenceId,
                Attendence= at.Attendence,
                
                Status= at.Status,

            }).ToListAsync();
        }        
        // THIS WAS CHANGED FROM ADDing NEW ATTENDANCE RECORD TO UPDATING ATTENDANCESTATUS 

        public async Task AddStudentAttendanceAsync(int AttendanceId, AttendenceStatus status)
        {
            var existing = await _dbcontext.StudentAttendences.FindAsync(AttendanceId);
           if (existing == null)
            {
                throw new InvalidOperationException("Student attendance record not found.");
            }
            existing.Status = status;
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<GetStudentAttendenceDTO?> GetStudentAttendenceByIdAsync(int id)
        {
              return await _dbcontext.StudentAttendences
                .Where(at => at.Id == id)
                .Include(a => a.Student)
                .Include(a => a.Attendence)
                .Select(at => new GetStudentAttendenceDTO
            {
                 Id= at.Id,
                StudentId= at.StudentId,
                Student= at.Student,
                 AttendenceId= at.AttendenceId,
                Attendence= at.Attendence,
               
                Status= at.Status,
            }).FirstOrDefaultAsync();
           
        }
         public async Task UpdateStudentAttendenceAsync(UpdateStudentAttendenceDTO stattendence)
        {
               var ExistingAttendence = await _dbcontext.StudentAttendences.FirstOrDefaultAsync(at => at.Id == stattendence.Id);
             if(ExistingAttendence != null)
            {
                ExistingAttendence.Id = stattendence.Id;
                ExistingAttendence.StudentId = stattendence.StudentId;
                ExistingAttendence.AttendenceId = stattendence.AttendenceId;
                ExistingAttendence.Status = stattendence.Status;
                
              } await _dbcontext.SaveChangesAsync();
        
        } 
        public async Task DeleteStudentAttendenceAsync(DeleteStudentAttedenceDTO stattendence)
        {
            var ExistingAttendence = await _dbcontext.StudentAttendences.FirstOrDefaultAsync(at => at.Id == stattendence.Id);
             if(ExistingAttendence != null )
            {
                ExistingAttendence.Status= stattendence.Status;
            } await _dbcontext.SaveChangesAsync();
        }
    }
}