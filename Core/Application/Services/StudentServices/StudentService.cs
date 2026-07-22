using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.StudentServices

{
    public class StudentService:IStudentService
    {
        private readonly IStudent _student;

        public StudentService(IStudent student)
        {
            _student=student;
        }
        public async Task<List<GetStudentDTO>> GetStudentsAsync()
        {
          return await _student.GetStudentsAsync();
        }
        public async Task AddStudentAsync(AddStudentDTO student)
        {
             await _student.AddStudentAsync(student);
        }
        public async Task <GetStudentDTO?> GetStudentByIdAsync(int id)
        {
            return await _student.GetStudentByIdAsync(id);
        }
          public async Task UpdateStudentAsync(UpdateStudentDTO student)
        {
           await _student.UpdateStudentAsync(student);
        }
        public async Task DeleteStusentAsync(DeleteStudentDTO student)
        {
          await  _student.DeleteStusentAsync(student);
        }
    }

   
}

