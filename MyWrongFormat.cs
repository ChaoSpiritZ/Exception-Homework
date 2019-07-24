using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Homework_2nd_try
{
    class MyWrongFormat : Exception
    {
        public MyWrongFormat() : base("Wrong format my dude")
        {

        }
    }
}
