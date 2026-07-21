using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.StudentServices

{
    public class StudentService:IStudentService
    {
        private readonly IStudent _student;

        public StudentService(IStudent student)
        {
            _student=student;
        }
        public List<GetStudentDTO> GetStudents()
        {
          return _student.GetStudents();
        }
        public void AddStudent(AddStudentDTO student)
        {
             _student.AddStudent(student);
        }
        public GetStudentDTO? GetStudentById(int id)
        {
            return _student.GetStudentById(id);
        }
          public void UpdateStudent(UpdateStudentDTO student)
        {
            _student.UpdateStudent(student);
        }
        public void DeleteStusent(DeleteStudentDTO student)
        {
            _student.DeleteStusent(student);
        }
    }

   
}

