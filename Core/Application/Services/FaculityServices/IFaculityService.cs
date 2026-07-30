using Domain.Entities;
using Application.DTOs;
namespace Application.Services.FaculityServices
{
    public interface IFaculityService
    {
        public Task<List<GetFaculityDTO>> GetFaculitiesAsync();
    }
}