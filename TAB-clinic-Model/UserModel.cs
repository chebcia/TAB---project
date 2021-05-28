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
    public class UserModel
    {
        /// <summary>
        /// Creates a new user and adds it to the context. Call <c>db.SaveChanges()</c> to generate the ID.
        /// </summary>
        /// <param name="db"></param>
        internal UserModel(WrappedContext db) //(User dbUser)
        {
            dbUser = new();
            db.Context.Add(dbUser);
        }

        /// <summary>
        /// Wraps an existing bare "User" object.
        /// </summary>
        /// <param name="dbUser"></param>
        internal UserModel(User dbUser)
        {
            this.dbUser = dbUser;
        }

        private readonly User dbUser;

        public int IdUser
        {
            get => dbUser.IdUser;
        }

        public string Login
        {
            get => dbUser.Login;
            set
            {
                var rgx = new Regex("\\w");     // only allows aA-zZ, 0-9 and _
                if (rgx.IsMatch(value))
                {
                    dbUser.Login = value;
                }
                else
                {
                    throw new InvalidUserDataException("Login contains invalid characters.");
                }
            }
        }

        public string Password
        {
            private get => dbUser.Password;
            set
            {
                if (value.Length < 4)
                {
                    throw new InvalidUserDataException("Password must be at least 4 characters long.");
                }
                else
                {
                    dbUser.Password = HashPassword(value);
                }
            }
        }

        public ClinicRole Role
        {
            get => StringToRole(dbUser.Role);
            set => dbUser.Role = value.RoleToDBString();
        }

        public bool Active
        {
            get => dbUser.Active[0] == ('A');
            set => dbUser.Active = value ? "A" : "N";
        }

        public string Name
        {
            get => dbUser.Name;
            set => dbUser.Name = value;
        }

        public string LastName
        {
            get => dbUser.Lastname;
            set => dbUser.Lastname = value;
        }

        public bool CheckPassword(string plaintextPassword)
        {
            return Verify(plaintextPassword, this.Password);
        }

        internal void DeleteFromContext(WrappedContext db)
        {
            db.Context.Users.Remove(dbUser);
        }
    }
}
