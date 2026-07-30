using Domain.Entities;
using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.EducationLevelServices
{
    public interface IEducationLevelService
    {
        public Task<List<GetEducationLevelDTO>> GetEducationLevelsAsync();
    }
}