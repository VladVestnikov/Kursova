using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Kursova.Class
{
    public interface IEnumerable<T>
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator<t>()
        {
            throw new NotImplementedException();
        }
    }
}
