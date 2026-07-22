using Domain.Entities;
using Application.DTOs;
namespace Application.Services.ClassStudentServices 
{
     public interface IClassStudentService
    {
        public List<GetClassStudentDTO>GetClassStudents();
         Task AddClassStudentAsync(AddClassStudentDTO classStudent);
        public GetClassStudentDTO? GetClassStudentById(int id);
         Task UpdateClassStudentAsync(UpdateClassStudentDTO classstudent);
         Task DeleteClassStudentAsync(DeleteClassStudentDTO classstudent);
    }
}