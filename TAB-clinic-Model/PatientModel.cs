using System.Text.RegularExpressions;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    public class PatientModel
    {
        private readonly Patient dbPatient;
        
        internal PatientModel(WrappedContext db)
        {
            dbPatient = new();
            db.Context.Add(dbPatient);
        }

        internal PatientModel(Patient dbPatient)
        {
            this.dbPatient = dbPatient;
        }

        public int IdPatient
        {
            get => dbPatient.IdPatient;
        }

        public string Name
        {
            get => dbPatient.Name;
            set
            {
                if (value.Length <= 0)
                {
                    throw new InvalidUserDataException("Name cannot be empty.");
                }

                var regexp = new Regex("\\w");  // TODO: fix regex

                if (!regexp.IsMatch(value))
                {
                    throw new InvalidUserDataException("Name contains invalid characters.");
                }

                dbPatient.Name = value;
            }
        }

        public string LastName
        {
            get => dbPatient.Lastname;
            set
            {
                if (value.Length <= 0)
                {
                    throw new InvalidUserDataException("Last name cannot be empty.");
                }

                var regexp = new Regex("\\w");  // TODO: fix regex

                if (!regexp.IsMatch(value))
                {
                    throw new InvalidUserDataException("Last name contains invalid characters.");
                }

                dbPatient.Lastname = value;
            }
        }

        public string Pesel
        {
            get => dbPatient.Pesel;
            set
            {
                if (value.Length != 11)
                {
                        throw new InvalidUserDataException("PESEL have to contain 11 characters");
                }

                var regexp = new Regex("\\d");  // TODO: doesn't work

                if (!regexp.IsMatch(value))
                {
                    throw new InvalidUserDataException("PESEL contains invalid characters.");
                }

                dbPatient.Pesel = value;
            }
        }
    }
}
