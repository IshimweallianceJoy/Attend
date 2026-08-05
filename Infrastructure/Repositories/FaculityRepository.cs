using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
using Domain.ValueObject;
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
                Name = fac.Name,
                Status = fac.Status,
            }).ToListAsync();
        }
        // public async Task AddFaculityAsync(AddFaculityDTO faculity)
        // {
           
        //     _dbcontext.Classes.Add( new Faculity
        //     {
        //         Name= faculity.Name,
        //         Status= FaculityStatus.Active,
        //     });
        //    await _dbcontext.SaveChangesAsync();
        // }
        // public async Task <GetFaculityDTO?> GetFaculityByIdAsync(int id)
        // {
        //     return await _dbcontext.Classes
        //         .Where(cc => cc.Id == id)
        //         .Include(c => c.Faculity)
        //         .Include(c => c.EducationLevel)
        //         .Select(cc => new GetClassDTO
        //         {
        //             Id = cc.Id,
        //             Name = cc.Name,
                   
        //             Status = cc.Status,
        //         })
        //         .FirstOrDefaultAsync();
        // }
        // public async Task UpdateClassAsync(UpdateClassDTO classs)
        // {
        //        var ExistingClass = await _dbcontext.Classes.FirstOrDefaultAsync(cc => cc.Id == classs.Id);
        //      if(ExistingClass != null)
        //     {
        //         ExistingClass.Id = classs.Id;
        //         ExistingClass.Name = classs.Name;
                
                
        //       } await _dbcontext.SaveChangesAsync();
        
        // } 
        // public async Task DeleteClassAsync(DeleteClassDTO classs)
        // {
        //     var ExistingClass = await _dbcontext.Classes.FirstOrDefaultAsync(cc => cc.Id == classs.Id);
        //      if(ExistingClass != null )
        //     {
        //         ExistingClass.Status= classs.Status;
        //     } await _dbcontext.SaveChangesAsync();
        // }
    }
}