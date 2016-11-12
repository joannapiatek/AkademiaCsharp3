using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharp3
{
    public class Citizen
    {
        public string Name { get; set; }

        // to zrobic potem prywatne, a przy dziedziczeniu protected żeby działało
        public double TaxRate { get; set; }

        public double Income { get; set; }

        // Zadanie do napisania nr 2. - dodac do konstruktora + metoda
        public DateTime BornDate { get; set; }  

        public Citizen()
        {
            Name = string.Empty;
            TaxRate = 0.2;
            Income = 1800;
        }

        public Citizen(string name, double income = 1800, double taxRate = 0.2)
        {
            Name = name;
            TaxRate = taxRate;
            Income = income;
        }

        public virtual double CalculateTax()
        {
            return TaxRate * Income + 10;
        }

        // Zadanie do napisania nr 2.
        //public int GetAge()
        //{
        //    var lifeTime = DateTime.Now - BornDate;
        //    var zeroTime = new DateTime(1, 1, 1);
        //    var age = (zeroTime + lifeTime).Year -1;

        //    return age;
        //}
    }
}
