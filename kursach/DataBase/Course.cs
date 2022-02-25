using System;
using System.Collections.Generic;

#nullable disable

namespace kursach.DataBase
{
    public partial class Course
    {
        public Course()
        {
            Groups = new HashSet<Group>();
        }

        public uint Idcourse { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
