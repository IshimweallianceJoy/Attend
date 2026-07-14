using Application.Interface;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
         public List<Student> GetStudents()
        {
          return new List<Student>
            {
                new Student{Id=1,Name="joy",DOB=new DateTime(2004,04,5),Email="joy@gmail.com",Phone="078656644",Sex="male"},
                new Student{Id=1,Name="joy",DOB=new DateTime(2004,04,5),Email="joy@gmail.com",Phone="078656644",Sex="male"}
            };
        }
    } 
}