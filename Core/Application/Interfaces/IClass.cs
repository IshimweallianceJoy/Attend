using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces 
{
    public interface IClass
    {
        public List<GetClassDTO> GetClassses();
        public void AddClass(AddClassDTO classs);
        public GetClassDTO? GetClasssById(int id);
        public void UpdateClass(UpdateClassDTO classs);
        public void DeleteClass(DeleteClassDTO classs);
    }
}












