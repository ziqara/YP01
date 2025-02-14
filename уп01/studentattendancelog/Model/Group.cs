﻿using System.Collections.Generic;

namespace studentattendancelog.Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public required string GroupName { get; set; }
        public List<Student> Students = new List<Student>();
        public required Course Course { get; set; }
    }
}
