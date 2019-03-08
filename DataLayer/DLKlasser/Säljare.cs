using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //Klass 5 - Visa säljarens provision 
    public class Säljare
    {
        public long persNr { get; set; }
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public string gatuAdress { get; set; }
        public string ort { get; set; }
        public int postNr { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public string email { get; set; }
        public int Skattesats { get; set; }

    }
}
