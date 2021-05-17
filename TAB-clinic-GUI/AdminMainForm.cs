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

            AddSampleUsers();

            dataGridView1.DataSource = AdminService.UserList();
        }

        void AddSampleUsers()
        {
            try
            {
                UserContext.CreateUser("natalia", "cheba", TAB_clinic_Model.ClinicRole.Registrar);
                UserContext.CreateUser("dr", "augustyn", TAB_clinic_Model.ClinicRole.Doctor);
                UserContext.CreateUser("jerzy", "bodzenta", TAB_clinic_Model.ClinicRole.LabManager);
                UserContext.CreateUser("dariusz", "mrozek", TAB_clinic_Model.ClinicRole.LabWorker);
            }
            catch (UserAlreadyExistsException)
            {

            }
        }
    }
}
