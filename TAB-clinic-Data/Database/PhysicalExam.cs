#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class PhysicalExam
    {
        public int IdPhysicalExam { get; set; }
        public string Result { get; set; }
        public int IdVisit { get; set; }
        public string Code { get; set; }

        public virtual ExamType CodeNavigation { get; set; }
        public virtual Visit IdVisitNavigation { get; set; }
    }
}
