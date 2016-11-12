using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharp3
{
    public class Teacher : Citizen
    {
        // Nowa properta, ktorej nie posiada ani Citizen, ani Politician
        //public bool IsTutor { get; set; }

        public Teacher(string name, double income)
        {
            Name = name;           
            Income = income;
            TaxRate = 0.18;
        }
    }
}
