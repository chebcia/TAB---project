using System;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public delegate void NeedsRefreshing();
    public partial class VisitForm : Form
    {
        private VisitModel Visit;
        private readonly DoctorService Service;
        private NeedsRefreshing needsRefreshing; // a delegate refreshing the doctor form
        private UserModel doctor;
        public VisitForm(VisitModel _visit, DoctorService _service, NeedsRefreshing _needsRefreshing, UserModel _doctor)
        {
            InitializeComponent();
            Visit = _visit;
            Service = _service;
            doctor = _doctor;
            needsRefreshing = _needsRefreshing;
            textBox1.Text = _visit.Description;
            textBox2.Text = _visit.Diagnosis;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ExamCreationForm(Visit, Service, ExamKind.Lab).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ExamCreationForm(Visit, Service, ExamKind.Physical).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new DoctorExamsForm(Visit, Service, doctor).ShowDialog();
        }

        /// <summary>
        /// Exits the selected visit without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            Close();            
        }

        /// <summary>
        /// saves the visit and exits the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            Visit.Description = textBox1.Text;
            Visit.Diagnosis = textBox2.Text;
            Service.saveVisit(Visit);
            needsRefreshing();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to Finalize the visit?", 
                "Attention!",
                MessageBoxButtons.OKCancel);

            if (result.Equals(DialogResult.OK))
            {
                Visit.Status = VisitStatus.finalized;
                Visit.DateTimeFinalizedCancelled = DateTime.Now;
                Visit.Description = textBox1.Text;
                Visit.Diagnosis = textBox2.Text;
                Service.saveVisit(Visit);
                needsRefreshing();
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel the visit?", 
                "Attention!", 
                MessageBoxButtons.OKCancel);

            if (result.Equals(DialogResult.OK))
            {
                Visit.Status = VisitStatus.cancelled;
                Visit.DateTimeFinalizedCancelled = DateTime.Now;
                Visit.Description = textBox1.Text;
                Visit.Diagnosis = textBox2.Text;
                Service.saveVisit(Visit);
                needsRefreshing();
                Close();
            }
        }
    }
}
