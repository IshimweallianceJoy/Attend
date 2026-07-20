using Domain.Entities;
namespace Application.Interfaces
{
    public interface IAttendence
    {
        public List<Attendence>GetAttendences();
        public void AddAttendence(Attendence attendence);
    }
}