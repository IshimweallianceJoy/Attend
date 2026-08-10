using Domain.Entities;
using Domain.ValueObject;

namespace Application.DTOs
{
    public class AddAttendenceDTO
    {
         public int ClasssId {get; set;}
         
         public string InstructorName{get; set;}
         public DateTime Date{get; set;}
         public AttendenceStatus Status { get; set; }
         
    }
    public class UpdateAttendenceDTO
    {
          public int Id {get; set; }
    
        public int ClasssId {get; set;}
        public string UserAdded{get; set;}
        
    }
    public class DeleteAttendenceDTO
    {
          public int Id {get; set; }
           public AttendenceStatus Status { get; set; }
    
    }
    public class GetAttendenceDTO
    {
        
        public int Id {get; set; }
    
        public int ClasssId {get; set;}
        public Classs Classs{get; set;}
        public string InstructorName{get; set;}
        public AttendenceStatus Status { get; set; }
        public DateTime Date { get; set; }

        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
}