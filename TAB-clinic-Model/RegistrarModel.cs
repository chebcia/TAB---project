using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    public class RegistrarModel
    {
        private readonly Registrar dbRegistrar;

        internal RegistrarModel(WrappedContext db)
        {
            dbRegistrar = new();
            db.Context.Add(dbRegistrar);
        }

        internal RegistrarModel(Registrar dbRegistrar)
        {
            this.dbRegistrar = dbRegistrar;
        }

        public int IdRegistrar
        {
            get => dbRegistrar.IdUser;
        }
    }
}