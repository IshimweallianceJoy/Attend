using Domain.Entities;
namespace Application.Interfaces 
{
    public interface IStudent
    {
        public List<Student>GetStudents();
        public void AddStudent(Student student);
        public Student? GetStudentById(int id);
        public void UpdateStudent(Student student);
        public void DeleteStusent(Student student);
    }
}