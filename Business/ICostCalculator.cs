using JobCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobCalculator.Business
{
    public interface ICostCalculator
    {
         Result CalculateJobCost(JobDTO job);

         decimal CalculateMargin(decimal price, bool extraMargin = false);

        decimal CalculateSalesTax(decimal price);
    }
}
