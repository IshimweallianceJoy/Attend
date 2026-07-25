using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.AttendenceServices
{
    public class AttendenceService : IAttendenceService
    {
        
           
           private readonly IAttendence _attendence;

           public AttendenceService(IAttendence attendences)
        {
            _attendence=attendences;
        }
           public async Task <List<GetAttendenceDTO>> GetAttendencesAsync()
        {
            return await _attendence.GetAttendencesAsync();
        }
        public async Task AddAttendenceAsync(AddAttendenceDTO attendence)
        {
           await _attendence.AddAttendenceAsync(attendence);
        }
        public async Task <GetAttendenceDTO?> GetAttendenceByIdAsync(int id)
        {
            return await _attendence.GetAttendenceByIdAsync(id);
        }
        public async Task UpdateAttendenceAsync(UpdateAttendenceDTO attendence)
        {
            await _attendence.UpdateAttendenceAsync(attendence);
        }
        public async Task DeleteAttendenceAsync(DeleteAttendenceDTO attendence)
        {
            await _attendence.DeleteAttendenceAsync(attendence);
        }
    }
}