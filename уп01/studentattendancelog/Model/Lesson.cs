﻿namespace studentattendancelog.Model
{
    public class Lesson
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public DateTime DateTime { get; set; }
        public List<Attendance> AttendanceRecords { get; set; }
    }
}
