using System;
using System.Collections.Generic;

#nullable disable

namespace kursach.DataBase
{
    public partial class Discipline
    {
        public Discipline()
        {
            Journals = new HashSet<Journal>();
        }

        public uint Iddisciplines { get; set; }
        public string DisciplinesIndex { get; set; }
        public string DisciplinesName { get; set; }
        public string DisciplinesNameAbbreviated { get; set; }

        public virtual ICollection<Journal> Journals { get; set; }
    }
}
