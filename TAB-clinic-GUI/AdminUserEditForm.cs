using System;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

#nullable enable

namespace TAB_clinic_GUI
{
    public partial class AdminUserEditForm : Form
    {
        private readonly AdminService adminService;
        private readonly UserModel? editedUser;
       
        public AdminUserEditForm(AdminService adminService, UserModel? user)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(ClinicRole));

            this.adminService = adminService;
            this.editedUser = user;

            if (editedUser is null)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                this.Text = "Create new user";
                textBox2.Text = "";
            }
            else
            {
                this.Text = "Edit user";
                textBox1.Text = editedUser.Login;
                comboBox1.SelectedItem = editedUser.Role;
                textBox3.Text = editedUser.Name;
                textBox4.Text = editedUser.LastName;
                checkBox1.Checked = editedUser.Active;
            }
        }

        private void button1_Click(object sender, EventArgs e) // "Save"
        {
            try
            {
                if (editedUser != null)     // editing a user
                {
                    editedUser.Password = textBox2.Text;
                    editedUser.Name = textBox3.Text;
                    editedUser.LastName = textBox4.Text;
                    editedUser.Active = checkBox1.Checked;
                    adminService.SaveChanges();
                    MessageBox.Show("Changes saved.", "Success");
                }
                else                        // creating a new user
                {
                    var login = textBox1.Text;
                    var password = textBox2.Text;
                    var role = (ClinicRole)comboBox1.SelectedItem;
                    var active = checkBox1.Checked;
                    var name = textBox3.Text;
                    var lastname = textBox4.Text;

                    adminService.CreateUser(login, password, role, active, name, lastname);
                    MessageBox.Show("User created.", "Success");
                }
            }
            catch (InvalidUserDataException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e) // "Exit"
        {
            Close();
        }
    }
}
