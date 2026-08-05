// using Domain.ValueObject;
namespace Application.DTOs
{
    public class GetFaculityDTO
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string UserAdded {get;set;}
        public DateTime DateAdded {get;set;}
        public string Status {get;set;}
        // public FaculityStatus Status {get;set;}
    }
    public class AddFaculityDTO
    {
        public string Name {get;set;}
      
    }
    public class UpdateFaculityDTO
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }
    public class DeleteFaculityDTO
    {
        public int Id {get;set;}
        //  public FaculityStatus Status {get;set;}
        
    }
}