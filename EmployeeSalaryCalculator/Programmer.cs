using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    internal class Programmer : EmployeeBaseClass
    {
        private double bonus;
        private double salary;
        public Programmer(double salary, double bonus) : base(salary, bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public override double BonusCalculator()
        {
            //Console.WriteLine("This is bonus calculation method of Programmer");
            return salary*bonus;
        }
    }
}
