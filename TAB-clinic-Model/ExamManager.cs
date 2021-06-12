using System;
using System.Collections.Generic;
using System.Linq;
using TAB_clinic_Data.Database;
using TAB_clinic_Model;

namespace TAB_clinic_Model
{
    public static class ExamManager
    {
        public static void CreatePhysicalExam(WrappedContext db, VisitModel visit, string result, ExamTypeModel type)
        {
            if (type.Kind != ExamKind.Physical)
            {
                throw new ArgumentException("Attempted to assign a non-physical exam type to a physical exam");
            }

            var context = db.Context;
            var newExam = new PhysicalExamModel(db)
            {
                IdVisit = visit.IdVisit,
                Result = result,
                Code = type.Code
            };

            context.SaveChanges();
        }
        public static void CreateLabExam(WrappedContext db, VisitModel visit, string doctorsNotes, ExamTypeModel type)
        {
            if (type.Kind != ExamKind.Lab)
            {
                throw new ArgumentException("Attempted to assign a non-lab exam type to a lab exam");
            }

            var context = db.Context;
            var newExam = new LabExamModel(db)
            {
                IdVisit = visit.IdVisit,
                DoctorsNotes = doctorsNotes,
                Code = type.Code
            };

            context.SaveChanges();
        }

        public static List<PhysicalExamModel> GetPhysicalExams(WrappedContext db)
        {
            return db.Context.PhysicalExams.Select(pe => new PhysicalExamModel(pe)).ToList();
        }

        public static List<LabExamModel> GetLabExams(WrappedContext db)
        {
            return db.Context.LabExams.Select(le => new LabExamModel(le)).ToList();
        }

        public static List<LabExamModel> GetLabExams(WrappedContext db, DateTime? dateTime, int status)
        {

            /*var examList = db.Context.LabExams.Select(le => new LabExamModel(le)).ToList();
            List<LabExamModel> exams = new();
            if (status < 0)
            {
                if (dateTime.HasValue)
                {
                    exams = (List<LabExamModel>)(from e in examList
                            where dateTime.Value.Date.Equals(e.DtRequest.Date)
                            select e);
                }
                exams = examList;
            }
            else
            {
                if (dateTime.HasValue)
                {
                    exams = (List<LabExamModel>)from e in examList
                            where dateTime.Value.Date.Equals(e.DtRequest.Date) &&
                            e.Status.Equals((LabExamStatus)status)
                            select e;
                }
                else
                {
                    exams = (List<LabExamModel>)from e in examList
                            where e.Status.Equals((LabExamStatus)status)
                            select e;
                }
            }

            List<LabExamModel> ret = new();
            System.Collections.IList list = exams.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                LabExam e = (LabExam)list[i];
                ret.Add(new LabExamModel(e));
            }
            */
            return null;
        }
    }
}
