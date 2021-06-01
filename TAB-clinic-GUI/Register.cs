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
        private int selectedRegistar;

        private PatientModel SelectedPatient()
        {
            var currentRow = dataGridView1.CurrentRow;

            if (currentRow is null)
            {
                return null;
            }

            var idPatient = currentRow.Cells["IdPatient"].Value;

            if (idPatient is null)
            {
                return null;
            }

            var id = (int)idPatient;
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
            var selectedPatient = SelectedPatient();

            if (selectedPatient is null)
            {
                MessageBox.Show("You have to select patient first.", "Error");
                return;
            }

            new AddEditPatientForm(registrarService, selectedPatient).ShowDialog();
        }

        public RegisterForm(int selectedRegistar)
        {
            InitializeComponent();

            this.selectedRegistar = selectedRegistar;
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            var selectedPatient = SelectedPatient();

            if (selectedPatient is null)
            {
                MessageBox.Show("You have to select patient first.", "Error");
                return;
            }
            
            new RegisterVisitForm(registrarService, SelectedPatient(), this.selectedRegistar).ShowDialog();
        }

        private void buttonCancelVisit_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonBrowser_Click(object sender, System.EventArgs e)
        {
            new VisitsForm(registrarService).ShowDialog();
            // TODO: throws System.NullReferenceException
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {

        }
    }
}
