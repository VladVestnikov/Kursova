using Kursova.Class;
using Kursova.Resources;
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

namespace Kursova
{
    public partial class DocumentTiacher : Form
    {
        string filePath = "teachers.json";
        private TeacherRepository teacherRepository;
        public DocumentTiacher()
        {
            InitializeComponent();
            teacherRepository = new TeacherRepository(filePath);
            foreach (SchoolSubject subject in Enum.GetValues(typeof(SchoolSubject)))
            {
                string subjectName = Subject.NameSubject(subject);
                comboBox1.Items.Add(subjectName);
            }
        }

        private void AddDocument_Click(object sender, EventArgs e)
        {
            
            string subject = textBox1.Text;
            string number = textBox2.Text;
            string typeOfTraining = textBox3.Text;
            textBox2.TextChanged += textBox2_TextChanged;
            if (string.IsNullOrEmpty(subject)|| string.IsNullOrEmpty(number) || string.IsNullOrEmpty(typeOfTraining)) 
            {
               MessageBox.Show("Будь ласка, заповніть всі поля");           
            }
            else
            {

             MessageBox.Show("Ваш документ був доданий до списку!!");
                teacherRepository.LoadFromJsonFile();
                teacherRepository.AddTeacher(subject, number, typeOfTraining);
                var homeFormTeacher = new HomeFormTiacher();

                SharedData.TextBox1Value = textBox1.Text;
                SharedData.TextBox2Value = textBox3.Text;


                this.Hide();  

                homeFormTeacher.Show();  

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out _))
            {
                textBox2.Text = string.Empty;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubjects = comboBox1.Text; // Получаем выбранные предметы из ComboBox1
            string[] selectedSubjectsArray = selectedSubjects.Split(','); // Разделяем выбранные предметы по запятой

            // Очищаем TextBox перед заполнением новыми значениями
            textBox1.Clear();

            // Перебираем выбранные предметы и добавляем их в TextBox
            foreach (string subjectName in selectedSubjectsArray)
            {
                textBox1.AppendText(subjectName.Trim() + Environment.NewLine);
            }
        }

    }
}
