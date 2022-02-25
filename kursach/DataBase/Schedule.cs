﻿using System;
using System.Collections.Generic;

#nullable disable

namespace kursach.DataBase
{
    public partial class Schedule
    {
        public uint Idschedule { get; set; }
        public uint GroupsIdgroups { get; set; }
        public uint WeekdayIdweekday { get; set; }
        public uint PeriodclassesIdperiodclasses { get; set; }
        public uint TeachersIdteachers { get; set; }
        public uint CabinetIdcabinet { get; set; }
        public uint TypeclassesIdtypeclasses { get; set; }
        public DateTime ScheduleDate { get; set; }

        public virtual Group GroupsIdgroupsNavigation { get; set; }
        public virtual Teacher TeachersIdteachersNavigation { get; set; }
        public virtual Weekday WeekdayIdweekdayNavigation { get; set; }
    }
}
