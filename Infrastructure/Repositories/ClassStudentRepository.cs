using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class ClassStudentRepository : IClassStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        
        public ClassStudentRepository(ApplicationDbContext applicationDb)
        {
            _dbcontext=applicationDb;
        }
        public List<ClassStudent> GetClassStudents()
        {
           return _dbcontext.ClassStudents.ToList();
        }
    }
}