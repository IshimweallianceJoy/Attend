using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
         private readonly IClass _class;

          public ClassService(IClass Classs)
        {
            _class=Classs;
        }
        public List<Classs> GetClassses()
        {
           return _class.GetClassses();
        }
    }

   
}