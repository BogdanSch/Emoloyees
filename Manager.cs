using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Manager : BonusEmployee
    {
        public override int GetSalary(int days)
        {
            return Rank * days +(int)(Bonus * SalesVolume * days / 100 / 30);
        }
    }
}
