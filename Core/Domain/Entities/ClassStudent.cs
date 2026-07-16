namespace Domain.Entities
{
    public class ClassStudent{
        public int Id{get;set; }
        public int ClassesId{get;set; }
        public int StudentsId{get;set;}

        public Classs Classes{get; set;}
        public Student students{get; set;}
        
    }

}