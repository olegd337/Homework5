using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string group;
        public double averageMark = 5;

        public virtual int getScholarship()
        {
            return averageMark == 5 ? 100 : 80;
        }
    }
}
