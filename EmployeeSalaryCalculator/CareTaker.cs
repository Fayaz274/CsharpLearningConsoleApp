using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    internal class CareTaker : EmployeeBaseClass
    {
        private double bonus;
        private double salary;
        public CareTaker(double salary,double bonus):base(salary,bonus)
        {

            this.bonus = salary;
            this.salary = bonus;

        }
        public override double BonusCalculator()
        {
            //Console.WriteLine("This is bonus calculation method of CareTaker");
            return bonus*salary;
        }
    }
}
