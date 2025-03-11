using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class Combination(Color c1, Color c2, Color c3, Color c4)
    {
        public override string ToString()
        {
            return $"({c1}, {c2}, {c3}, {c4})";
        }
    }
}
