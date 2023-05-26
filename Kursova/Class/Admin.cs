using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Class
{
    class Admin : IAdmin
    {
        private List<RegistrUser> registrations;

        public Admin(List<RegistrUser> registrations) 
        { 
            this.registrations = registrations;
        }

        public void ViewUserPasswords()
        {
            List<string> passwords = new List<string>();
            foreach (RegistrUser user in registrations)
            {
                passwords.Add(string.Format("User: {0}, Password: {1}", user.Login, user.Password));
            }
        }
        public void RemoveUser(string login)
        {
            RegistrUser userToRemove = registrations.FirstOrDefault(u => u.Login == login);
            if (userToRemove != null)
            {
                registrations.Remove(userToRemove);
                Console.WriteLine("User with login '{0}' has been removed.", login);
            }
            else
            {
                Console.WriteLine("User with login '{0}' not found.", login);
            }
        }
    }
}
