namespace OCP1
{
    public abstract class SalaryCalculatorBase
    {
        protected DeveloperReport DevReport { get; private set; }

        protected SalaryCalculatorBase(DeveloperReport devReport)
        {
            DevReport = devReport;
        }


        public abstract double CalculateSalary();
    }
}