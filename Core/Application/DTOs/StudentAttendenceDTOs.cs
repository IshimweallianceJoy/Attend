using Domain.Entities;
using Domain.ValueObject;

namespace Application.DTOs
{
    public class AddStudentAttendenceDTO
    {
      
        public int StudentId{get; set;}
        public int AttendenceId{get; set;}
         public AttendenceStatus Status{get; set;}

       
    }
    public class UpdateStudentAttendenceDTO
    {
         public int Id{get; set;}
        public int StudentId{get; set;}
        public int AttendenceId{get; set;}
        public AttendenceStatus Status{get; set;}
    }
    public class DeleteStudentAttedenceDTO
    {
         public int Id{get; set;}
         public AttendenceStatus Status{get; set;}
        
    }
    public class GetStudentAttendenceDTO
    {
         public int Id{get; set;}
        public int StudentId{get; set;}
        public Student Student{get; set;}
        public int AttendenceId{get; set;}
        public Attendence Attendence{get; set;}
         public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
       public AttendenceStatus Status{get; set;}
       
    }

}