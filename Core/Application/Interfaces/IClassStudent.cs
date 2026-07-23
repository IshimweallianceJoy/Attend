using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IClassStudent
    {
        public List<GetClassStudentDTO>GetClassStudents();
        public void AddClassStudent(AddClassStudentDTO classStudent);
        public GetClassStudentDTO? GetClassStudentById(int id);
        public void UpdateClassStudent(UpdateClassStudentDTO clssstudent);
        public void DeleteClassStudent(DeleteClassStudentDTO clssstudent);
        
    }
}