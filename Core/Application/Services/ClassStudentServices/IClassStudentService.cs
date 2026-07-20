using Domain.Entities;
namespace Application.Services.ClassStudentServices 
{
     public interface IClassStudentService
    {
        public List<ClassStudent>GetClassStudents();
        public void AddClassStudent(ClassStudent classStudent);
    }
}