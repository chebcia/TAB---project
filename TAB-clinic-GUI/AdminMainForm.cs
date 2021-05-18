using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();

            SampleDataGenerator.CreateSampleUsers();

            dataGridView1.DataSource = AdminService.UserList();
        }
    }
}
