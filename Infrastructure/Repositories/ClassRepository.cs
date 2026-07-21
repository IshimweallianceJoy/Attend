using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class ClassRepository : IClass
    {
         private readonly ApplicationDbContext _dbcontext;
        public ClassRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<Classs> GetClassses()
        {
            return _dbcontext.Classes.ToList();
        }
        public void AddClass(Classs classs)
        {
            _dbcontext.Classes.Add(classs);
            _dbcontext.SaveChanges();
        }
        public Classs? GetClasssById(int id)
        {
            return _dbcontext.Classes.FirstOrDefault(ee => ee.Id ==id);
        }
    } 
}