using System;

namespace TAB_clinic_Model
{
    public enum ExamKind
    {
        Physical,
        Lab
    }

    public static class ExamKindMethods
    {
        public static string? KindToDBString(this ExamKind kind)
        {
            return kind switch
            {
                ExamKind.Physical => "p",
                ExamKind.Lab => "l",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static ExamKind StringToKind(string kindStr)
        {
            return kindStr switch
            {
                "p" => ExamKind.Physical,
                "l" => ExamKind.Lab,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

    }
}
