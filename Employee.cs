using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int Rank { get; set; }

        public abstract int GetSalary(int days);

        public override string ToString()
        {
            return $"{Name} - {GetSalary(30)}";
        }
    }
}
