using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // Klass 21 - Söka i Företagsregister
    public class sökPersonFöretag
    {
        public long försäkringstagareFöretagId { get; set; }
        public string företagsNamn { get; set; }
        public string kFNamn { get; set; }
        public string kENamn { get; set; }
        public string gatuAdress { get; set; }
        public string ort { get; set; }
        public int postNr { get; set; }
        public int tel1 { get; set; }
        public string email1 { get; set; }
        public int faxNr { get; set; }
        public long orgNr { get; set; }

    }
}
