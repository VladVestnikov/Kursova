using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Class
{
    public enum SchoolSubject
    {
        All,
        Mathematics,
        Physics,
        Chemistry,
        Biology,
        History,
        Geography,
        English,
        French,
        German
    }
    class Subject
    {
        public static string NameSubject(SchoolSubject subject)
        {
            switch (subject)
            {
                case SchoolSubject.All:
                    return "Все";
                case SchoolSubject.Mathematics:
                    return "Математика";
                case SchoolSubject.Physics:
                    return "Фізика";
                case SchoolSubject.Chemistry:
                    return "Хімія";
                case SchoolSubject.Biology:
                    return "Біологія";
                case SchoolSubject.History:
                    return "Історія";
                case SchoolSubject.Geography:
                    return "Географія";
                case SchoolSubject.English:
                    return "Англійська мова";
                case SchoolSubject.French:
                    return "Французька мова";
                case SchoolSubject.German:
                    return "Німецька мова";              
                default:
                    throw new ArgumentException("Невідомий предмет");
            }
        }
    }
}
