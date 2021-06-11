using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAB_clinic_Data.Database;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class LabService
    {
        private readonly WrappedContext db = new();

        public List<LabExamModel>? LabExamList(DateTime? dateReques, int status )
        {
            
            return ExamManager.GetLabExams(db);
        }

        public Array GetExamStatus()
        {
            Array status = Enum.GetNames(typeof(LabExamStatus));
            string[] addAll = { "All" };
            addAll.CopyTo(status, 0);
            return status;

        }



    }
}
