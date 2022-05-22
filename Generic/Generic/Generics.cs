using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Generics
    {
        public string First, Second, Third;
        public string data(string First, string Second, string Third)
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            else if (Second.CompareTo(Third) > 0 && Second.CompareTo(First) > 0)
            {
                return Second;
            }
            else if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            return First;

        }
    }
}
