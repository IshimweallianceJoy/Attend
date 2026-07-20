namespace Domain.Entities{
     public class Attendence
    {
        public int Id {get; set; }
    
        public int ClasssId {get; set;}
        
        public string   Name{get; set;}
         public Classs Classs{get; set;}

         
    }
}