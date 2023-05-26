using Kursova.Class;
using Kursova.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;

namespace Kursova
{
    public partial class HomeForm : Form
    {
        public string SubjectValue { get; set; }
        private string subject;

        public HomeForm()
        {
            InitializeComponent();
           comboBox.DataSource = Enum.GetValues(typeof(SchoolSubject));
        }

        public HomeForm(string name, string subject)
        {
            Name = name;
            this.subject = subject;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchoolSubject selectedSubject = (SchoolSubject)comboBox.SelectedItem;
            string subjectName = Subject.NameSubject(selectedSubject);
            string selectedSubjectValue = comboBox.SelectedItem.ToString();

            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;

            foreach (Label label in Controls.OfType<Label>())
            {
                if (selectedSubject == SchoolSubject.All)
                {
                    if(label1.Text.Length < 3)
                    {
                        label1.Visible = false;
                    }
                    label.Visible = true;
                }
                else if (!label.Text.Contains(Subject.NameSubject((SchoolSubject)Enum.Parse(typeof(SchoolSubject), selectedSubjectValue))))
                {
                    label.Visible = false;
                }
                else
                {
                    label.Visible = true;
                }
            }

            SetButtonVisibility();
        }
        private void SetButtonVisibility()
        {
            button3.Visible = label4.Visible;
            button4.Visible = label6.Visible;
            button5.Visible = label8.Visible;
            button6.Visible = label10.Visible;
            button7.Visible = label12.Visible;
            label2.Visible = label1.Visible;
            label3.Visible = label1.Visible;
            label5.Visible = label4.Visible;
            label7.Visible = label6.Visible;
            label9.Visible = label8.Visible;
            label11.Visible = label10.Visible;
            label13.Visible = label12.Visible;
        }

        private void Tiacher_Click(object sender, EventArgs e)
        {
            var Tiachers = new HomeFormTiacher();
            Tiachers.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            label1.Text = SharedData.TextBox1Value;
            label2.Text = SharedData.TextBox2Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var documentStudent = new Document();
            documentStudent.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text.Length <3)
            {
                label3.Visible= false;
            }
            else 
            { 
                label3.Visible= true;
            }
            if (label1.Text.Length < 3)
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {       
            var documentStudent = new Document();
            documentStudent.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var documentStudent = new Document();
            documentStudent.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var documentStudent = new Document();
            documentStudent.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var documentStudent = new Document();
            documentStudent.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var documentStudent = new Document();
            documentStudent.Show();
            this.Hide();
        }

    }
}
