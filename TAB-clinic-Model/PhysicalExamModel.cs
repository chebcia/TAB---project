using System.Linq;

using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    public class PhysicalExamModel
    {
        private readonly PhysicalExam dbPhysicalExam;

        /// <summary>
        /// Creates a new physical exam and adds it to the context. Call SaveChanges() to generate the ID.
        /// </summary>
        /// <param name="db"></param>
        internal PhysicalExamModel(WrappedContext db) //(PhysicalExam physicalExam)
        {
            this.dbPhysicalExam = new();
            db.Context.Add(this.dbPhysicalExam);
        }

        /// <summary>
        /// Wraps an existing bare "PhysicalExam" object.
        /// </summary>
        /// <param name="dbUser"></param>
        internal PhysicalExamModel(PhysicalExam physicalExam)
        {
            this.dbPhysicalExam = physicalExam;
        }

        public int IdExam
        {
            get => dbPhysicalExam.IdPhysicalExam;
        }

        public string Result
        {
            get => dbPhysicalExam.Result;
            set => dbPhysicalExam.Result = value;
        }

        public int IdVisit
        {
            get => dbPhysicalExam.IdVisit;
            set => dbPhysicalExam.IdVisit = value;
        }

        public string Code
        {
            get => dbPhysicalExam.Code;
            set => dbPhysicalExam.Code = value;
        }

        public static PhysicalExamModel? FindPhysicalExam(WrappedContext db, int id)
        {
            return db.Context.PhysicalExams
                             .Where(pe => pe.IdPhysicalExam == id)
                             .Select(pe => new PhysicalExamModel(pe))
                             .FirstOrDefault();
        }
    }
}
