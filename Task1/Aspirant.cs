using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Aspirant : Student
    {
        string nauchnaRobota;

        public override int getScholarship()
        {
            return averageMark == 5 ? 200 : 180;
        }




    }
}
