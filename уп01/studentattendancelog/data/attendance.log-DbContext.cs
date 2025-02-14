using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using studentattendancelog.Model;

namespace studentattendancelog.data
{
    public class attendance_log : DbContext
    {
        public attendance_log(DbContextOptions<attendance_log> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}