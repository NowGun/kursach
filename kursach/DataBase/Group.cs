using System;
using System.Collections.Generic;

#nullable disable

namespace kursach.DataBase
{
    public partial class Group
    {
        public Group()
        {
            Schedules = new HashSet<Schedule>();
            TeachersHasGroups = new HashSet<TeachersHasGroup>();
        }

        public uint Idgroups { get; set; }
        public string GroupsName { get; set; }
        public string GroupsNameAbbreviated { get; set; }
        public string GroupsPrefix { get; set; }
        public uint TypelearningIdtypelearning { get; set; }
        public uint TeachersIdteachers { get; set; }
        public uint CourseIdcourse { get; set; }

        public virtual Course CourseIdcourseNavigation { get; set; }
        public virtual Typelearning TypelearningIdtypelearningNavigation { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<TeachersHasGroup> TeachersHasGroups { get; set; }
    }
}
