using System.Windows.Forms;

namespace TAB_clinic_GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            new AddEditPatient().ShowDialog();
        }
    }
}
