namespace studentattendancelog.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string MiddleName { get; set;}
        public Group Group { get; set;}
        public string Email { get; set;}
        public string PhoneNumber { get; set;}
    }
}
