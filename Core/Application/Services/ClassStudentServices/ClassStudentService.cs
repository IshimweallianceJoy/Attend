using Domain.Entities;
using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.ClassStudentServices
{
    public class ClassStudentService: IClassStudentService 
    {
        private readonly IClassStudent _classstudent;

        public  ClassStudentService(IClassStudent classStudents)
        {
            _classstudent=classStudents;
        }
        public async Task <List<GetClassStudentDTO>> GetClassStudentsAsync()
        {
            return await _classstudent.GetClassStudentsAsync();
        }
        public async Task AddClassStudentAsync(AddClassStudentDTO classStudent)
        {
          await  _classstudent.AddClassStudentAsync(classStudent);
        }
        public async Task <GetClassStudentDTO?> GetClassStudentByIdAsync(int id)
        {
            return await _classstudent.GetClassStudentByIdAsync(id);
        }
        public async Task UpdateClassStudentAsync(UpdateClassStudentDTO classstudent)
        {
           await _classstudent.UpdateClassStudentAsync(classstudent);
        }
        public async Task DeleteClassStudentAsync(DeleteClassStudentDTO classstudent)
        {
          await  _classstudent.DeleteClassStudentAsync(classstudent);
        }
    }
}