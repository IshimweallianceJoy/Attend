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

        public GetClassStudentDTO? GetClassStudent(int id)
        {
            return _dbcontext.ClassStudents.Where(cs => cs.Id == id).Select( cs => new GetClassStudentDTO
            {
                
            }).FirstOrDefault();
            
        }
        public void UpdateClassStudent(UpdateClassStudentDTO clsssstudent)
        {
            
        }
    }
}