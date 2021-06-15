using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

#nullable enable

namespace TAB_clinic_GUI
{
    public partial class AdminMainForm : Form
    {
        // Each "Main" Form should own a service.
        private readonly AdminService adminService = new();
        private List<UserModel> users;

        public AdminMainForm()
        {
            InitializeComponent();
            
            users = adminService.UserList();
            dataGridView1.DataSource = users;
            WindowState = FormWindowState.Maximized;
        }

        private void FilterUserList()
        {
            var filter = textBox1.Text;
            var filteredUsers = users.Where(u => u.Login.Contains(filter) || u.Name.Contains(filter) || u.LastName.Contains(filter)).ToList();
            dataGridView1.DataSource = filteredUsers;
        }

        private UserModel SelectedUser()
        {
            var id = (int)dataGridView1.CurrentRow.Cells["IdUser"].Value;
            return users.Where(u => u.IdUser == id).FirstOrDefault()!;
        }

        private void button1_Click(object sender, System.EventArgs e) // "Show"
        {
            FilterUserList();
        }

        private void button2_Click(object sender, System.EventArgs e) // "Edit"
        {
            new AdminUserEditForm(adminService, SelectedUser()).ShowDialog();
            FilterUserList();
        }

        private void button3_Click(object sender, System.EventArgs e) // "New user"
        {
            new AdminUserEditForm(adminService, null).ShowDialog();
            users = adminService.UserList();
            FilterUserList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
            {
                FilterUserList();
            }
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            button1.Enabled = !checkBox1.Checked;
        }

        private void AdminMainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
