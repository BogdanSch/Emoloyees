using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Security : Employee
    {

        
        public override int GetSalary(int days)
        {
            return Rank * days;
        }
    }
}
