using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.FaculityServices
{
    public class FaculityService:IFaculityService
    {
         private readonly IFaculity _faculity;

        public FaculityService(IFaculity faculities)
        {
            _faculity=faculities;
        }
        public async Task<List<GetFaculityDTO>> GetFaculitiesAsync()
        {
            return await _faculity.GetFaculitiesAsync();
        }
    }
}