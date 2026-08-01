namespace Domain.Entities
{
    public class StudentAttendence
    {
        public int Id{get; set;}
        public int StudentId{get; set;}
        public int AttendenceId{get; set;}
        public  DateTime Date{get; set;}
        public string Status{get; set;}
        public Attendence Attendence{get; set;}
        public Student Student{get; set;}

    }
}