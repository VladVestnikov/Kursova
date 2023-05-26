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
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;
using Kursova.Resources;



namespace Kursova
{
    public partial class Document : Form
    {
        string filePath = "Student.json";
        private StudentRepository studentRepository;
        public Document()
        {
            InitializeComponent();
            studentRepository = new StudentRepository(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string Name = textBox1.Text;
            string Age = textBox4.Text;
            string Subject = textBox2.Text;
            string  Clas = textBox3.Text;
            string TypeOfTraining = textBox5.Text;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Age) || string.IsNullOrEmpty(Subject) ||
            string.IsNullOrEmpty(Clas) || string.IsNullOrEmpty(TypeOfTraining))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля");
            }
            else
            {
                MessageBox.Show("Ви успішно подали заявку на навчання");
                studentRepository.LoadFromJsonFile();
                studentRepository.AddStudent(Name, Age, Subject, Clas, TypeOfTraining);
                
                var homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out _))
            {
                textBox3.Text = string.Empty;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out _))
            {
                textBox4.Text = string.Empty;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                string text = textBox1.Text;
                if (text.Split(' ').Length < 2)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
