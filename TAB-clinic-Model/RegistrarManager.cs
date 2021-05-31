using System.Linq;

namespace TAB_clinic_Model
{
    public static class RegistrarManager
    {
        public static RegistrarModel? FindRegistrar(WrappedContext db, int id)
        {
            var registrar = db.Context.Registrars
                .Where(r => r.IdUser == id)
                .FirstOrDefault();

            if (registrar is null)
            {
                return null;
            }

            return new RegistrarModel(registrar);
        }
    }
}
