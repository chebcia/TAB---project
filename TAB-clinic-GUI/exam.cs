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
    public partial class exam : Form
    {
        //variable fromVersion describle in exam.desinger in line 238
        public exam(string formVersion)
        {
            InitializeComponent();
            enabledParts(formVersion);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
