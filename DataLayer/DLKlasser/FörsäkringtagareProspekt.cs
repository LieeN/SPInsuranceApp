using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // Klass 28 - FörsäkringtagareProspekt
    public class FörsäkringtagareProspekt
    {
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public long persNr { get; set; }
        public string gatuAdress { get; set; }
        public int postNr { get; set; }
        public string ort { get; set; }
        public int telNrMobil { get; set; }
        public int telNrBostad { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public int agenturNr { get; set; }
    }
}
