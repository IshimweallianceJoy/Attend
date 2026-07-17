using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class FaculityRepository:IFaculity
    {
       private readonly ApplicationDbContext _dbcontext;

       public FaculityRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<Faculity> GetFaculities()
        {
            return _dbcontext.Faculities.ToList();
        } 
    }
}