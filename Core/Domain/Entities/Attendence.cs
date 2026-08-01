namespace Domain.Entities{
     public class Attendence
    {
        public int Id {get; set; }
    
        public int ClasssId {get; set;}
    
        public string UserAdded{get; set;}
        public DateTime DateAdded{get; set;}
        public string Status{get; set;}
        
         public Classs Classs{get; set;}

         

         
    }
}