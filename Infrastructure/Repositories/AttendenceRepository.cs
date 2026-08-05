using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class AttendenceRepository : IAttendence
    {
     
         private readonly ApplicationDbContext _dbcontext;
        public AttendenceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public async Task <List<GetAttendenceDTO>> GetAttendencesAsync()
        {
              return await _dbcontext.Attendences
                .Include(a => a.Classs)
                .Select(at => new GetAttendenceDTO
            {
                Id= at.Id,
                ClasssId= at.ClasssId,
                Classs= at.Classs,
                UserAdded= at.UserAdded,
                DateAdded= at.DateAdded,
                Status= at.Status,

            }).ToListAsync();
        }        
         public async Task AddAttendenceAsync(AddAttendenceDTO attendence)
        {
            _dbcontext.Attendences.Add( new Attendence
            {
                  ClasssId= attendence.ClasssId,
                UserAdded= attendence.UserAdded,
                DateAdded= attendence.DateAdded,
                Status= "Active",
            });
          await  _dbcontext.SaveChangesAsync();
        }
        public async Task<GetAttendenceDTO?> GetAttendenceByIdAsync(int id)
        {   
              return await _dbcontext.Attendences
                .Where(at => at.Id == id)
                .Include(a => a.Classs)
                .Select(at => new GetAttendenceDTO
            {
                 Id= at.Id,
                ClasssId= at.ClasssId,
                Classs= at.Classs,
                UserAdded= at.UserAdded,
                DateAdded= at.DateAdded,
                Status= at.Status,
            }).FirstOrDefaultAsync();
           
        }
         public async Task UpdateAttendenceAsync(UpdateAttendenceDTO attendence)
        {
               var ExistingAttendence = await _dbcontext.Attendences.FirstOrDefaultAsync(at => at.Id == attendence.Id);
             if(ExistingAttendence != null)
            {
                ExistingAttendence.Id = attendence.Id;
                ExistingAttendence.ClasssId = attendence.ClasssId;
                
              } await _dbcontext.SaveChangesAsync();
        
        } 
        public async Task DeleteAttendenceAsync(DeleteAttendenceDTO attendence)
        {
            var ExistingAttendence = await _dbcontext.Attendences.FirstOrDefaultAsync(at => at.Id == attendence.Id);
             if(ExistingAttendence != null )
            {
                ExistingAttendence.Status= "Deleted";
            } await _dbcontext.SaveChangesAsync();
        }
    }
}