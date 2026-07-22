namespace Application.DTOs
{
    public class AddClassStudentDTO
    {
       public int ClasssId{get;set; }
        public int StudentId{get;set;}
        public AddClassDTO Classs{get; set;}
        public AddStudentDTO Student{get; set;}
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
    }
    public class GetClassStudentDTO
    {
        public int Id{get;set; }
       public int ClasssId{get;set; }
        public int StudentId{get;set;}
          public string UserAdded{get;set; }
       public DateTime DateAdded{get;set; }
        public string Status{get;set;}
        public AddClassDTO Classs{get; set;}
        public AddStudentDTO Student{get; set;}
    }

}