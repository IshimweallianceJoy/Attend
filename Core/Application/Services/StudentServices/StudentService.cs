using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.StudentServices

{
    public class StudentService:IStudentService
    {
        private readonly IStudent _student;

        public StudentService(IStudent student)
        {
            _student=student;
        }
        public List<Student> GetStudents()
        {
          return _student.GetStudents();
        }
    }

   
}

