using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Class
{
        public class DocumentTeacher
        {
        string SubjectForLearning(SchoolSubject subject) {
            string subjectName = Subject.NameSubject(subject);
            switch (subject)
            {
                case SchoolSubject.All:
                    return $"Teaching all subjects: {subjectName}";
                case SchoolSubject.Mathematics:
                    return $"Teaching Mathematics: {subjectName}";
                case SchoolSubject.Physics:
                    return $"Teaching Physics: {subjectName}";
                case SchoolSubject.Chemistry:
                    return $"Teaching Chemistry: {subjectName}";
                case SchoolSubject.Biology:
                    return $"Teaching Biology: {subjectName}";
                case SchoolSubject.History:
                    return $"Teaching History: {subjectName}";
                case SchoolSubject.Geography:
                    return $"Teaching Geography: {subjectName}";
                case SchoolSubject.English:
                    return $"Teaching English: {subjectName}";
                case SchoolSubject.French:
                    return $"Teaching French: {subjectName}";
                case SchoolSubject.German:
                    return $"Teaching German: {subjectName}";
                default:
                    throw new ArgumentException("Unknown subject");
            }
        }
        public int Money { get; set; } = 300;
        }
}
