using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TAB_clinic_Model;
using TAB_clinic_Services;



namespace TAB_clinic_GUI
{
    public partial class VisitsForm : Form
    {
        private readonly RegistrarService registrarService;
        private List<VisitModel> visitsList;
        private readonly List<UserModel> doctorList;
        private readonly List<PatientModel> patientList;
        private readonly List<UserModel> registrarList;

        public VisitsForm(RegistrarService registrarService)
        {
            InitializeComponent();
            this.registrarService = registrarService;
            this.doctorList = registrarService.DoctorList();
            this.patientList = registrarService.PatientList();
            this.registrarList = registrarService.RegistrarList();
            this.LoadVisit(null);
        }

        private void LoadVisit(List<VisitModel>? customSource)
        {
            if (customSource is null)
            {
                this.visitsList = this.registrarService.VisitList();
            } 
            else
            {
                this.visitsList = customSource;
            }
            this.RenderDataGrid();
        }

        private void RenderDataGrid()
        {
            var dataToRender = new List<VisitsRenderModel>();

            foreach(var visit in this.visitsList) {
                var selectedDoctor = this.doctorList.Find(d => d.IdUser == visit.IdDoctor);
                var selectedPatient = this.patientList.Find(p => p.IdPatient == visit.IdPatient);
                var selectedRegistrar = this.registrarList.Find(r => r.IdUser == visit.IdRegistrar);

                var doctorName = selectedDoctor.Name + " " + selectedDoctor.LastName;
                var registrarName = selectedRegistrar.Name + " " + selectedRegistrar.LastName;
                var patientName = selectedPatient.Name + " " + selectedPatient.Lastname;
                var patientPesel = selectedPatient.Pesel;

                dataToRender.Add(new VisitsRenderModel()
                {
                    IdVisit = visit.IdVisit,
                    DateTimeRegistered = visit.DateTimeRegistered,
                    DateTimeFinalizedCancelled = visit.DateTimeFinalizedCancelled,
                    DoctorName = doctorName,
                    RegistrarName = registrarName,
                    PatientName = patientName,
                    PatientPesel = patientPesel,
                    Status = visit.Status,
                }); ;
            }

            dataVisits.DataSource = dataToRender.OrderBy(d => d.DateTimeRegistered).ToList();
        }

        private void CancelVisitsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var dateFrom = inputDateFrom.Value;
            var dateTo = inputDateTo.Value;
            var pesel = inputPesel.Text;
            var lastName = inputLastName.Text;

            var results = this.registrarService.VisitList();

            // Date Filter
            if (true)
            {
                var filtered = new List<VisitModel>();
                foreach (var entry in results)
                {
                    var dateFromValid = dateFrom.Date <= entry.DateTimeRegistered;
                    var dateToValid = dateTo.AddDays(1).Date >= entry.DateTimeRegistered;

                    Debug.WriteLine(dateFromValid);
                    Debug.WriteLine(dateToValid);

                    if (dateFromValid && dateToValid)
                    {
                        filtered.Add(entry);
                    }

                    results = filtered;
                }
            }

            // Pesel Filter
            if (pesel is not null)
            {
                var filtered = new List<VisitModel>();
                foreach(var entry in results)
                {
                    var patientDetails = this.patientList.Find(p => p.IdPatient == entry.IdPatient);
                    if (patientDetails.Pesel.StartsWith(pesel))
                    {
                        filtered.Add(entry);
                    }
                }

                results = filtered;
            }

            // Last Name Filter
            if (lastName is not null)
            {
                var filtered = new List<VisitModel>();
                foreach (var entry in results)
                {
                    var patientDetails = this.patientList.Find(p => p.IdPatient == entry.IdPatient);
                    if (patientDetails.Lastname.ToLower().StartsWith(lastName.ToLower())) // Case insetive filtering
                    {
                        filtered.Add(entry);
                    }
                }

                results = filtered;
            }

            // Display results
            this.LoadVisit(results);
        }

        private VisitModel SelectedVisit()
        {
            var id = (int)dataVisits.CurrentRow.Cells["IdVisit"].Value;
            return visitsList.Where(visit => visit.IdVisit == id).FirstOrDefault();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SelectedVisit().Status == VisitStatus.registered)
            {
                this.registrarService.CancelVisit(SelectedVisit().IdVisit);
                MessageBox.Show("Visit canceled", "Success");
            } 
            else
            {
                MessageBox.Show("This visit cannot be  canceled", "Error");
            }

            this.LoadVisit(null);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            inputDateFrom.Value = new DateTime(2020, 1, 1);
            inputDateTo.Value = new DateTime(2029, 12, 31);
            inputPesel.Text = "";
            inputLastName.Text = "";

            this.LoadVisit(null);
        }
    }
}
