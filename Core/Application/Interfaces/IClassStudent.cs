using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IClassStudent
    {
        Task <List<GetClassStudentDTO>>GetClassStudentsAsync();
        Task AddClassStudentAsync(AddClassStudentDTO classStudent);
        Task <GetClassStudentDTO?> GetClassStudentByIdAsync(int id);
        Task  UpdateClassStudentAsync(UpdateClassStudentDTO clssstudent);
        Task DeleteClassStudentAsync(DeleteClassStudentDTO clssstudent);
        
    }
}