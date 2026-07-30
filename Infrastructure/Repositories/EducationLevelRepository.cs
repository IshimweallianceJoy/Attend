using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class EducationLevelRepository:IEducationLevel
    {
       
         private readonly ApplicationDbContext _dbcontext;
        public EducationLevelRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public async Task<List<GetEducationLevelDTO>> GetEducationLevelsAsync()
        {
            return await _dbcontext.EducationLevels.Select(edl =>  new GetEducationLevelDTO
            {
                Id = edl.Id,
                Name = edl.Name,
                UserAdded= edl.UserAdded,
                DateAdded= edl.DateAdded,
                Status= edl.Status,
            }).ToListAsync();
        }
    }
}
