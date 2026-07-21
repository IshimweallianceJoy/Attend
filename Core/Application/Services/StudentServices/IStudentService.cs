using Domain.Entities;
using Application.DTOs;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<GetStudentDTO>GetStudents();
        public void AddStudent(AddStudentDTO student);
        public GetStudentDTO? GetStudentById(int id);
        public void UpdateStudent(UpdateStudentDTO student);
        public void DeleteStusent(DeleteStudentDTO student);
    }
}
