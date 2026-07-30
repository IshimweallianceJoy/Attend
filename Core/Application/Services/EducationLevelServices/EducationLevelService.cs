using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.EducationLevelServices
{
    public class EducationLevelService:IEducationLevelService
    {
       private readonly IEducationLevel _educationlevel;

       public EducationLevelService(IEducationLevel educationLevel)
        {
            _educationlevel=educationLevel;
        }
        public async Task<List<GetEducationLevelDTO>> GetEducationLevelsAsync()
        {
            return await _educationlevel.GetEducationLevelsAsync();
        }
    }
}