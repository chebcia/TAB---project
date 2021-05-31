using System.Linq;

using static TAB_clinic_Model.ExamKindMethods;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    public class ExamTypeModel
    {
        private readonly ExamType dbType;

        internal ExamTypeModel(ExamType examType)
        {
            this.dbType = examType;
        }

        public string Code
        {
            get => this.dbType.Code;
        }

        public string Name
        {
            get => this.dbType.Name;
        }

        public ExamKind Kind
        {
            get => StringToKind(this.dbType.Type);
        }

        public override string ToString()
        {
            return this.Name;
        }

        public static ExamTypeModel? FindExamType(WrappedContext db, string code)
        {
            return db.Context.ExamTypes
                             .Where(et => et.Code == code)
                             .Select(et => new ExamTypeModel(et))
                             .FirstOrDefault();
        }

        public static ExamTypeModel[] GetPhysicalExamTypes(WrappedContext db)
        {
            return db.Context.ExamTypes.Where(et => et.Type == ExamKind.Physical.KindToDBString())
                                       .Select(et => new ExamTypeModel(et)).ToArray();
        }

        public static ExamTypeModel[] GetLabExamTypes(WrappedContext db)
        {
            return db.Context.ExamTypes.Where(et => et.Type == ExamKind.Lab.KindToDBString())
                                       .Select(et => new ExamTypeModel(et)).ToArray();
        }
    }
}
