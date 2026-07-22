namespace Domain.Entities
{
    public class ClassStudent{
        public int Id{get;set; }
        public int ClasssId{get;set; }
        public int StudentId{get;set;}
        public Classs Classs{get; set;}
        public Student Student{get; set;}
         public string UserAdded{get;set; }
       public DateTime DateAdded{get;set; }
        public string Status{get;set;}
        
    
    }

}