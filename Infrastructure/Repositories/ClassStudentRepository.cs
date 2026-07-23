using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
namespace Infrastructure.Repositories
{
    public class ClassStudentRepository : IClassStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        
        public ClassStudentRepository(ApplicationDbContext applicationDb)
        {
            _dbcontext=applicationDb;
        }
        public List<GetClassStudentDTO> GetClassStudents()
        {
           return _dbcontext.ClassStudents.Select(cs =>  new GetClassStudentDTO
            {
                Id= cs.Id,
                ClasssId=cs.ClasssId,
                StudentId= cs.StudentId,
                UserAdded= cs.UserAdded,
                DateAdded=cs.DateAdded,
                Status= cs. Status,
            }).ToList();
        }
        public void AddClassStudent(AddClassStudentDTO classStudent)
        {
            _dbcontext.ClassStudents.Add(new ClassStudent
            {
                ClasssId= classStudent.ClasssId,
                StudentId= classStudent.StudentId,
                UserAdded="Joy",
                DateAdded= DateTime.UtcNow,
                Status="Active",
            });
            _dbcontext.SaveChanges();
        }

        public GetClassStudentDTO? GetClassStudentById(int id)
        {
            return _dbcontext.ClassStudents.Where(cs => cs.Id == id).Select( cs => new GetClassStudentDTO
            {
                  Id= cs.Id,
                ClasssId=cs.ClasssId,
                StudentId= cs.StudentId,
                UserAdded= cs.UserAdded,
                DateAdded=cs.DateAdded,
                Status= cs. Status,

            }).FirstOrDefault();
            
        }
        public void UpdateClassStudent(UpdateClassStudentDTO clssstudent)
        {
           var ExistingClassStudent = _dbcontext.ClassStudents.FirstOrDefault(cs => cs.Id == clssstudent.Id);
           if(ExistingClassStudent != null)
            {
                ExistingClassStudent.Id= clssstudent.Id;
                ExistingClassStudent.ClasssId= clssstudent.ClasssId;
                ExistingClassStudent.StudentId= clssstudent.StudentId;
            }
            _dbcontext.SaveChanges();
        }
        public void DeleteClassStudent(DeleteClassStudentDTO clssstudent)
        {
            var ExistingClassStudent= _dbcontext.ClassStudents.FirstOrDefault(cs => cs.Id == clssstudent.Id);
            if(ExistingClassStudent != null)
            {
                ExistingClassStudent.Status="Deleted";
            }
            _dbcontext.SaveChanges();
        }
    }
}