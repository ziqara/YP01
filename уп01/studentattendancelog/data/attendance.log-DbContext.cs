using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using studentattendancelog.Model;

namespace studentattendancelog.data
{
    
    public class Attendance_log : DbContext
    {
        public Attendance_log(DbContextOptions<Attendance_log> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}