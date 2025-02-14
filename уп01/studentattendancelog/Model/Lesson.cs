namespace studentattendancelog.Model
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public Course Course { get; set; }
        public DateTime LessonDateTime { get; set; }
        public List<Attendance> AttendanceRecords = new List<Attendance>();
    }
}
