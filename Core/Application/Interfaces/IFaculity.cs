using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IFaculity
    {
        Task<List<GetFaculityDTO>> GetFaculitiesAsync();
        // Task  AddFaculityAsync(AddFaculityDTO faculity);
        // Task< GetFaculityDTO?> GetFaculityByIdAsync(int id);
        // Task UpdateFaculityAsync(UpdateFaculityDTO faculity);
        // Task DeleteFaculityAsync(DeleteFaculityDTO faculity);
    }
}