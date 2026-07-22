using Domain.Entities;
using Application.DTOs;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public Task<List<GetStudentDTO>>GetStudentsAsync();
         Task AddStudentAsync(AddStudentDTO student);
        Task<GetStudentDTO?> GetStudentByIdAsync(int id);
         Task UpdateStudentAsync(UpdateStudentDTO student);
         Task DeleteStusentAsync(DeleteStudentDTO student);
    }
}
