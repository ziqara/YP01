namespace studentattendancelog.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public List<Group> Groups = new List<Group>();

    }
}
