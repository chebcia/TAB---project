using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class RegisterVisitForm : Form
    {
        private readonly PatientModel selectedPatient;
        private readonly RegistrarService registrarService;
        private readonly List<UserModel> doctorList;
        private readonly int selectedRegistrar;

        public RegisterVisitForm(RegistrarService registrarService, PatientModel selectedPatient, int selectedRegistrar)
        {
            InitializeComponent();

            this.registrarService = registrarService;
            this.selectedPatient = selectedPatient;
            this.selectedRegistrar = selectedRegistrar;

            this.doctorList = registrarService.DoctorList();
            inputDoctor.DataSource = registrarService.DoctorListComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDoctor = inputDoctor.SelectedIndex;

                if (selectedDoctor < 0)
                {
                    MessageBox.Show("You need to select doctor first.", "Error");
                    return;
                }

                var doctorId = this.doctorList[selectedDoctor].IdUser;
                var patientId = this.selectedPatient.IdPatient;
                var registarId = this.selectedRegistrar;
                var dateTime = inputDate.Value;

                this.registrarService.CreateNewVisit(doctorId, patientId, registarId, VisitStatus.registered, null, dateTime, null, null);
                MessageBox.Show("Appointment saved", "Success");
            }
            catch (InvalidUserDataException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (inputDoctor.SelectedIndex < 0)
            {
                MessageBox.Show("No doctor detected. Please contact with your administrator to create doctor.", "Error");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void inputDate_ValueChanged(object sender, EventArgs e)
        {
            var hasPassed = (DateTime.Now - inputDate.Value).TotalMinutes >= 0;

            if (hasPassed)
            {
                MessageBox.Show("You can't change the past!");
                buttonSave.Enabled = false;
            } else
            {
                buttonSave.Enabled = true;
            }
            
        }
    }
}
