using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //Klass 16 - Visa Privatregister
    public class Privatregister
    {
        public long försäkringstagarPrivatID { get; set; }
        public long persNr { get; set; }
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public string gatuAdress { get; set; }
        public string ort { get; set; }
        public int postNr { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public long privatFörsäkradPersNr { get; set; }
        public string privatFörsäkradFNamn { get; set; }
        public string privatFörsäkradENamn { get; set; }
        public string vuxen { get; set; }
        public string paGatuadress { get; set; }
        public string paOrt { get; set; }
        public int paPostNr { get; set; }
    }
}
