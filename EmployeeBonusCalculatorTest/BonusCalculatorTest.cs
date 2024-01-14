using EmployeeSalaryCalculator;
namespace EmployeeBonusCalculatorTest
{
    [TestClass]
    public class BonusCalculatorTest
    {
        private double totalSalary=60000;
        private double bonusApplied=0.3;
        private double bonus;
        private double expectedBonus = 18000;

        [TestMethod]
        public void TestBonusCalculator()
        {
            EmployeeBaseClass employeeBaseCalculator = new Manager(totalSalary, bonusApplied);
            bonus=employeeBaseCalculator.BonusCalculator();
            Assert.AreEqual(expectedBonus, bonus, 0.001, "Bonus cannot be validated");

        }
    }
}