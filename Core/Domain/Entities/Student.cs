namespace Domain.Entities
{
     public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RegNumber { get; set; }
        public string Adress { get; set; }
        public string ParentNames { get; set; }
        public string ParentPhone { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string Status { get; set; }

          //Navigation Property: One Education Level can have many Classes
        
        
    }
}
 