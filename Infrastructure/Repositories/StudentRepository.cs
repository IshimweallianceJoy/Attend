using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Domain.ValueObject;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
         private readonly ApplicationDbContext _dbcontext;
         private readonly IUserContext _Usercontext;
        public StudentRepository(ApplicationDbContext dbcontext, IUserContext userContext)
        {
            _dbcontext= dbcontext;
            _Usercontext=userContext;
        }


        public async Task<List<GetStudentDTO>> GetStudentsAsync()
        {
            return await _dbcontext.Students.Select(ss => new GetStudentDTO
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
            
            }).ToListAsync();
            
        }
        public async Task AddStudentAsync(AddStudentDTO student)
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
               UserAdded = _Usercontext.Email,
               DateAdded = DateTime.UtcNow,
               Status = StudentStatus.Active,
            });
           await _dbcontext.SaveChangesAsync();
        }
         public async Task <GetStudentDTO?> GetStudentByIdAsync(int id)
        {
            return await _dbcontext.Students.Where(ss => ss.Id == id).Select(ss => new GetStudentDTO
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
            }).FirstOrDefaultAsync();
            
        }
        public async Task UpdateStudentAsync(UpdateStudentDTO student)
        {
           

             var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Id = student.Id;
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.Adress = student.Adress;
                ExistingStudent.Phone = student.Phone;
                ExistingStudent.ParentNames = student.ParentNames;
                ExistingStudent.ParentPhone = student.ParentPhone;
                

              await  _dbcontext.SaveChangesAsync();
        }    }
        public async Task DeleteStusentAsync(DeleteStudentDTO student)
        {
            var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(ss => ss.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Status =student.Status;

                await _dbcontext.SaveChangesAsync();
            }
        }
           public async Task<List<GetStudentStatusCountDTO>> GetStudentStatusCountAsync()
        {
           return await _dbcontext.Students
           .GroupBy(c => c.Status)
           .Select(c => new GetStudentStatusCountDTO
           {
               Status = c.Key,
               Count = c.Count()
           })
           .ToListAsync();
        }
            public async Task<List<GetStudentSexCountDTO>> GetStudentSexCountAsync()
        {
           return await _dbcontext.Students
           .GroupBy(c => c.Sex)
           .Select(c => new GetStudentSexCountDTO
           {
               Sex = c.Key,
               Count = c.Count()
           })
           .ToListAsync();
        }
    } 
}