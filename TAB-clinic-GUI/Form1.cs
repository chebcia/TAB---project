using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TAB_clinic_GUI.Database;

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

            using (var context = new ClinicDBContext())
            {
                var matchingUser = context.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();

                if (matchingUser is null)
                {
                    MessageBox.Show("No such user exists.");
                }
                else
                {
                    MessageBox.Show($"You're a(n) {matchingUser.Role ?? "ADMINISTRATOR"}!");
                }
            }
        }
    }
}