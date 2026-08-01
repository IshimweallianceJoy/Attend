using Domain.Entities;

namespace Application.DTOs
{
    public class AddAttendenceDTO
    {
         public int ClasssId {get; set;}
    }
    public class UpdateAttendenceDTO
    {
          public int Id {get; set; }
    
        public int ClasssId {get; set;}
    }
    public class DeleteAttendenceDTO
    {
          public int Id {get; set; }
    
    }
    public class GetAttendenceDTO
    {
        
        public int Id {get; set; }
    
        public int ClasssId {get; set;}
        public Classs Classs{get; set;}
    
        public string UserAdded{get; set;}
        public DateTime DateAdded{get; set;}
        public string Status{get; set;}
    }
}