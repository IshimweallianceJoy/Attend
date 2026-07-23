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
        public async Task <List<GetClassDTO>> GetClasssesAsync()
        {
           return await _class.GetClasssesAsync();
        }
        public async Task AddClassAsync(AddClassDTO classs)
        {
              await  _class.AddClassAsync(classs);
        }
        public async Task <GetClassDTO?> GetClasssByIdAsync(int id)
        {
            return await _class.GetClasssByIdAsync(id);
        }
          public async Task UpdateClassAsync(UpdateClassDTO classs)
        {
           await _class.UpdateClassAsync(classs);
        }
        public async Task DeleteClassAsync(DeleteClassDTO classs)
        {
           await _class.DeleteClassAsync(classs);
        }
    }

   
}