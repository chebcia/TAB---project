using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAB_clinic_Model
{
    /// <summary>
    /// describes the status of a visit
    /// </summary>
    public enum VisitStatus
    {
        registered,
        finalized,
        cancelled
    }

    public static class VisitStatusMethods
    {
        public static string? StatusToStr(VisitStatus status)
        {
            return status switch
            {
                VisitStatus.registered => "r",
                VisitStatus.finalized => "f",
                VisitStatus.cancelled => "c",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static VisitStatus StrToStatus(string statusStr)
        {
            return statusStr switch
            {
                "f" => VisitStatus.finalized,
                "r" => VisitStatus.registered,
                "c" => VisitStatus.cancelled,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

    }
}
