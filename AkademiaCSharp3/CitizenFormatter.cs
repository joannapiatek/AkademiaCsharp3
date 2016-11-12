using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharp3
{
    public class CitizenFormatter
    {
        public string Format(Citizen citizen)
        {
            return "Obywatel nazywa się " + citizen.Name
                   + ", zarabia " + citizen.Income + " zł miesięcznie, a jego stawka podatkowa wynosi "
                   + citizen.TaxRate*100 + "%.";
        }
    }
}
