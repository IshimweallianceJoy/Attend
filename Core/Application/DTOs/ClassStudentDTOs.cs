using Domain.Entities;
using Domain.ValueObject;
namespace Application.DTOs
{
    public class AddClassStudentDTO
    {
       public int ClasssId{get;set; }
        public int StudentId{get;set;}
        public AddClassDTO Classs{get; set;}
        public AddStudentDTO Student{get; set;}
         public DateOnly? StartDate{get; set;}
        public DateOnly? EndDate{get; set;}
    }
    public class UpdateClassStudentDTO
    {
        public int Id{get;set; }
         public int ClasssId{get;set; }
        public int StudentId{get;set;}
    }
    public class DeleteClassStudentDTO
    {
        public int Id{get;set; }
        public ClassStudentStatus Status{get; set;}
    }
    public class GetClassStudentDTO
    {
        public int Id{get;set; }
       public int ClasssId{get;set; }
        public Classs Classs{get; set;}
        public int StudentId{get;set;}
        public Student Student{get; set; }
         public DateOnly? StartDate{get; set;}
        public DateOnly? EndDate{get; set;}
          public string UserAdded{get;set; }
       public DateTime DateAdded{get;set; }
        public ClassStudentStatus Status{get; set;}
       
    }

}