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
    }
    public class GetClassDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FaculityId { get; set; }
        public int EducationLevelId { get; set; }
         public string UserAdded{get; set;}
        public DateTime DateAdded{get; set;}
        public string Status{get; set;}
    }
}