using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Class
{
     public class Student
    {
        private string subject;
        private string clas;
        private string typeOfTraining;
        private string name;
        private string age;

        public string Name { get => name; set=> name = value; }
        public string Age { get=> age; set=> age = value; }
        public string Subject { get=> subject; set=> subject = value; }
        public string Clas { get=> clas; set=> clas = value; }
        public string TypeOfTraining { get=> typeOfTraining; set => typeOfTraining = value; }
       
    }
}
