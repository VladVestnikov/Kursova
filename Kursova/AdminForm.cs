using Kursova.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class AdminForm : Form
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<RegistrUser> users;
        private string path = "Save.json";
        public AdminForm()
        {
            InitializeComponent();
            users = UserRepos.ViewUser();
            string json = File.ReadAllText("teachers.json");
            string jsonStudent = File.ReadAllText("Student.json");
            teachers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Teacher>>(json);
            students = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(jsonStudent);
            UpdateTeacherListBox();
            UpdateStudentListBox();
        }

        
        private void UpdateStudentListBox() 
        {
            listBoxStudents.Items.Clear();
            foreach (Student student in students) 
            {
                string listItem = $"{student.Name}, Вік {student.Age}, Клас {student.Clas}, " +
                    $"Предмет {student.Subject}, Тип навчання {student.TypeOfTraining}";
                listBoxStudents.Items.Add(listItem);
            }
        }
        private void UpdateTeacherListBox()
        {
            listBoxTeachers.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                string listItem = $"{teacher.Subject}, Стаж {teacher.Number} років, Тип навчання {teacher.TypeOfTraining}";
                listBoxTeachers.Items.Add(listItem);
            }
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
           
            foreach (RegistrUser user in users)
            {
               
                TxtBox.Items.Add(user.Login);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            string selectedUser = TxtBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedUser))
            {
                bool removed = UserRepos.RemoveUser(selectedUser);
                if (removed)
                {
                    MessageBox.Show("Пользователь успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtBox.Items.Remove(selectedUser);


                    users = UserRepos.ViewUser();


                    UpdateUserListBox();


                    UserRepos.SaveUsers(path);
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void UpdateUserListBox()
        {
            TxtBox.Items.Clear();
            foreach (RegistrUser user in users)
            {
                TxtBox.Items.Add(user.Login);
            }
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxTeachers.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < teachers.Count)
            {
                Teacher selectedTeacher = teachers[selectedIndex];
                teachers.RemoveAt(selectedIndex);
                SaveTeachersToJsonFile(); // Сохранение данных в JSON-файл после удаления учителя
                UpdateTeacherListBox();
                MessageBox.Show("Учитель успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите учителя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        private void SaveTeachersToJsonFile()
        {
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(teachers);
            File.WriteAllText("teachers.json", jsonData);
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxStudents.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < students.Count)
            {
                Student selectedStudent = students[selectedIndex];
                students.RemoveAt(selectedIndex);
                SaveStudentToJsonFile(); // Сохранение данных в JSON-файл после удаления учителя
                UpdateStudentListBox();
                MessageBox.Show("Учитель успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите учителя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveStudentToJsonFile()
        {
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(students);
            File.WriteAllText("Student.json", jsonData);
        }
    }
}
