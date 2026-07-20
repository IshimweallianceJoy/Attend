using Domain.Entities;
namespace Application.Interfaces
{
    public interface IClassStudent
    {
        public List<ClassStudent>GetClassStudents();
        public void AddClassStudent(ClassStudent classStudent);
    }
}