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
            exams = labService.LabExamList();
           
            comboBox1.DataSource = labService.ComboBoxStatus();
            filtered();
            WindowState = FormWindowState.Maximized;
        }

        private LabExamModel SelectedExam()
        {
            var currentRow = dataGridView1.CurrentRow;

            if (currentRow is null)
            {
                return null;
            }
            var idExam = currentRow.Cells["Id"].Value;

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

            
            new exam(labUser,selectedExam, labService).ShowDialog();
            filtered();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            var selectedExam = SelectedExam();

            if (selectedExam is null)
            {
                MessageBox.Show("You have to select exam first.", "Error");
                return;
            }


            new exam(null, selectedExam, labService).ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtered();
        }

        private void filtered()
        {
            int status = comboBox1.SelectedIndex ;
            if (status > 0)
            {

                if (dateTimePicker1.Checked)
                {
                    dataGridView1.DataSource = (from e in exams
                                  where dateTimePicker1.Value.Date.Equals(e.DtRequest.Date) &&
                                  ((LabExamStatus)status).Equals(e.Status)
                                  select new
                                  {
                                      Id = e.IdExam,
                                      Code = e.Code,
                                      Status = e.Status.StatusToDisplayString(),
                                      Date_Request = e.DtRequest,
                                      Visit = e.IdVisit
                                  }).ToList();

                    
                }
                else
                {
                    dataGridView1.DataSource = (from e in exams
                                  where ((LabExamStatus)status).Equals(e.Status)
                                  select new
                                  {
                                      Id = e.IdExam,
                                      Code = e.Code,
                                      Status = e.Status.StatusToDisplayString(),
                                      Date_Request = e.DtRequest,
                                      Visit = e.IdVisit
                                  }).ToList(); ;

                }

            }
            else
            {
                if (dateTimePicker1.Checked)
                {
                    dataGridView1.DataSource = (from e in exams
                                  where dateTimePicker1.Value.Date.Equals(e.DtRequest.Date)
                                  select new
                                  {
                                      Id = e.IdExam,
                                      Code = e.Code,
                                      Status = e.Status.StatusToDisplayString(),
                                      Date_Request = e.DtRequest,
                                      Visit = e.IdVisit
                                  }).ToList(); ;
                }
                else
                {
                    dataGridView1.DataSource = (from e in exams
                                  select new
                                  {
                                      Id = e.IdExam,
                                      Code = e.Code,
                                      Status = e.Status.StatusToDisplayString(),
                                      Date_Request = e.DtRequest,
                                      Visit = e.IdVisit
                                  }).ToList(); ;
                }
            }
        }
    }
                   
}
