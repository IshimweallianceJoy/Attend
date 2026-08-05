using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Domain.ValueObject;
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
        // }
        //   public async Task AddClassAsync(AddClassDTO classs)
        // {
        //     var existingdata= await _dbcontext.Classes.AnyAsync(c => c.Name == classs.Name && c.FaculityId == classs.FaculityId && c.EducationLevelId == classs.EducationLevelId);
        //     if(existingdata)
        //     {
        //         throw new InvalidCastException("this class with same level already axists");
        //     }
        //     _dbcontext.Classes.Add( new Classs
        //     {
        //         Name= classs.Name,
        //         FaculityId= classs.FaculityId,
        //         EducationLevelId= classs.EducationLevelId,
        //         UserAdded= "Joy",
        //         DateAdded= DateTime.UtcNow,
        //         Status= ClassStatus.Active,
        //     });
        //    await _dbcontext.SaveChangesAsync();
        // }
        // public async Task <GetClassDTO?> GetClasssByIdAsync(int id)
        // {
        //     return await _dbcontext.Classes
        //         .Where(cc => cc.Id == id)
        //         .Include(c => c.Faculity)
        //         .Include(c => c.EducationLevel)
        //         .Select(cc => new GetClassDTO
        //         {
        //             Id = cc.Id,
        //             Name = cc.Name,
        //             FaculityId = cc.FaculityId,
        //             Faculity = cc.Faculity,
        //             EducationLevelId = cc.EducationLevelId,
        //             EducationLevel = cc.EducationLevel,
        //             UserAdded = cc.UserAdded,
        //             DateAdded = cc.DateAdded,
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
        //         ExistingClass.FaculityId= classs.FaculityId;
                
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
}
