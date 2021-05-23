using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAB_clinic_Model
{
    public enum LabExamStatus
    {
        Requested,
        CancelledByWorker,
        CancelledByManager,
        FinalizedByWorker,
        FinalizedByManager
    }

    public static class LabExamStatusMethods
    {
        public static string? StatusToStr(this LabExamStatus status)
        {
            return status switch
            {
                LabExamStatus.Requested => "re",
                LabExamStatus.CancelledByWorker => "cw",
                LabExamStatus.CancelledByManager => "cm",
                LabExamStatus.FinalizedByWorker => "fw",
                LabExamStatus.FinalizedByManager => "fm",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static LabExamStatus StrToStatus(string statusStr)
        {
            return statusStr switch
            {
                "re" => LabExamStatus.Requested,
                "cw" => LabExamStatus.CancelledByWorker,
                "cm" => LabExamStatus.CancelledByManager,
                "fw" => LabExamStatus.FinalizedByWorker,
                "fm" => LabExamStatus.FinalizedByManager,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

    }
}
