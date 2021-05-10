using System;
using System.Collections.Generic;

#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Active { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual LabManager LabManager { get; set; }
        public virtual LabWorker LabWorker { get; set; }
        public virtual Registar Registar { get; set; }
    }
}
