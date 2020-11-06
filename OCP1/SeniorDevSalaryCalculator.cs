namespace OCP1
{
    public class SeniorDevSalaryCalculator : SalaryCalculatorBase
    {

        public SeniorDevSalaryCalculator(DeveloperReport devReport) : base(devReport)
        { }

        public override double CalculateSalary()
        {
            return DevReport.HourlyRate * DevReport.WorkingHours * 1.2;
        }
    }
}