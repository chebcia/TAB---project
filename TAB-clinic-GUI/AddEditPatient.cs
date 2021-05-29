using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Debug.WriteLine(selectedPatient);
            Debug.WriteLine(this.editPatient);

            if (this.editPatient)
            {
                this.Text = "Edit user";

                inputName.Text = selectedPatient.Name;
                inputLastName.Text = selectedPatient.Lastname;
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
                    registrarService.UpdatePatient(name, lastName, pesel);
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
    }
}
