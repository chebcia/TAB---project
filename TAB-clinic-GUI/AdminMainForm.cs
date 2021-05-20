using System.Windows.Forms;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class AdminMainForm : Form
    {
        // Each "Main" Form should own a service.
        private readonly AdminService adminService = new();

        public AdminMainForm()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = adminService.UserList();
        }

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
    }
}
