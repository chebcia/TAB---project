using System;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Describes the role of a user.
    /// </summary>
    public enum ClinicRole
    {
        Admin,
        Registrar,
        Doctor,
        LabWorker,
        LabManager
    }

    public static class ClinicRoleMethods
    {
        public static string? RoleToString(this ClinicRole role)
        {
            return role switch
            {
                ClinicRole.Admin => null,
                ClinicRole.Registrar => "reg",
                ClinicRole.Doctor => "doc",
                ClinicRole.LabWorker => "lab_w",
                ClinicRole.LabManager => "lab_m",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static ClinicRole StringToRole(string? role)
        {
            return role switch
            {
                null => ClinicRole.Admin,
                "reg" => ClinicRole.Registrar,
                "doc" => ClinicRole.Doctor,
                "lab_w" => ClinicRole.LabWorker,
                "lab_m" => ClinicRole.LabManager,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
