using System;
using System.Collections.Generic;

#nullable disable

namespace TAB_clinic_GUI.Database
{
    public partial class Registar
    {
        public Registar()
        {
            Visits = new HashSet<Visit>();
        }

        public int IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
