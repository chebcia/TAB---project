using System;
using System.Collections;
using System.Windows.Forms;
using TAB_clinic_Services;
using TAB_clinic_Model;
using System.Linq;

namespace TAB_clinic_GUI
{
    public partial class DoctorForm : Form
    {
        private readonly DoctorService Service = new();
        private UserModel doctor;

        public DoctorForm(UserModel _doctor)
        {
            doctor = _doctor;
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Starts the visit form with the selected visit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Refreshes the dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string surnameFilter = textBox1.Text;
            DateTime? dateTimeFilter = dateTimePicker1.Checked ? dateTimePicker1.Value : null;
            var visits = Service.GetDoctorsVisits(doctor, surnameFilter, dateTimeFilter);

            dataGridView1.DataSource = (from v in visits
                                       where v.Status.Equals(VisitStatus.registered)
                                       select new
                                       {
                                           Id = v.IdVisit,
                                           Name = v.PatientNavigation.Name,
                                           Surname = v.PatientNavigation.Lastname,
                                           Registered = v.DateTimeRegistered,
                                           description = v.Description
                                       }).ToList();

        }

        /// <summary>
        /// Name filter changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
