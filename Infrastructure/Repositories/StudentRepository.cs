using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
         private readonly ApplicationDbContext _dbcontext;
        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<Student> GetStudents()
        {
            return _dbcontext.Students.ToList();
        }
        public void AddStudent(Student student)
        {
            _dbcontext.Students.Add(new Student
            {
               Name = student.Name,
               DOB = student.DOB,
               Sex = student.Sex,
               Phone = student.Phone,
               Email = student.Email,
               RegNumber = student.RegNumber,
               Adress = student.Adress,
               ParentNames = student.ParentNames,
               ParentPhone = student.ParentPhone,
               UserAdded = "Admin",
               DateAdded = DateTime.UtcNow,
               Status = "Active"
            });
            _dbcontext.SaveChanges();
        }
         public Student? GetStudentById(int id)
        {
            return _dbcontext.Students.FirstOrDefault(ss => ss.Id == id);
        }
        public void UpdateStudent(Student student)
        {
           

             var ExistingStudent =  _dbcontext.Students.FirstOrDefault(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.Adress = student.Adress;
                ExistingStudent.Phone = ExistingStudent.Phone;

                _dbcontext.SaveChanges();
        }    }
        public void DeleteStusent(Student student)
        {
            var ExistingStudent = _dbcontext.Students.FirstOrDefault(ss => ss.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Status =student.Status= "Deleted";

                 _dbcontext.SaveChanges();
            }
        }
    } 
}