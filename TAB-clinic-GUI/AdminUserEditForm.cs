using System;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class AdminUserEditForm : Form
    {
        // one of these is null and the other is not
        private readonly UserModel editedUser;
        private readonly AdminService adminService;

        public AdminUserEditForm(bool editingAllowed)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(ClinicRole));

            textBox2.Enabled = editingAllowed;
            textBox3.Enabled = editingAllowed;
            textBox4.Enabled = editingAllowed;
            checkBox1.Enabled = editingAllowed;
            button1.Enabled = editingAllowed;
        }

        public AdminUserEditForm(UserModel user, bool editingAllowed)
            : this(editingAllowed)
        {
            editedUser = user;

            textBox1.Text = user.Login;
            textBox2.Text = user.Password;  // what for lmao
            comboBox1.SelectedItem = user.Role;
            textBox3.Text = user.Name;
            textBox4.Text = user.Lastname;
            checkBox1.Checked = user.Active;
        }

        public AdminUserEditForm(AdminService adminService)
            : this(true)
        {
            this.adminService = adminService;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) // "Save"
        {
            if (editedUser != null)
            {
                editedUser.Password = textBox2.Text;
                editedUser.Name = textBox3.Text;
                editedUser.Lastname = textBox4.Text;
                editedUser.Active = checkBox1.Checked;
            }
            else // adminService is not null, has to be
            {
                var login = textBox1.Text;
                var password = textBox2.Text;
                var role = (ClinicRole)comboBox1.SelectedItem;
                var active = checkBox1.Checked;
                var name = textBox3.Text;
                var lastname = textBox4.Text;

                adminService.CreateUser(login, password, role, active, name, lastname);
            }
        }

        // TODO: catch exceptions here

        private void button2_Click(object sender, EventArgs e) // "Exit"
        {
            Close();
        }
    }
}
