using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IFaculity
    {
        Task<List<GetFaculityDTO>> GetFaculitiesAsync();
    }
}