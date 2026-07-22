using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Application.DTOs;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
         private readonly ApplicationDbContext _dbcontext;
        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<GetStudentDTO> GetStudents()
        {
            return _dbcontext.Students.Select(ss => new GetStudentDTO
            {
                Id = ss.Id,
                Name = ss.Name,
               DOB = ss.DOB,
               Sex = ss.Sex,
               Phone = ss.Phone,
               Email = ss.Email,
               RegNumber = ss.RegNumber,
               Adress = ss.Adress,
               ParentNames = ss.ParentNames,
               ParentPhone = ss.ParentPhone,
               UserAdded = ss.UserAdded,
               DateAdded = ss.DateAdded,
               Status = ss.Status,
            
            }).ToList();
            
        }
        public void AddStudent(AddStudentDTO student)
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
               UserAdded = "Joy",
               DateAdded = DateTime.UtcNow,
               Status = "Active"
            });
            _dbcontext.SaveChanges();
        }
         public GetStudentDTO? GetStudentById(int id)
        {
            return _dbcontext.Students.Where(ss => ss.Id == id).Select(ss => new GetStudentDTO
            {
                Id = ss.Id,
                 Name = ss.Name,
               DOB = ss.DOB,
               Sex = ss.Sex,
               Phone = ss.Phone,
               Email = ss.Email,
               RegNumber = ss.RegNumber,
               Adress = ss.Adress,
               ParentNames = ss.ParentNames,
               ParentPhone = ss.ParentPhone,
               UserAdded = ss.UserAdded,
               DateAdded = ss.DateAdded,
               Status = ss.Status,
            }).FirstOrDefault();
            
        }
        public void UpdateStudent(UpdateStudentDTO student)
        {
           

             var ExistingStudent =  _dbcontext.Students.FirstOrDefault(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Id = student.Id;
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.Adress = student.Adress;
                ExistingStudent.Phone = ExistingStudent.Phone;

                _dbcontext.SaveChanges();
        }    }
        public void DeleteStusent(DeleteStudentDTO student)
        {
            var ExistingStudent = _dbcontext.Students.FirstOrDefault(ss => ss.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Status = "Deleted";

                 _dbcontext.SaveChanges();
            }
        }
    } 
}