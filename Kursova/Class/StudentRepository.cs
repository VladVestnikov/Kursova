using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

namespace Kursova.Class
{
    public class StudentRepository
    {
        private List<Student> students;
        private string jsonFilePath = "Student.json";

        public StudentRepository(string filePath)
        {
            students = new List<Student>();
            jsonFilePath = filePath;
        }
        public void AddStudent(string name, string age, string subject, string clas, string typeOfTraining)
        {
            Student student = new Student
            {
                Name = name,
                Age = age,
                Subject = subject,
                Clas = clas,
                TypeOfTraining = typeOfTraining
            };

            students.Add(student);
            SaveToJsonFile();
        }

        public void LoadFromJsonFile()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                students = JsonSerializer.Deserialize<List<Student>>(jsonData);
            }
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            SaveToJsonFile(); 
        }
        // Сохранение данных в JSON-файл
        public void SaveToJsonFile()
        {
            string jsonData = JsonSerializer.Serialize(students);
            File.WriteAllText(jsonFilePath, jsonData);
        }
    }
}
