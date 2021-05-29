using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class RegisterForm : Form
    {

        private readonly RegistrarService registrarService = new();
        private List<PatientModel> patients;

        private PatientModel SelectedPatient()
        {
            var id = (int)dataGridView1.CurrentRow.Cells["IdPatient"].Value;
            return patients.Where(patient => patient.IdPatient == id).FirstOrDefault();
        }

        private void buttonAddEditPatient_Click(object sender, System.EventArgs e)
        {
            new AddEditPatientForm(registrarService, null).ShowDialog();
        }

        private void RegisterForm_Load(object sender, System.EventArgs e)
        {

        }

        private void buttonEditPatient_Click(object sender, System.EventArgs e)
        {
            new AddEditPatientForm(registrarService, SelectedPatient()).ShowDialog();
        }

        public RegisterForm()
        {
            InitializeComponent();

            this.LoadPatients();
        }

        public void LoadPatients()
        {
            patients = registrarService.PatientList();
            dataGridView1.DataSource = patients;
        }

        private void buttonRefresh_Click(object sender, System.EventArgs e)
        {
            this.LoadPatients();
        }
    }
}
