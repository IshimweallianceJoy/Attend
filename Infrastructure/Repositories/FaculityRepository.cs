using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class FaculityRepository:IFaculity
    {
       private readonly ApplicationDbContext _dbcontext;

       public FaculityRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public async Task<List<GetFaculityDTO>> GetFaculitiesAsync()
        {
            return await _dbcontext.Faculities.Select(fac => new GetFaculityDTO
            {
                Id = fac.Id,
                Name = fac.Name
            }).ToListAsync();
        }
    }
}