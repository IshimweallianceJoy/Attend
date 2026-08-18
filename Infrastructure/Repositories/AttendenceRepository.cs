using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Identity;
namespace Infrastructure.Repositories
{
    public class AttendenceRepository : IAttendence
    {
     
         private readonly ApplicationDbContext _dbcontext;
         private readonly IUserContext _Usercontext;
        public AttendenceRepository(ApplicationDbContext dbcontext, IUserContext userContext)
        {
            _dbcontext= dbcontext;
            _Usercontext=userContext;
        }


        public async Task<List<GetAttendenceDTO>> GetAttendencesAsync()
        {
              return await _dbcontext.Attendences
                .Include(a => a.Classs)
                .Select(at => new GetAttendenceDTO
            {
                Id= at.Id,
                InstructorName = at.InstructorName,
                ClasssId= at.ClasssId,
                Classs= at.Classs,
                UserAdded= at.UserAdded,
                DateAdded= at.DateAdded,
                Status= at.Status,

            }).ToListAsync();
        }        
         public async Task AddAttendenceAsync(AddAttendenceDTO attendence)
        {
           
            _dbcontext.Attendences.Add( new Attendence
            {
               InstructorName = attendence.InstructorName,
                    ClasssId = attendence.ClasssId,
                    Status = AttendenceStatus.Active,
                    Date = attendence.Date,
                    UserAdded = _Usercontext.Email,
                    DateAdded = DateTime.UtcNow
            });
          await  _dbcontext.SaveChangesAsync();
        }
        public async Task<GetAttendenceDTO?> GetAttendenceByIdAsync(int id)
        {   
              return await _dbcontext.Attendences
                .Where(at => at.Id == id)
                .Include(a => a.Classs)
                .Select(at => new GetAttendenceDTO
            {
                 Id= at.Id,
                ClasssId= at.ClasssId,
                Classs= at.Classs,
                UserAdded= at.UserAdded,
                DateAdded= at.DateAdded,
                Status= at.Status,
            }).FirstOrDefaultAsync();
           
        }
         public async Task UpdateAttendenceAsync(UpdateAttendenceDTO attendence)
        {
               var ExistingAttendence = await _dbcontext.Attendences.FirstOrDefaultAsync(at => at.Id == attendence.Id);
             if(ExistingAttendence != null)
            {
                ExistingAttendence.Id = attendence.Id;
                ExistingAttendence.ClasssId = attendence.ClasssId;
                
              } await _dbcontext.SaveChangesAsync(); 
        
        } 
        public async Task DeleteAttendenceAsync(DeleteAttendenceDTO attendence)
        {
            var ExistingAttendence = await _dbcontext.Attendences.FirstOrDefaultAsync(at => at.Id == attendence.Id);
             if(ExistingAttendence != null )
            {
                ExistingAttendence.Status= attendence.Status;
            } await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<GetStudentAttendenceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendenceDTO attendance)
        {
           
            ///Insert into attendance
            var attendanceEntity = new Attendence
            {
                ClasssId= attendance.ClasssId,
                InstructorName = attendance.InstructorName,
                Date = attendance.Date,
                UserAdded = _Usercontext.Email,
                DateAdded = DateTime.UtcNow,
                Status= AttendenceStatus.Active
            };
            await _dbcontext.Attendences.AddAsync(attendanceEntity);
            await _dbcontext.SaveChangesAsync();

            // -----------------------------END---------------------------
            //-----------------------------------FIND ACTIVE STUDENTS IN SELECTED-----------------------------------------

            var activeStudentIds = await _dbcontext.ClassStudents
            .Where(r => r.ClasssId == attendance.ClasssId && r.Status == ClassStudentStatus.Active)
            .Select(r => r.StudentId)
            .ToListAsync();
            //--------------------------------------------------------INSERT INTO STUDENT ATTENDANCE------------------------------------------

            var studentAttendanceEntity = activeStudentIds.Select(studentIds => new StudentAttendence
            {
               StudentId = studentIds,
               Attendence = attendanceEntity,
               Status = AttendenceStatus.UnTaken,
               DateAdded= DateTime.UtcNow,
               UserAdded= _Usercontext.Email,
               
            }).ToList();
            await _dbcontext.StudentAttendences.AddRangeAsync(studentAttendanceEntity);
            await _dbcontext.SaveChangesAsync();
            //-------------------------------------------------------END---------------------------------------
            //----------------------------------------FETCH SAVE STUDENTATTENDANCES FOR ONLY ONE CLASS/ATTENDANCE----------------------

            return await _dbcontext.StudentAttendences
                .Include(sa => sa.Student)
                .Include(sa => sa.Attendence)
                .Where(sa => sa.AttendenceId == attendanceEntity.Id)
                .Select(sa => new GetStudentAttendenceDTO
                {
                    Id = sa.Id,
                    Student = sa.Student,
                    StudentId = sa.StudentId,
                    Attendence = sa.Attendence,
                    AttendenceId = sa.AttendenceId,
                    Status = sa.Status,
                    UserAdded = sa.UserAdded,
                    DateAdded = sa.DateAdded
                })
                .ToListAsync();
        }
    }
}