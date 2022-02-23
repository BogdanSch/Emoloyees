using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class SEO : BonusEmployee
    {
        public override int GetSalary(int days)
        {
            long sale =  (int)(Bonus * SalesVolume  * days / 100 / 30);
            return (int)sale;
        }
    }
}
