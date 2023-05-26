using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova.Class
{
    public abstract class Document
    {
        private int age;
        private string gender;
        private string firstName;
        private string lastName;
        public int Age {
            get => age;
            set
            {
                if (value < 3) throw new ArgumentOutOfRangeException();
                age = value;
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                gender = value;
            }
        }
        public string FirstName {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                firstName = value;
            }
        }
        public string LastName {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentNullException();
                lastName = value;
            }
        }
    }
}
