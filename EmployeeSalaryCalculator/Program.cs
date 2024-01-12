namespace EmployeeSalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeBaseClass> employees = new List<EmployeeBaseClass>();
            employees.Add(new SeniorProgrammer(35000.0, 0.2));
            employees.Add(new Manager(25000, 0.15));
            employees.Add(new Programmer(20000.0,0.1));
            employees.Add(new CareTaker(15000,0.05));

           

            foreach (var employee in employees)
            {
                Console.WriteLine("The bonus of employee type "+ employee.GetType().Name +" can be calculated as "+employee.BonusCalculator());
                
            }
            Console.WriteLine("****************************** Dirty Way **********************************");
            ClassForCalculatingBonusDirtyWay dirtyClass = new ClassForCalculatingBonusDirtyWay();
            foreach (var employee in employees)
            {
                dirtyClass.CalculateBonus(employee);

            }
            Console.ReadLine();
        }
    }
}
