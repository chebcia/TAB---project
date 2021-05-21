using System;
using System.Windows.Forms;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{ 
    public partial class LoginForm : Form
    {
        // Each "Main" Form should own a service object.
        private readonly LoginService loginService = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // automatically generated, probably important
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            var user = loginService.SignIn(login, password);
            if (user is null)
            {
                MessageBox.Show("Invalid credentials! (hint: default account has login 'admin' and password 'admin')", "Failed");
                return;
            }

            // open user's main form
            // TODO: add other forms
            switch (user.Role)
            {
                case TAB_clinic_Model.ClinicRole.Admin:
                    new AdminMainForm().ShowDialog();
                    break;
                case TAB_clinic_Model.ClinicRole.Doctor:
                    new DoctorForm(user).ShowDialog();
                    break;
                default:
                    MessageBox.Show("Work in progress");
                    break;
            }
        }
    }
}