using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
         private readonly IClass _class;

          public ClassService(IClass classs)
        {
            _class=classs;
        }
        public List<GetClassDTO> GetClassses()
        {
           return _class.GetClassses();
        }
        public void AddClass(AddClassDTO classs)
        {
                _class.AddClass(classs);
        }
        public GetClassDTO? GetClasssById(int id)
        {
            return _class.GetClasssById(id);
        }
          public void UpdateClass(UpdateClassDTO classs)
        {
            _class.UpdateClass(classs);
        }
        public void DeleteClass(DeleteClassDTO classs)
        {
            _class.DeleteClass(classs);
        }
    }

   
}