namespace OCP1
{
    public class JuniorDevSalaryCalculator : SalaryCalculatorBase
    {
        public JuniorDevSalaryCalculator(DeveloperReport devReport) : base(devReport)
        { }

        public override double CalculateSalary()
        {
            return DevReport.HourlyRate * DevReport.WorkingHours;
        }
    }
}