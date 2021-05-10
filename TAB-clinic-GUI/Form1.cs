using System;
using System.Diagnostics;
using System.Windows.Forms;
using TAB_clinic_Business;

namespace TAB_clinic_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Trace.WriteLine("Hello Form!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            var success = LoginService.SignIn(login, password);
            if (success)
            {
                MessageBox.Show("Hello there!", "Success");
            }
            else
            {
                MessageBox.Show($"Did you mean to use 'admin' and '{LoginService.AdminsPassword()}'?", "Failed");
            }
        }
    }
}