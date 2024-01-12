using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    internal class ClassForCalculatingBonusDirtyWay
    {
        public ClassForCalculatingBonusDirtyWay()
        {
            
        }


        public void CalculateBonus(EmployeeBaseClass employee) 
        {
            if (employee.GetType().Name == "SeniorProgrammer")
            {
                Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
            }
            else if (employee.GetType().Name == "Manager")
            {
                Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
            }
            else if (employee.GetType().Name == "Programmer")
            {
                Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
            }
            else if (employee.GetType().Name == "CareTaker")
            {
                Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
            }
            else
            {
                Console.WriteLine("Object not found");
            }
        }
       
    }
}
