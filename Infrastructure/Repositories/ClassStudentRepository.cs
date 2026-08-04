using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class ClassStudentRepository : IClassStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        
        public ClassStudentRepository(ApplicationDbContext applicationDb)
        {
            _dbcontext=applicationDb;
        }
        public async Task <List<GetClassStudentDTO>> GetClassStudentsAsync()
        {
           return await _dbcontext.ClassStudents
                .Include(c => c.Classs)
                .Include(c => c.Student)
                .Select(cs => new GetClassStudentDTO
            {
                Id= cs.Id,
                ClasssId=cs.ClasssId,
                Classs= cs.Classs,
                StudentId= cs.StudentId,
                Student= cs.Student,
                 StartDate= cs.StartDate,
                EndDate= cs.EndDate,
                UserAdded= cs.UserAdded,
                DateAdded=cs.DateAdded,
                Status= cs. Status,
            }).ToListAsync();
        }
        public async Task AddClassStudentAsync(AddClassStudentDTO classStudent)
        {
             var existingdata= await _dbcontext.ClassStudents.AnyAsync(c => c.ClasssId == classStudent.ClasssId && c.StudentId == classStudent.StudentId );
            if(existingdata)
            {
                throw new InvalidCastException("this class with same Student already axists");
            }
            _dbcontext.ClassStudents.Add(new ClassStudent
            {
                ClasssId= classStudent.ClasssId,
                StudentId= classStudent.StudentId,
                
                StartDate = classStudent.StartDate ?? DateOnly.FromDateTime(DateTime.Today),
                 EndDate = classStudent.EndDate ?? DateOnly.FromDateTime(DateTime.Today),
                UserAdded="Joy",
                DateAdded= DateTime.UtcNow,
                Status=ClassStudentStatus.Active,
            });
           await _dbcontext.SaveChangesAsync();
        }

        public async Task <GetClassStudentDTO?> GetClassStudentByIdAsync(int id)
        {
            return await _dbcontext.ClassStudents
                .Where(cs => cs.Id == id)
                .Include(c => c.Classs)
                .Include(c => c.Student)
                .Select(cs => new GetClassStudentDTO
            {
                  Id= cs.Id,
                ClasssId=cs.ClasssId,
                Classs= cs.Classs,
                StudentId= cs.StudentId,
                Student= cs.Student,
                StartDate= cs.StartDate,
                EndDate= cs.EndDate,
                UserAdded= cs.UserAdded,
                DateAdded=cs.DateAdded,
                Status= cs. Status,

            }).FirstOrDefaultAsync();
            
        }
        public async Task UpdateClassStudentAsync(UpdateClassStudentDTO clssstudent)
        {
           var ExistingClassStudent = await _dbcontext.ClassStudents.FirstOrDefaultAsync(cs => cs.Id == clssstudent.Id);
           if(ExistingClassStudent != null)
            {
                ExistingClassStudent.Id= clssstudent.Id;
                ExistingClassStudent.ClasssId= clssstudent.ClasssId;
                ExistingClassStudent.StudentId= clssstudent.StudentId;
            }
           await _dbcontext.SaveChangesAsync();
        }
        public async Task DeleteClassStudentAsync(DeleteClassStudentDTO clssstudent)
        {
            var ExistingClassStudent= await _dbcontext.ClassStudents.FirstOrDefaultAsync(cs => cs.Id == clssstudent.Id);
            if(ExistingClassStudent != null)
            {
                ExistingClassStudent.Status=clssstudent.Status;
            }
          await  _dbcontext.SaveChangesAsync();
        }
    }
}