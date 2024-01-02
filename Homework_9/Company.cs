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

        //public Company(bool isLocal)
        //{
        //    this.IsLocal = isLocal;
        //}

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

        }
    }
}
