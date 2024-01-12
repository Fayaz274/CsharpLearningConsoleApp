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
            foreach (var employee in employees)
            {

                ClassForCalculatingBonusDirtyWay dirtyClass = new ClassForCalculatingBonusDirtyWay(employee);
                if (dirtyClass.GetType().Name == "SeniorProgrammer")
                {
                    Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
                }
                else if (dirtyClass.GetType().Name == "Manager")
                {
                    Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
                }
                else if (dirtyClass.GetType().Name == "Programmer")
                {
                    Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
                }
                else if (dirtyClass.GetType().Name == "CareTaker")
                {
                    Console.WriteLine("The bonus of employee type " + employee.GetType().Name + " can be calculated as " + employee.BonusCalculator());
                }
                else
                {
                    Console.WriteLine("Object not found");
                }
            }
            Console.ReadLine();
        }
    }
}
