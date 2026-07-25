using Domain.Entities;
using Application.DTOs;
namespace Application.Services.ClassStudentServices 
{
     public interface IClassStudentService
    {
         Task<List<GetClassStudentDTO>> GetClassStudentsAsync();
         Task AddClassStudentAsync(AddClassStudentDTO classStudent);
        Task<GetClassStudentDTO?> GetClassStudentByIdAsync(int id);
         Task UpdateClassStudentAsync(UpdateClassStudentDTO classstudent);
         Task DeleteClassStudentAsync(DeleteClassStudentDTO classstudent);
    }
}