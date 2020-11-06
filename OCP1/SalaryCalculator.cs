using System.Collections.Generic;

namespace OCP1
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<SalaryCalculatorBase> _devSalaryCalculators;

        public SalaryCalculator(IEnumerable<SalaryCalculatorBase> devSalaryCalculators)
        {
            _devSalaryCalculators = devSalaryCalculators;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D ;

            //foreach (var devReport in _developerReports)
            //{
            //    if (devReport.Level == "Senior developer")
            //    {
            //        totalSalaries += new SeniorDevSalaryCalculator(devReport).CalculateSalary();
            //    }
            //    else
            //    {
            //        totalSalaries += new JuniorDevSalaryCalculator(devReport).CalculateSalary();
            //    }
            //}

            foreach (var devSalaryCalculator in _devSalaryCalculators)
            {
                totalSalaries += devSalaryCalculator.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}