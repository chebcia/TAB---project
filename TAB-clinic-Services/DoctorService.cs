using System;
using System.Collections.Generic;
using System.Linq;
using TAB_clinic_Data.Database;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class DoctorService
    {
        private readonly WrappedContext db = new();

        public List<VisitModel>? GetDoctorsVisits(UserModel doctor, string surnameFilter, DateTime? dateFilter)
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

        public void AddPhysicalExam(VisitModel visit, string result, ExamTypeModel type)
        {
            ExamManager.CreatePhysicalExam(db, visit, result, type);
        }

        public void AddLabExam(VisitModel visit, string doctorsNotes, ExamTypeModel type)
        {
            ExamManager.CreateLabExam(db, visit, doctorsNotes, type);
        }

        public ExamTypeModel[] GetPhysicalExamTypes()
        {
            return ExamTypeModel.GetPhysicalExamTypes(db);
        }

        public ExamTypeModel[] GetLabExamTypes()
        {
            return ExamTypeModel.GetLabExamTypes(db);
        }

        public ExamTypeModel? FindExamType(string code)
        {
            return ExamTypeModel.FindExamType(db, code);
        }

        public List<PhysicalExamModel> GetPhysicalExamsForVisit(VisitModel visit)
        {
            return ExamManager.GetPhysicalExams(db).Where(pe => pe.IdVisit == visit.IdVisit).ToList();
        }

        public PhysicalExamModel? FindPhysicalExam(int id)
        {
            return PhysicalExamModel.FindPhysicalExam(db, id);
        }

        public List<LabExamModel> GetLabExamsForVisit(VisitModel visit)
        {
            return ExamManager.GetLabExams(db).Where(le => le.IdVisit == visit.IdVisit).ToList();
        }

        public LabExamModel? FindLabExam(int id)
        {
            return LabExamModel.FindLabExam(db, id);
        }
    }
}
