using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kursova.Class
{
    public class RegistrUser
    {
        private string login;
        private string password;
        public string Login { get=> login; set=> login = value; }
        public string Password { get => password; set => password = value; }    
        public RegistrUser() { }

        [JsonConstructor]
      
        public RegistrUser(string login, string password)
        {
           Login = login;
           Password = password;
        }
        public bool registerUser(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            else if(login.Length < 9 || login.Length > 9)
            {
                return false;
            }
            else if(password.Length < 5 || password.Length > 14)
            {
                return false;
            }
            else return true;
        }
        

    }
}
