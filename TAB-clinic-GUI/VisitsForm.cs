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
    public partial class VisitsForm : Form
    {
        private readonly RegistrarService registrarService;
        private List<VisitModel> visitsList;
        private readonly List<PatientModel> patientList;

        public VisitsForm(RegistrarService registrarService)
        {
            InitializeComponent();
            this.registrarService = registrarService;
            this.patientList = registrarService.PatientList();
            this.LoadVisit();
        }

        private void LoadVisit()
        {
            this.visitsList = this.registrarService.VisitList();
            dataVisits.DataSource = this.visitsList;
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

            var results = this.visitsList;

            // Date Filter
            if (true)
            {
                var filtered = new List<VisitModel>();
                foreach (var entry in results)
                {
                    var dateFromValid = dateFrom.Date <= entry.DateTimeRegistered;
                    var dateToValid = dateTo.Date >= entry.DateTimeRegistered;

                    if (dateFromValid && dateToValid)
                    {
                        filtered.Add(entry);
                    }

                    results = filtered;
                }
            }

            // Pesel Filter
            if (pesel.Length > 0)
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
            if (lastName.Length > 0)
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
            dataVisits.DataSource = results;
        }

        private VisitModel SelectedVisit()
        {
            var id = (int)dataVisits.CurrentRow.Cells["IdVisit"].Value;
            return visitsList.Where(visit => visit.IdVisit == id).FirstOrDefault();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.registrarService.CancelVisit(SelectedVisit().IdVisit);
            this.LoadVisit();
        }
    }
}
