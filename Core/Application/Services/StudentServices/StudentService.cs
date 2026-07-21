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
        public void AddStudent(Student student)
        {
             _student.AddStudent(student);
        }
        public Student? GetStudentById(int id)
        {
            return _student.GetStudentById(id);
        }
          public void UpdateStudent(Student student)
        {
            _student.UpdateStudent(student);
        }
        public void DeleteStusent(Student student)
        {
            _student.DeleteStusent(student);
        }
    }

   
}

