using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
using Domain.ValueObject;
namespace Application.Services.StudentAttendenceServices
{
    public class StudentAttendenceService : IStudentAttendenceService
    {
        
           
           private readonly IStudentAttendence _attendence;

           public StudentAttendenceService(IStudentAttendence stattendence)
        {
            _attendence=stattendence;
        }
           public async Task <List<GetStudentAttendenceDTO>> GetStudentAttendencesAsync()
        {
            return await _attendence.GetStudentAttendencesAsync();
        }
        // ------------------------CHANGES
        public async Task AddStudentAttendanceAsync(int AttendanceId, AttendenceStatus status)
        {
            await _attendence.AddStudentAttendanceAsync(AttendanceId, status);
        }
        public async Task <GetStudentAttendenceDTO?> GetStudentAttendenceByIdAsync(int id)
        {
            return await _attendence.GetStudentAttendenceByIdAsync(id);
        }
        public async Task UpdateStudentAttendenceAsync(UpdateStudentAttendenceDTO stattendence)
        {
            await _attendence.UpdateStudentAttendenceAsync(stattendence);
        }
        public async Task DeleteStudentAttendenceAsync(DeleteStudentAttedenceDTO stattendence)
        {
            await _attendence.DeleteStudentAttendenceAsync(stattendence);
        }
    }
}