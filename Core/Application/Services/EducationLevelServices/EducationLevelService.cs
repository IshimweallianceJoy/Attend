using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.EducationLevelServices
{
    public class EducationLevelService:IEducationLevelService
    {
       private readonly IEducationLevel _educationlevel;

       public EducationLevelService(IEducationLevel educationLevel)
        {
            _educationlevel=educationLevel;
        }
        public List<EducationLevel> GetEducationLevels()
        {
            return _educationlevel.GetEducationLevels();
        }
    }
}