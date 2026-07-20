namespace Domain.Entities{
     public class Classs
    {
        public int Id {get; set; }
        public string Name {get; set; }
        
        //Prefic should match the Navigation property name
        public int FaculityId{get;set;}
        public int EducationLevelId{get;set;}

        //Nagivation properties
        public Faculity Faculity{get;set;}
        public EducationLevel EducationLevel{get;set;}

          //Navigation Property: One Education Level can have many Classes
       
        public ICollection<Attendence> attendences{get;set;}
    }
}
