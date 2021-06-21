using System;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class AddEditPatientForm : Form
    {
        private readonly PatientModel? selectedPatient;

        private readonly RegistrarService registrarService;

        private bool editPatient;

        public AddEditPatientForm(RegistrarService registrarService, PatientModel? selectedPatient)
        {
            InitializeComponent();
            this.registrarService = registrarService;
            this.selectedPatient = selectedPatient;
            this.editPatient = selectedPatient is not null;

            this.Text = "Add user";

            if (this.editPatient)
            {
                this.Text = "Edit user";

                inputName.Text = selectedPatient.Name;
                inputLastName.Text = selectedPatient.LastName;
                inputPesel.Text = selectedPatient.Pesel;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          try
            {
                var name = inputName.Text;
                var lastName = inputLastName.Text;
                var pesel = inputPesel.Text;

                if (editPatient)
                {
                    var patientId = selectedPatient.IdPatient;
                    registrarService.UpdatePatient(patientId, name, lastName, pesel);
                    MessageBox.Show("Patient updated", "Success");
                    return;
                }
                registrarService.CreatePatient(name, lastName, pesel);
                MessageBox.Show("Patient created", "Success");
            }  
            catch (InvalidUserDataException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
