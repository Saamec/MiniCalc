using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalc
{
    public  class Calc : IMiniCalc
    {
        public int Summer(int value1, int value2)
        {
            return value1 + value2;
        }

    }
}
