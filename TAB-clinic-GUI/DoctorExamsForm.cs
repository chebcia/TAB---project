using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using TAB_clinic_Model;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class DoctorExamsForm : Form
    {
        private VisitModel Visit;
        private readonly DoctorService Service;
        private UserModel doctor;

        private string GetExamTypeName(string code)
        {
            return Service.FindExamType(code)?.Name ?? "unknown";
        }

        private void RefreshVisitList()
        {
            var physicalExams = Service.GetPhysicalExamsForVisit(Visit);
            var labExams = Service.GetLabExamsForVisit(Visit);

            var examTypeFilter = comboBox1.SelectedItem as ExamTypeModel;
            Predicate<string> examCodeMatches = code => (examTypeFilter is null) || (code == examTypeFilter.Code);

            dataGridView1.DataSource = (from pe in physicalExams
                                        where examCodeMatches(pe.Code)
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
                                        where examCodeMatches(le.Code)
                                        select new
                                        {
                                            Id = le.IdExam,
                                            Note = le.DoctorsNotes,
                                            Result = le.Result,
                                            Kind = ExamKind.Lab,
                                            Type = GetExamTypeName(le.Code),
                                            Status = le.Status.StatusToDisplayString(),
                                            RequestDate = le.DtRequest.ToString()
                                        }).ToList();
        }

        public DoctorExamsForm(VisitModel _visit, DoctorService _service, UserModel _doctor)
        {
            InitializeComponent();

            Visit = _visit;
            Service = _service;
            doctor = _doctor;
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            try
            {
                var selection = dataGridView1.SelectedRows[0];

                if (selection != null)
                {
                    int IdExam = (int)selection.Cells["Id"].Value;

                    switch ((ExamKind)selection.Cells["Kind"].Value)
                    {
                        case ExamKind.Physical:
                            {
                                var physicalExam = Service.FindPhysicalExam(IdExam);
                                new PhysicalExamViewForm(physicalExam, Service).ShowDialog();
                                break;
                            }
                        case ExamKind.Lab:
                            {
                                var labExam = Service.FindLabExam(IdExam);
                                new exam(doctor, labExam, new LabService()).ShowDialog();
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

        private void button3_Clicked(object sender, EventArgs e)
        {
            RefreshVisitList();
        }

        private void DoctorExamsForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Service.GetPhysicalExamTypes());
            comboBox1.Items.AddRange(Service.GetLabExamTypes());
            RefreshVisitList();
        }
    }
}
