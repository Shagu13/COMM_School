using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public class Company
    {
        public bool IsLocal { get; set; }

        public Company(bool isLocal)
        {
            this.IsLocal = isLocal;
        }

        public double CalculateTax(double salary)
        {
            if (IsLocal)
            {
                return salary * 0.18;
            }
            else
            {
                return salary * 0.05;
            }
            // Both Codes above and bellow do the same thing
            double taxPercentage = IsLocal ? 18 : 5; // if isLocal - true uses 18, elseif - false uses 5
            double taxAmount = (taxPercentage / 100) * salary;
            return taxAmount;

        }
    }
}
