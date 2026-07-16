namespace Domain.Entities{
     public class Attendence
    {
        public int Id {get; set; }
        public int StudentId {get; set; }
        public int ClassesId {get; set;}
         public  TimeOnly Time{get; set;}
        public  DateTime Date{get; set;}
         public  String Status{get; set;}
         public Student student{get; set;} 
         public Classs Classes{get; set;}
    }
}