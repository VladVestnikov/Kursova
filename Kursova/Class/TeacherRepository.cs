using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

namespace Kursova.Class
{
    public class TeacherRepository
    {
        private List<Teacher> teachers;
        private string jsonFilePath = "teachers.json"; 

        public TeacherRepository(string filePath)
        {
            teachers = new List<Teacher>();
            jsonFilePath = filePath;
        }

        public void AddTeacher(string subject, string number, string typeOfTraining)
        {
            Teacher teacher = new Teacher
            {
                Subject = subject,
                Number = number,
                TypeOfTraining = typeOfTraining
            };

            teachers.Add(teacher);
            SaveToJsonFile(); // Сохранение данных в JSON-файл после добавления учителя
        }

        // Загрузка данных из JSON-файла
        public void LoadFromJsonFile()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                teachers = JsonSerializer.Deserialize<List<Teacher>>(jsonData);
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
            SaveToJsonFile(); // Сохранение данных в JSON-файл после удаления учителя
        }
        // Сохранение данных в JSON-файл
        public void SaveToJsonFile()
        {
            string jsonData = JsonSerializer.Serialize(teachers);
            File.WriteAllText(jsonFilePath, jsonData);
        }
    }
}
