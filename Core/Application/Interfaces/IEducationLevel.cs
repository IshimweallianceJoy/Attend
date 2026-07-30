using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IEducationLevel
    {
        Task<List<GetEducationLevelDTO>> GetEducationLevelsAsync();
    }
}