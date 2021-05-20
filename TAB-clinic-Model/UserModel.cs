using TAB_clinic_Data.Database;
using static TAB_clinic_Model.ClinicRoleMethods;
using static BCrypt.Net.BCrypt;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Represents an EXISTING user. To create a user, use <c>UserContext.CreateUser()</c>.
    /// </summary>
    public class UserModel
    {
        internal UserModel(WrappedContext db) //(User dbUser)
        {
            dbUser = new();
            db.Context.Add(dbUser);
        }

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
