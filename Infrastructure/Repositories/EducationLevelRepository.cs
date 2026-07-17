using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class EducationLevelRepository:IEducationLevel
    {
       
         private readonly ApplicationDbContext _dbcontext;
        public EducationLevelRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<EducationLevel> GetEducationLevels()
        {
            return _dbcontext.EducationLevels.ToList();
        }
    }
}
