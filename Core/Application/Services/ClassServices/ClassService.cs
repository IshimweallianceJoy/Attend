using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
         private readonly IClass _class;

          public ClassService(IClass classs)
        {
            _class=classs;
        }
        public List<Classs> GetClassses()
        {
           return _class.GetClassses();
        }
        public void AddClass(Classs classs)
        {
                _class.AddClass(classs);
        }
    }

   
}