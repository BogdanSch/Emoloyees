using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    abstract class BonusEmployee : Employee
    {
        public int Bonus { get; set; }
        public double SalesVolume { get; set; }

        public abstract override int GetSalary(int days);
    }
}
