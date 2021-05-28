using System;
using System.Windows.Forms;

using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class PhysicalExamViewForm : Form
    {
        private readonly PhysicalExamModel PhysicalExam;
        private readonly DoctorService Service;

        public PhysicalExamViewForm(PhysicalExamModel _physicalExam, DoctorService _service)
        {
            InitializeComponent();
            PhysicalExam = _physicalExam;
            Service = _service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PhysicalExamViewForm_Load(object sender, EventArgs e)
        {
            var type = Service.FindExamType(PhysicalExam.Code);
            comboBox1.Items.Add(type);
            comboBox1.SelectedItem = type;
            textBox1.Text = PhysicalExam.Result;
        }
    }
}
