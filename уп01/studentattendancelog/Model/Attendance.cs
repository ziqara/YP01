namespace studentattendancelog.Model
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Lesson Lesson { get; set; }
        public Student Student { get; set; }
        // public enum AttendanceStatus { Присутствовал, Отсутствовал, Опоздал }
    }
}
