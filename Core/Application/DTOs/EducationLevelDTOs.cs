namespace Application.DTOs
{
    public class GetEducationLevelDTO
    {
        public int Id {get; set;}
        public string Name {get;set;}
        public string UserAdded {get;set;}
        public DateTime DateAdded {get;set;}
        public string Status {get;set;}
    }
    public class AddEducationLevelDTO
    {
        public string Name {get;set;}
      
    }
    public class UpdateEducationLevelDTO
    {
        public int Id {get; set;}
        public string Name {get;set;}
    }
    public class DeleteEducationLevelDTO
    {
        public int Id {get; set;}
    }
}
