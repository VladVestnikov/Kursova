using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kursova.Class
{
    public class UserRepos
    {
       public static List<RegistrUser> Users = new List<RegistrUser>();

        public static List<RegistrUser> ViewUser()
        {
            return new List<RegistrUser> (Users);
        }
        public void RegisterTicher(string Login, string Password)
        {
            RegistrUser user = new RegistrUser(Login, Password);
            Users.Add(user);
        }
        public void RegisterStudent(string Login, string Password)
        {
            RegistrUser user = new RegistrUser(Login, Password);
            Users.Add(user);
        }
        public static void ReadUserRecords(string path)
        {
            if (File.ReadLines(path).ToList() == null)
                Users = null;

                List<string> lines = new List<string>();
                Users.Clear();
                lines = File.ReadLines("Save.json").ToList();
                foreach (string line in lines)
                {
                    RegistrUser? user;
                    user = JsonSerializer.Deserialize<RegistrUser>(line);
                    Users.Add(user);
                }
        }
      
        public static bool RemoveUser(string login)
        {
            // Проверяем, существует ли пользователь с указанным логином
           bool res = Users.Exists(u => u.Login == login);

            if (res)
            {
                List<RegistrUser> registrUsers = new List<RegistrUser>();
                foreach (RegistrUser user in Users)
                {
                    if(user.Login == login)
                    {
                        Users.Remove(user);
                        break;
                    }                 

                }
                SaveUsers("Save.json");
                return true;
            }

            return false;
        }
        public void RegisterUser(string login, string password)
        {
            // Проверяем, существует ли уже аккаунт с таким логином
            bool isExistingAccount = UserRepos.Users.Any(user => user.Login == login);

            if (isExistingAccount)
            {
                // Генерируем исключение с сообщением об ошибке
                throw new Exception("Аккаунт с указанным логином уже существует. Пожалуйста, выберите другой логин.");
            }

            // Создаем новый аккаунт и добавляем его в список пользователей
            RegistrUser user = new RegistrUser(login, password);
            UserRepos.Users.Add(user);
        }
        public static void SaveUsers(string path) 
        {
            string lines = "";
            foreach (var user in Users)
            {
                lines += JsonSerializer.Serialize<RegistrUser>(user);
                lines += "\n";
            }
                File.WriteAllText(path, lines);
        }
    }
}