﻿using System;
using System.Collections.Generic;

#nullable disable

namespace kursach.DataBase
{
    public partial class Journal
    {
        public uint Idjournal { get; set; }
        public uint StudentsIdstudents { get; set; }
        public uint DisciplinesIddisciplines { get; set; }
        public uint TeachersIdteachers { get; set; }
        public DateTime? JournalDate { get; set; }
        public int? JournalScore { get; set; }

        public virtual Discipline DisciplinesIddisciplinesNavigation { get; set; }
        public virtual Student StudentsIdstudentsNavigation { get; set; }
        public virtual Teacher TeachersIdteachersNavigation { get; set; }
    }
}
