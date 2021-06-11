using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class LabMainForm : Form
    {
        private readonly LabService labService = new();
        private UserModel labUser;
        private List<LabExamModel> exams;
        


        public LabMainForm(UserModel _labUser)
        {

            
            
            labUser = _labUser;
            InitializeComponent();
            exams = labService.LabExamList(dateTimePicker1.Value, comboBox1.SelectedIndex);
            dataGridView1.DataSource = exams;
            comboBox1.DataSource = labService.GetExamStatus(); 

        }

        private LabExamModel SelectedExam()
        {
            var currentRow = dataGridView1.CurrentRow;

            if (currentRow is null)
            {
                return null;
            }
            var idExam = currentRow.Cells["IdExam"].Value;

            if (idExam is null)
            {
                return null;
            }

            var id = (int)idExam;
            return exams.Where(u => u.IdExam == id).FirstOrDefault()!;
        }



        private void buttonHandel_Click(object sender, EventArgs e)
        {
            var selectedExam = SelectedExam();

            if (selectedExam is null)
            {
                MessageBox.Show("You have to select exam first.", "Error");
                return;
            }

            
            new exam(labUser.Role.ToString(),selectedExam).ShowDialog();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            var selectedExam = SelectedExam();

            if (selectedExam is null)
            {
                MessageBox.Show("You have to select exam first.", "Error");
                return;
            }


            new exam("view", selectedExam).ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
