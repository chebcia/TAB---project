using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAB_clinic_GUI
{
    public partial class AddEditPatient : Form
    {
        public AddEditPatient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = inputName.Text;
            var lastName = inputLastname.Text;
            var pesel = inputPesel.Text;

// TODO 
        }
    }
}
