using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Step219_Console_App
{
    class MathProblem
    {
        int num { get; set; }
        int x { get; set; }
        decimal numDecimal { get; set; }


        public int Add(int num)
        {
            int x = 5 + num;
            return x;
        }

        public int Add(decimal numDecimal)
        {
            x = 100 - Convert.ToInt32(numDecimal);
            return x;

        }
        public int Add(string numString)
        {
            int x = 5 + (Convert.ToInt32(numString));
            return x;
        }
    }
}