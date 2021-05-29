using TAB_clinic_Data.Database;
using static TAB_clinic_Model.ClinicRoleMethods;
using static BCrypt.Net.BCrypt;
using System.Text.RegularExpressions;

namespace TAB_clinic_Model
{
    // Wraps the EF-generated "User" class, so that hand-written code (methods, setters with validation) is separate from the EF classes.
    // This allows us to recreate them easily, without having to move that custom code manually.

    /// <summary>
    /// Represents an existing user. Call <c>AdminService.CreateUser()</c> to create one with proper relationships.
    /// </summary>
    public class PatientModel
    {
        /// <summary>
        /// Creates a new user and adds it to the context. Call <c>db.SaveChanges()</c> to generate the ID.
        /// </summary>
        /// <param name="db"></param>
        internal PatientModel(WrappedContext db) //(User dbUser)
        {
            dbPatient = new();
            db.Context.Add(dbPatient);
        }

        /// <summary>
        /// Wraps an existing bare "User" object.
        /// </summary>
        /// <param name="dbPatient"></param>
        internal PatientModel(Patient dbPatient)
        {
            this.dbPatient = dbPatient;
        }

        private readonly Patient dbPatient;

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
                    throw new InvalidUserDataException("Login cannot be empty.");
                }

                var rgx = new Regex("\\w");
                if (rgx.IsMatch(value))
                {
                    dbPatient.Name = value;
                }
                else
                {
                    throw new InvalidUserDataException("Login contains invalid characters.");
                }
            }
        }

        public string Lastname
        {
            get => dbPatient.Lastname;
            set
            {
                if (value.Length <= 0)
                {
                    throw new InvalidUserDataException("Password must be at least 4 characters long.");
                }
                else
                {
                    dbPatient.Lastname = value;
                }
            }
        }

        public string PESEL
        {
            get => dbPatient.PESEL;
            set
            {
                if (value.Length <= 0)
                {
                    throw new InvalidUserDataException("Password must be at least 4 characters long.");
                }
                else
                {
                    dbPatient.PESEL = value;
                }
            }
        }
    }
}
