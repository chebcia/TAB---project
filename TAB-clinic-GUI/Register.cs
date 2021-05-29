using System.Windows.Forms;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class RegisterForm : Form
    {

        private readonly RegistrarService registrarService = new();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonAddEditPatient_Click(object sender, System.EventArgs e)
        {
            new AddEditPatientForm(registrarService).ShowDialog();
        }
    }
}
