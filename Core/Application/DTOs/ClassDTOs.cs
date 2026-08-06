using Domain.Entities;
using Domain.ValueObject;
namespace Application.DTOs
{
    public class AddClassDTO
    {
        public string Name { get; set; }
        public int FaculityId { get; set; }
        public int EducationLevelId { get; set; }
         

        
    
    }
    public class UpdateClassDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FaculityId { get; set; }
        public int EducationLevelId { get; set; }
    }
    public class DeleteClassDTO
    {
        public int Id { get; set; }
         public ClassStatus Status{get; set;}
    }
    public class GetClassDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FaculityId { get; set; }
        public Faculity Faculity { get; set; }
        public int EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public ClassStatus Status { get; set;}
    }
       public class GetClassStatusCountDTO
    {
        public ClassStatus Status{get; set;}
        public int Count{get;set;}
    }
}