using System;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    
    public partial class exam : Form
    {
        private LabExamModel selectedExam;
        private readonly LabService Service;
        private readonly UserModel currentUser;
        private NeedsRefreshing needsRefreshing;
        //variable fromVersion describle in exam.desinger in line 238
        public exam(UserModel user, LabExamModel? selectedExam)
        {
            InitializeComponent();
            if (user != null) enabledParts(user.Role.ToString());
            else enabledParts("view");
            idText.Text = selectedExam.IdExam.ToString();
            nameText.Text = selectedExam.Code;
            statusText.Text = selectedExam.Status.ToString();
            docText.Text = selectedExam.DoctorsNotes;
            resultText.Text = selectedExam.Result;
            managerText.Text = selectedExam.ManagersNotes;
            currentUser = user;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            selectedExam.DoctorsNotes = docText.Text;
            Service.saveExam(selectedExam);
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            selectedExam.Result = resultText.Text;
            selectedExam.IdWorker = currentUser.IdUser;
            selectedExam.Status = LabExamStatus.FinalizedByWorker;
            Service.saveExam(selectedExam);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            selectedExam.Result = resultText.Text;
            selectedExam.IdWorker = currentUser.IdUser;
            selectedExam.Status = LabExamStatus.CancelledByWorker;
            Service.saveExam(selectedExam);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            selectedExam.Result = resultText.Text;
            selectedExam.IdWorker = currentUser.IdUser;
            selectedExam.Status = LabExamStatus.FinalizedByManager;
            Service.saveExam(selectedExam);
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            selectedExam.Result = resultText.Text;
            selectedExam.IdWorker = currentUser.IdUser;
            selectedExam.Status = LabExamStatus.CancelledByManager;
            Service.saveExam(selectedExam);
        }
    }
}
