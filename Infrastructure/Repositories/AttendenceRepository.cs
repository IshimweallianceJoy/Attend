using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class AttendenceRepository : IAttendence
    {
     
         private readonly ApplicationDbContext _dbcontext;
        public AttendenceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<Attendence> GetAttendences()
        {
            return _dbcontext.Attendences.ToList();
        }
    }
}