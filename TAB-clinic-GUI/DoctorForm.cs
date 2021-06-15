using System;
using System.Windows.Forms;
using TAB_clinic_Services;
using TAB_clinic_Model;
using System.Linq;

namespace TAB_clinic_GUI
{
    public partial class DoctorForm : Form
    {
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
            try
            {
                DoctorService Service = new();

                VisitModel selectedVisit;
                int id;
                var selectedRow = dataGridView1.SelectedRows[0];
                

                if (selectedRow != null)
                {
                    string cellValue = selectedRow.Cells["Id"].Value.ToString();
                    id = int.Parse(cellValue);
                    selectedVisit = Service.GetVisit(id);


                    new VisitForm(selectedVisit, Service, () => refresh(), doctor).Show();
                }

            }
            catch(ArgumentOutOfRangeException)
            {
            }
        }


        /// <summary>
        /// Refreshes the dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        /// <summary>
        /// Name filter changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void refresh()
        {
            DoctorService Service = new();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button1.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
    }
}
