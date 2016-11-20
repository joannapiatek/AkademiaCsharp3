using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharp3
{
    public class Politician : Citizen
    {
        public Politician(string name, double income)
        {
            Name = name;
            Income = income;
            TaxRate = 0.34;
        }

        public override double CalculateTax()
        {
            return Income*TaxRate + 2000;
        }
    }
}
