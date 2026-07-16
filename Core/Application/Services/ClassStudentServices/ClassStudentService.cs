using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.ClassStudentServices
{
    public class ClassStudentService : IClassStudentService
    {
        private readonly IClassStudent _classstudent;

        public ClassStudentService(IClassStudent classStudents)
        {
            _classstudent=classStudents;
        }
        public List<ClassStudent> GetClassStudents()
        {
            return _classstudent.GetClassStudents();
        }
    }
}