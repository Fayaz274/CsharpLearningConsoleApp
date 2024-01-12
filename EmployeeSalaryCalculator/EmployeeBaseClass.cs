using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    abstract class EmployeeBaseClass
    {
        private double salary;
        private double bonus;

        public EmployeeBaseClass(double salary, double bonus)
        {

            this.salary = salary;
            this.bonus = bonus;
        }
        public abstract double BonusCalculator();
    }
}
