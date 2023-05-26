using Kursova.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova.Resources
{
    public partial class HomeFormTiacher : Form
    {
        public string SubjectValue { get; set; }
        public string Subject { get; }

        public HomeFormTiacher()
        {
            InitializeComponent();
        }

        public HomeFormTiacher(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }
        private void Student_Click(object sender, EventArgs e)
        {
            var Students = new HomeForm();
            Students.Show();
            this.Hide();
        }

        private void DocumentTiacher_Click(object sender, EventArgs e)
        {
            var Doc = new DocumentTiacher();
            Doc.Show();
            this.Hide();
        }

        private void HomeFormTiacher_Load(object sender, EventArgs e)
        {
            label1.Text = SharedData.TextBox1Value;
            label2.Text = SharedData.TextBox2Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text.Length < 3)
            {
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
