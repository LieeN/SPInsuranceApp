using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // Klass 29 - Hämta AckVärdenBarn för trend
    public class AckVärdenBarn
    {
        public int anstId { get; set; }
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public string typ { get; set; }
        public int månad { get; set; }
        public double ackVärdeSumma { get; set; }
    }
}
