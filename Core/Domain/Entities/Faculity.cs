namespace Domain.Entities
{
    public class Faculity
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string UserAdded {get;set;}
        public DateTime DateAdded {get;set;}
        public string Status {get;set;}
        
         //Navigation Property: One Education Level can have many Classes
        public ICollection<Classs> classes{get;set;}
    }
}