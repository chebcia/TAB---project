using System;
using System.Windows.Forms;
using TAB_clinic_Services;

namespace TAB_clinic_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // automatically generated, probably important
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            var success = LoginService.SignIn(login, password);
            if (success is null)
            {
                MessageBox.Show("Did you mean to use 'admin' and 'admin'?", "Failed");
                return;
            }

            // open user's main form
            new AdminMainForm().ShowDialog();
        }
    }
}