using System;
using System.Windows.Forms;

using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class ExamCreationForm : Form
    {
        private VisitModel Visit;
        private readonly DoctorService Service;
        private readonly ExamKind Kind;

        public ExamCreationForm(VisitModel _visit, DoctorService _service, ExamKind _kind)
        {
            InitializeComponent();
            Visit = _visit;
            Service = _service;
            Kind = _kind;

            switch (Kind)
            {
                case ExamKind.Physical:
                    {
                        label2.Text = "result";
                        button2.Text = "accept";
                        break;
                    }
                case ExamKind.Lab:
                    {
                        label2.Text = "notes";
                        button2.Text = "order";
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Kind)
            {
                case ExamKind.Physical:
                    {
                        Service.AddPhysicalExam(Visit, label1.Text, comboBox1.Text);
                        break;
                    }
                case ExamKind.Lab:
                    {
                        Service.AddLabExam(Visit, label1.Text, comboBox1.Text);
                        break;
                    }
            }
        }
    }
}
