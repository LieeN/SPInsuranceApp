﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    // Klass 20 - Sök person i Privatregister
    public class sökPersonPrivat
    {
        public long försäkringstagarPrivatID { get; set; }

        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public string gatuAdress { get; set; }
        public string ort { get; set; }
        public int postNr { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public bool prospekt { get; set; }
        public long persNr { get; set; }
        public long privatFörsäkradPersNr { get; set; }
        public string privatFörsäkradENamn { get; set; }
        public int privatAnsökningsId { get; set; }
        public string privatFörsäkradFNamn { get; set; }
        public DateTime ankomstdatum { get; set; }
        public string betalningsform { get; set; }
        public string vuxen { get; set; }
        public int premie { get; set; }
        public string paGatuadress { get; set; }
        public string paOrt { get; set; }
        public int paPostnr { get; set; }
        public string tillvalsNamn { get; set; }
        public int grundBelopp { get; set; }
        public int? tvGrundbelopp { get; set; }
        public string försäkringsbolag { get; set; }
    }
}
