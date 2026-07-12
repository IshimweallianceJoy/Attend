using Domain.Entities;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
        public List<Classs> GetClasses()
        {
          return new List<Classs>
        {
            new Classs{Id=1,Name="Class1",Department="Energy",Faculity="Electrical Technology"},
             new Classs{Id=2,Name="Class2",Department="Energy",Faculity="Elecronics"}
        };
        }
    }

   
}