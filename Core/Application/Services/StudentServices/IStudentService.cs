using Core.Domain.Entities;
namespace Core.Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<Student>GetStudents();
    }
}
