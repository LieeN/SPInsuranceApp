using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //Funktion 17 - Visa Företagsregister
    public class Företagsregister
    {
        public long ID { get; set; }
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
    }
}
