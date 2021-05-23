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

        /// <summary>
        /// Gets a Doctor's visit, checks if the visit is registered for him
        /// </summary>
        /// <param name="doctor">the doctor who is registered with the visit</param>
        /// <param name="id">id of the visit</param>
        /// <returns></returns>
        public VisitModel GetVisit(int id)
        {
            return VisitManager.GetVisit(db, id);
        }

        public void saveVisit(VisitModel visit)
        {
            db.SaveChanges();
        }

        public void AddPhysicalExam(VisitModel visit, string result, string code)
        {
            ExamManager.CreatePhysicalExam(db, visit, result, code);
        }

        public void AddLabExam(VisitModel visit, string doctorsNotes, string code)
        {
            ExamManager.CreateLabExam(db, visit, doctorsNotes, code);
        }
    }
}
