using TAB_clinic_Data.Database;
using static TAB_clinic_Model.ClinicRoleMethods;
using static BCrypt.Net.BCrypt;

namespace TAB_clinic_Model
{
    // Wraps the EF-generated "User" class, so that hand-written code (methods, setters with validation) is separate from the EF classes.
    // This allows us to recreate them easily, without having to move that custom code manually.

    // TODO: add validation to setters

    /// <summary>
    /// 
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Creates a new user and adds it to the context. Call SaveChanges() to generate the ID.
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
            set => dbUser.Login = value;
        }

        public string Password
        {
            get => dbUser.Password;
            set => dbUser.Password = HashPassword(value);
        }

        public ClinicRole Role
        {
            get => StringToRole(dbUser.Role);
            set => dbUser.Role = value.RoleToString();
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

        public string Lastname
        {
            get => dbUser.Lastname;
            set => dbUser.Lastname = value;
        }

        public bool CheckPassword(string plaintextPassword)
        {
            return Verify(plaintextPassword, this.Password);
        }
    }
}
