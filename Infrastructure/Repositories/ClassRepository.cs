using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Application.DTOs;
namespace Infrastructure.Repositories
{
    public class ClassRepository : IClass
    {
         private readonly ApplicationDbContext _dbcontext;
        public ClassRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<GetClassDTO> GetClassses()
        {
            return _dbcontext.Classes.Select(cc => new GetClassDTO
            {
                Id = cc.Id,
                Name = cc.Name,
                FaculityId= cc.FaculityId,
                EducationLevelId= cc.EducationLevelId,
                UserAdded= cc.UserAdded,
                DateAdded= cc.DateAdded,
                Status= cc.Status,

            }).ToList();
        }
        public void AddClass(AddClassDTO classs)
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
            _dbcontext.SaveChanges();
        }
        public GetClassDTO? GetClasssById(int id)
        {
            return _dbcontext.Classes.Where(cc => cc.Id == id).Select( cc => new GetClassDTO
            {
                
                Id = cc.Id,
                Name = cc.Name,
                FaculityId= cc.FaculityId,
                EducationLevelId= cc.EducationLevelId,
                UserAdded= cc.UserAdded,
                DateAdded= cc.DateAdded,
                Status= cc.Status,
            }).FirstOrDefault();
        }
        public void UpdateClass(UpdateClassDTO classs)
        {
               var ExistingClass =  _dbcontext.Classes.FirstOrDefault(cc => cc.Id == classs.Id);
             if(ExistingClass != null)
            {
                ExistingClass.Id = classs.Id;
                ExistingClass.Name = classs.Name;
                ExistingClass.FaculityId= classs.FaculityId;
                
              }  _dbcontext.SaveChanges();
        
        } 
        public void DeleteClass(DeleteClassDTO classs)
        {
            var ExistingClass = _dbcontext.Classes.FirstOrDefault(cc => cc.Id == classs.Id);
             if(ExistingClass != null )
            {
                ExistingClass.Status= "Deleted";
            }_dbcontext.SaveChanges();
        }
    } 
}