namespace TAB_clinic_Model
{
    public static class SampleDataGenerator
    {
        public static void CreateSampleUsers()
        {
            try
            {
                UserContext.CreateUser("natalia", "cheba", TAB_clinic_Model.ClinicRole.Registrar);
                UserContext.CreateUser("dr", "augustyn", TAB_clinic_Model.ClinicRole.Doctor);
                UserContext.CreateUser("jerzy", "bodzenta", TAB_clinic_Model.ClinicRole.LabManager);
                UserContext.CreateUser("dariusz", "mrozek", TAB_clinic_Model.ClinicRole.LabWorker);
            }
            catch (UserAlreadyExistsException)
            {}
        }


    }
}
