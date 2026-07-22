using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.ClassStudentServices
{
    public class ClassStudentService 
    {
        private readonly IClassStudent _classstudent;

        public ClassStudentService(IClassStudent classStudents)
        {
            _classstudent=classStudents;
        }
        public List<GetClassStudentDTO> GetClassStudents()
        {
            return _classstudent.GetClassStudents();
        }
        public void AddClassStudent(AddClassStudentDTO classStudent)
        {
            _classstudent.AddClassStudent(classStudent);
        }
        public GetClassStudentDTO? GetClassStudentById(int id)
        {
            return _classstudent.GetClassStudentById(id);
        }
        public void UpdateClassStudent(UpdateClassStudentDTO classstudent)
        {
            _classstudent.UpdateClassStudent(classstudent);
        }
        public void DeleteClassStudent(DeleteClassStudentDTO classstudent)
        {
            _classstudent.DeleteClassStudent(classstudent);
        }
    }
}