using Domain.ValueObject;
namespace Domain.Entities
{
    public class StudentAttendence
    {
        public int Id{get; set;}
        public int StudentId{get; set;}
        public int AttendenceId{get; set;}
        public  DateTime Date{get; set;}
        //Enum Status
        public AttendenceStatus Status{get; set;}

        //Navigation Properties for Relationships 
        public Attendence Attendence{get; set;}
        public Student Student{get; set;}

    }
}