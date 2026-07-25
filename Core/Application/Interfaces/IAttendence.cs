using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IAttendence
    {
        Task <List<GetAttendenceDTO>>GetAttendencesAsync();
        Task AddAttendenceAsync(AddAttendenceDTO attendence);
        Task <GetAttendenceDTO?> GetAttendenceByIdAsync(int id);
        Task  UpdateAttendenceAsync(UpdateAttendenceDTO attendence);
        Task DeleteAttendenceAsync(DeleteAttendenceDTO attendence);
    }
}