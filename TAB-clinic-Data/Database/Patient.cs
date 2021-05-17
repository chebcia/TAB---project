using System.Collections.Generic;

#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class Patient
    {
        public Patient()
        {
            Visits = new HashSet<Visit>();
        }

        public int IdPatient { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Pesel { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
