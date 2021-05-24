using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class ExamListForm : Form
    {
        private VisitModel Visit;
        private readonly DoctorService Service;

        private string GetExamTypeName(string code)
        {
            return Service.FindExamType(code)?.Name ?? "unknown";
        }

        private void RefreshVisitList()
        {
            var physicalExams = Service.GetPhysicalExamsForVisit(Visit);
            var labExams = Service.GetLabExamsForVisit(Visit);
            dataGridView1.DataSource = (from pe in physicalExams
                                        select new
                                        {
                                            Id = pe.IdExam,
                                            Note = "N/A",
                                            Result = pe.Result,
                                            Kind = ExamKind.Physical,
                                            Type = GetExamTypeName(pe.Code),
                                            Status = "N/A",
                                            RequestDate = "N/A"
                                        }).Union(
                                        from le in labExams
                                        select new
                                        {
                                            Id = le.IdExam,
                                            Note = le.DoctorsNotes,
                                            Result = le.Result,
                                            Kind = ExamKind.Lab,
                                            Type = GetExamTypeName(le.Code),
                                            Status = le.Status.StatusToDisplayStr(),
                                            RequestDate = le.DtRequest.ToString()
                                        }).ToList();
        }

        public ExamListForm(VisitModel _visit, DoctorService _service)
        {
            InitializeComponent();
            Visit = _visit;
            Service = _service;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            try
            {
                var selection = dataGridView1.SelectedRows[0];

                if (selection != null)
                {
                    int IdExam = (int) selection.Cells["Id"].Value;

                    switch ((ExamKind) selection.Cells["Kind"].Value)
                    {
                        case ExamKind.Physical:
                            {
                                var physicalExam = Service.FindPhysicalExam(IdExam);
                                // new PhysicalExamViewForm(physicalExam).ShowDialog();
                                break;
                            }
                        case ExamKind.Lab:
                            {
                                var labExam = Service.FindLabExam(IdExam);
                                // new exam(labExam).ShowDialog();
                                break;
                            }
                    }
                }

            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        private void ExamViewForm_Load(object sender, EventArgs e)
        {
            RefreshVisitList();
        }
    }
}
