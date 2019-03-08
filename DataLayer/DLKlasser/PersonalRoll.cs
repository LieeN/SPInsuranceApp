using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // Klass 2 - Visa Personal och roll
    public class PersonalRoll
    {
        public int anställningsId { get; set; }
        public long persNr { get; set; }
        public int agenturNr { get; set; }
        public double skattesats { get; set; }
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public string gatuAdress { get; set; }
        public string ort { get; set; }
        public int postNr { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public string email { get; set; }
        public string lösenord { get; set; }
        public string rollNamn { get; set; }
    }
}
