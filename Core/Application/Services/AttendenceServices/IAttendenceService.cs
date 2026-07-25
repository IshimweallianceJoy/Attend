using Domain.Entities;
using Application.DTOs;
namespace Application.Services.AttendenceServices
{
    public interface IAttendenceService
    {
    Task <List<GetAttendenceDTO>>GetAttendencesAsync();
        Task AddAttendenceAsync(AddAttendenceDTO attendence);
        Task <GetAttendenceDTO?> GetAttendenceByIdAsync(int id);
        Task  UpdateAttendenceAsync(UpdateAttendenceDTO attendence);
        Task DeleteAttendenceAsync(DeleteAttendenceDTO attendence);
    }
}