using Application.DTOs;
namespace Application.Interfaces
{
    public interface IStudentAttendence
    {
         Task <List<GetStudentAttendenceDTO>>GetStudentAttendencesAsync();
        Task AddStudentAttendenceAsync(AddStudentAttendenceDTO stattendence);
        Task <GetStudentAttendenceDTO?> GetStudentAttendenceByIdAsync(int id);
        Task  UpdateStudentAttendenceAsync(UpdateStudentAttendenceDTO stattendence);
        Task DeleteStudentAttendenceAsync(DeleteStudentAttedenceDTO stattendence);
    }
}