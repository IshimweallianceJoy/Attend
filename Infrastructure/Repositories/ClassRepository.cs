using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class ClassRepository : IClass
    {
         private readonly ApplicationDbContext _dbcontext;
        public ClassRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public async Task<List<GetClassDTO>> GetClasssesAsync()
        {
            return await _dbcontext.Classes.Select(cc => new GetClassDTO
            {
                Id = cc.Id,
                Name = cc.Name,
                FaculityId= cc.FaculityId,
                EducationLevelId= cc.EducationLevelId,
                UserAdded= cc.UserAdded,
                DateAdded= cc.DateAdded,
                Status= cc.Status,

            }).ToListAsync();
        }
        public async Task AddClassAsync(AddClassDTO classs)
        {
            _dbcontext.Classes.Add( new Classs
            {
                Name= classs.Name,
                FaculityId= classs.FaculityId,
                EducationLevelId= classs.EducationLevelId,
                UserAdded= "Joy",
                DateAdded= DateTime.UtcNow,
                Status= "Active",
            });
           await _dbcontext.SaveChangesAsync();
        }
        public async Task <GetClassDTO?> GetClasssByIdAsync(int id)
        {
            return await _dbcontext.Classes.Where(cc => cc.Id == id).Select( cc => new GetClassDTO
            {
                
                Id = cc.Id,
                Name = cc.Name,
                FaculityId= cc.FaculityId,
                EducationLevelId= cc.EducationLevelId,
                UserAdded= cc.UserAdded,
                DateAdded= cc.DateAdded,
                Status= cc.Status,
            }).FirstOrDefaultAsync();
        }
        public async Task UpdateClassAsync(UpdateClassDTO classs)
        {
               var ExistingClass = await _dbcontext.Classes.FirstOrDefaultAsync(cc => cc.Id == classs.Id);
             if(ExistingClass != null)
            {
                ExistingClass.Id = classs.Id;
                ExistingClass.Name = classs.Name;
                ExistingClass.FaculityId= classs.FaculityId;
                
              } await _dbcontext.SaveChangesAsync();
        
        } 
        public async Task DeleteClassAsync(DeleteClassDTO classs)
        {
            var ExistingClass = await _dbcontext.Classes.FirstOrDefaultAsync(cc => cc.Id == classs.Id);
             if(ExistingClass != null )
            {
                ExistingClass.Status= "Deleted";
            } await _dbcontext.SaveChangesAsync();
        }
    } 
}