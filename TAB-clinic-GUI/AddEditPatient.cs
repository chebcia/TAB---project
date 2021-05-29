using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private readonly RegistrarService registrarService;

        public AddEditPatientForm(RegistrarService registrarService)
        {
            InitializeComponent();
            this.registrarService = registrarService;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          try
            {
                var name = inputName.Text;
                var lastName = inputLastName.Text;
                var pesel = inputPesel.Text;

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
