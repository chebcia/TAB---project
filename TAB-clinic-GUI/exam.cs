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
       // private NeedsRefreshing needsRefreshing;
        //variable fromVersion describle in exam.desinger in line 238
        public exam(UserModel user, LabExamModel _selectedExam, LabService _servic)
        {
            InitializeComponent();
            currentUser = user;
            selectedExam = _selectedExam;
            Service = _servic;
            if (currentUser != null) enabledParts(currentUser.Role.RoleToDBString());
            else enabledParts("view");
            idText.Text = selectedExam.IdExam.ToString();
            nameText.Text = selectedExam.Code;
            statusText.Text = selectedExam.Status.ToString();
            docText.Text = selectedExam.DoctorsNotes;
            resultText.Text = selectedExam.Result;
            managerText.Text = selectedExam.ManagersNotes;
            

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            selectedExam.DoctorsNotes = docText.Text;
            saveChange();
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            selectedExam.Result = resultText.Text;
            selectedExam.IdWorker = currentUser.IdUser;
            selectedExam.DtFinalizedCancelled = DateTime.Now;
            selectedExam.Status = LabExamStatus.FinalizedByWorker;
            saveChange();
            MessageBox.Show("Changes saved,\nexam donse.", "Success");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            selectedExam.Result = resultText.Text;
            selectedExam.IdWorker = currentUser.IdUser;
            selectedExam.DtFinalizedCancelled = DateTime.Now;
            selectedExam.Status = LabExamStatus.CancelledByWorker;
            saveChange();
            MessageBox.Show("Changes saved,\nexam canceled.", "Success");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            selectedExam.ManagersNotes = managerText.Text;
            selectedExam.IdManager = currentUser.IdUser;
            selectedExam.DtApprovedCancelled = DateTime.Now;
            selectedExam.Status = LabExamStatus.FinalizedByManager;
            saveChange();
            MessageBox.Show("Changes saved,\nexam finalized.", "Success");
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            selectedExam.ManagersNotes = managerText.Text;
            selectedExam.IdManager = currentUser.IdUser;
            selectedExam.DtApprovedCancelled = DateTime.Now;
            selectedExam.Status = LabExamStatus.CancelledByManager;

            saveChange();
            MessageBox.Show("Changes saved,\nexam reject.", "Success");
        }

        private void enabledParts(string formVersion)
        {


            if (formVersion == "doc")
            {
                if (selectedExam.Status == LabExamStatus.Requested)
                {
                    docText.Enabled = true;
                    buttonSave.Enabled = true;
                }
            }
            else if (formVersion == "lab_w")
            {
                cancelButton.Enabled = true;
                makeButton.Enabled = true;
                resultText.Enabled = true;
                
            }
            else if (formVersion == "lab_m")
            {
                acceptButton.Enabled = true;
                rejectButton.Enabled = true;
                managerText.Enabled = true;
                

            }
        }

        private void saveChange()
        {
            Service.saveExam();
            statusText.Text = selectedExam.Status.ToString();
        }
    }
}
