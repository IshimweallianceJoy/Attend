using Domain.Entities;
namespace Application.Services.AttendenceServices
{
    public interface IAttendenceService
    {
        public List<Attendence>GetAttendences();
    }
}