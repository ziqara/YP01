namespace studentattendancelog.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public required string CourseName { get; set; }
        public required string Description { get; set; }
        public List<Group> Groups = new List<Group>();

    }
}
