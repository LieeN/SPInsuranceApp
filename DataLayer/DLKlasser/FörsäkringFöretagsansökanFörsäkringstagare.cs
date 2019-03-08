using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // Klass 14 - Visa Företagsförsäkring och dess Försäkringstagare
    public class FörsäkringFöretagsansökanFörsäkringstagare
    {
        public string företagsnamn { get; set; }
        public long orgNr { get; set; }
        public string kFnamn { get; set; }
        public string kEnamn { get; set; }
        public string gatuAdress { get; set; }
        public string ort { get; set; }
        public int postNr { get; set; }
        public int tel1 { get; set; }
        public int faxNr { get; set; }
        public string email1 { get; set; }
        public string försäkringsbolag { get; set; }
        public DateTime begynnelsedatum { get; set; }
        public DateTime förfallodatum { get; set; }
        public string betalningsform { get; set; }
        public int premie { get; set; }
        public string anteckning { get; set; }
        public string försäkringstyp { get; set; }
        public int agenturNr { get; set; }
        public int företagsFörsäkringsID { get; set; }
        public string försäkringsNr { get; set; }
        public DateTime betald { get; set; }
        public int provisionsbelopp { get; set; }
    }
}
