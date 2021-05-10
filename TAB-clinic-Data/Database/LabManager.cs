using System;
using System.Collections.Generic;

#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class LabManager
    {
        public LabManager()
        {
            LabExams = new HashSet<LabExam>();
        }

        public int IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<LabExam> LabExams { get; set; }
    }
}
