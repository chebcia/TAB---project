using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAB_clinic_Data.Database;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class DoctorService
    {
        private readonly WrappedContext db = new();

        public List<VisitModel> GetDoctorsVisits(UserModel doctor, string surnameFilter, DateTime? dateFilter)
        {
            Doctor doc = UserManager.UserToDoctor(db, doctor);
            if (doc == null)
            {
                return null;
            }

            List<VisitModel> visits = VisitManager.GetDoctorsVisits(db, doc, surnameFilter, dateFilter);

            return visits;
        }
    }
}
