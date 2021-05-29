using System.Windows.Forms;

namespace TAB_clinic_GUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonAddEditPatient_Click(object sender, System.EventArgs e)
        {
            new AddEditPatientForm().ShowDialog();
        }
    }
}
