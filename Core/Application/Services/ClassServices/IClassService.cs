using Domain.Entities;
using Application.DTOs;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
        Task <List<GetClassDTO>> GetClasssesAsync();
        Task AddClassAsync(AddClassDTO classs);
        Task <GetClassDTO?> GetClasssByIdAsync(int id);
        Task UpdateClassAsync(UpdateClassDTO classs);
        Task DeleteClassAsync(DeleteClassDTO classs);
    }
}