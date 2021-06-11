using System;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class exam : Form
    {
        private readonly LabExamModel? selectedExam;

        //variable fromVersion describle in exam.desinger in line 238
        public exam(string formVersion, LabExamModel? selectedExam)
        {
            InitializeComponent();
            enabledParts(formVersion);
            idText.Text = selectedExam.IdExam.ToString();
            nameText.Text = selectedExam.Code;
            statusText.Text = selectedExam.Status.ToString();
            docText.Text = selectedExam.DoctorsNotes;
            resultText.Text = selectedExam.Result;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
