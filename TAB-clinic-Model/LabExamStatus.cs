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
        public static string StatusToDBString(this LabExamStatus status)
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

        public static string StatusToDisplayString(this LabExamStatus status)
        {
            return status switch
            {
                LabExamStatus.Requested => "Requested",
                LabExamStatus.CancelledByWorker => "Cancelled By Worker",
                LabExamStatus.CancelledByManager => "Cancelled By Manager",
                LabExamStatus.FinalizedByWorker => "Finalized By Worker",
                LabExamStatus.FinalizedByManager => "Finalized By Manager",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static LabExamStatus StringToStatus(string statusStr)
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
