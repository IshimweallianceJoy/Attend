using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.AttendenceServices
{
    public class AttendenceService : IAttendenceService
    {
        
           
           private readonly IAttendence _attendence;

           public AttendenceService(IAttendence attendences)
        {
            _attendence=attendences;
        }
           public List<Attendence> GetAttendences()
        {
            return _attendence.GetAttendences();
        }
        public void AddAttendence(Attendence attendence)
        {
            _attendence.AddAttendence(attendence);
        }
    }
}