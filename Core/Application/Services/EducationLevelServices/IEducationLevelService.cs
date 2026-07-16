using Domain.Entities;
namespace Application.Services.EducationLevelServices
{
    public interface IEducationLevelService
    {
        public List<EducationLevel>GetEducationLevels();
    }
}