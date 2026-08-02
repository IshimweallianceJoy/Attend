using Application.DTOs;
using Domain.Entities;

namespace Application.Services.StudentAttendenceServices
{
    public interface IStudentAttendenceService
    {
        
         Task <List<GetStudentAttendenceDTO>>GetStudentAttendencesAsync();
        Task AddStudentAttendenceAsync(AddStudentAttendenceDTO stattendence);
        Task <GetStudentAttendenceDTO?> GetStudentAttendenceByIdAsync(int id);
        Task  UpdateStudentAttendenceAsync(UpdateStudentAttendenceDTO stattendence);
        Task DeleteStudentAttendenceAsync(DeleteStudentAttedenceDTO stattendence);
    }
}