using Domain.ValueObject;
namespace Application.DTOs
{
    public class AddStudentDTO
    {
        
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public SexStatus Sex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RegNumber { get; set; }
        public string Adress { get; set; }
        public string ParentNames { get; set; }
        public string ParentPhone { get; set; }
        
        
    }
    public class UpdateStudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SexStatus Sex { get; set; }
        public string Phone { get; set; }
          public string Adress { get; set; }
        public string ParentNames { get; set; }
        public string ParentPhone { get; set; }
       
        
    }
       public class DeleteStudentDTO
    {
        public int Id { get; set; }
        public StudentStatus Status{get; set;}
        
    }
    public class GetStudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public SexStatus Sex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RegNumber { get; set; }
        public string Adress { get; set; }
        public string ParentNames { get; set; }
        public string ParentPhone { get; set; }
         public string UserAdded { get; set; } 
        public DateTime DateAdded { get; set; } 
   
        public StudentStatus Status{get; set;}
   }

        public class GetStudentStatusCountDTO
    {
        public StudentStatus Status{get; set;}
        public int Count{get;set;}
    }
    
        public class GetStudentSexCountDTO
    {
        public SexStatus Sex{get; set;}
        public int Count{get;set;}
    }


}