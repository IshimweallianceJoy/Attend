using Domain.Entities;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<Student>GetStudents();
        public void AddStudent(Student student);
    }
}
