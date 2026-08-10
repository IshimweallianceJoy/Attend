using Application.DTOs;
using Domain.ValueObject;

namespace Application.Services.StudentAttendenceServices
{
    public interface IStudentAttendenceService
    {
        
         Task <List<GetStudentAttendenceDTO>>GetStudentAttendencesAsync();
        Task AddStudentAttendanceAsync(int AttendanceId, AttendenceStatus Status);
        Task <GetStudentAttendenceDTO?> GetStudentAttendenceByIdAsync(int id);
        Task  UpdateStudentAttendenceAsync(UpdateStudentAttendenceDTO stattendence);
        Task DeleteStudentAttendenceAsync(DeleteStudentAttedenceDTO stattendence);
    }
}