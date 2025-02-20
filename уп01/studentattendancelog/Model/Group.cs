using System.Collections.Generic;

namespace studentattendancelog.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }
        public Course Course { get; set; }
    }
}
