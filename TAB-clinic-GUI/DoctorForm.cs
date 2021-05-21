using System;
using System.Windows.Forms;
using TAB_clinic_Services;
using TAB_clinic_Model;


namespace TAB_clinic_GUI
{
    public partial class DoctorForm : Form
    {

        //private readonly DoctorService Service = new();
        private UserModel doctor;

        public DoctorForm(UserModel _doctor)
        {
            doctor = _doctor;
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
