using System;
using System.Windows.Forms;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = AdminService.UserList();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
