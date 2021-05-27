using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

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
        }

        private UserModel SelectedUser()
        {
            var id = (int)dataGridView1.CurrentRow.Cells["IdUser"].Value;
            return users.Where(u => u.IdUser == id).FirstOrDefault();
        }

        private void button1_Click(object sender, System.EventArgs e) // "Show"
        {
            // TODO: filter the list
        }

        private void button2_Click(object sender, System.EventArgs e) // "Edit"
        {
            new AdminUserEditForm(adminService, SelectedUser()).ShowDialog();
            adminService.SaveChanges();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, System.EventArgs e) // "New user"
        {
            new AdminUserEditForm(adminService, null).ShowDialog();
            dataGridView1.DataSource = users = adminService.UserList();
        }

        #region test buttons
        private void button4_Click(object sender, System.EventArgs e) // "CLEAR"
        {
            adminService.DeleteOtherUsers();
            dataGridView1.DataSource = adminService.UserList();
        }

        private void button5_Click(object sender, System.EventArgs e) // "FILL"
        {
            adminService.SpawnUsers();
            dataGridView1.DataSource = adminService.UserList();
        }
        #endregion
    }
}
