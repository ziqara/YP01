namespace studentattendancelog.Model
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public Lesson Lesson { get; set; }
        public Student Student { get; set; }
        public enum AttendanceStatus { Присутствовал, Отсутствовал, Опоздал }
    }
}
