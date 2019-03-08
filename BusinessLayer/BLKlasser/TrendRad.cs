using System.Collections.Generic;

namespace BusinessLayer.BLKlasser
{
    public class TrendRad
    {
        public int AnstId { get; private set; }
        public string FNamn { get; private set; }
        public string ENamn { get; private set; }

        public Dictionary<string, Dictionary<int, double>> MånadAckVärde { get; private set; }
        public Dictionary<string, double> ÅrAckVärde { get; private set; }
        public double TotalMedelAckVärde { get; private set; }
        int antalMånaderMedAckVärden;

        public TrendRad(int anstId, string fNamn, string eNamn)
        {
            AnstId = anstId;
            FNamn = fNamn;
            ENamn = eNamn;

            MånadAckVärde = new Dictionary<string, Dictionary<int, double>>();
            ÅrAckVärde = new Dictionary<string, double>();
            TotalMedelAckVärde = 0.0;
            antalMånaderMedAckVärden = 0;

            Dictionary<int, double> månadAckVärdeBarn = new Dictionary<int, double>();
            Dictionary<int, double> månadAckVärdeVuxen = new Dictionary<int, double>();
            Dictionary<int, double> månadAckVärdeTotalt = new Dictionary<int, double>();
            for (int i = 1; i <= 12; i++)
            {
                månadAckVärdeBarn.Add(i, 0.0);
                månadAckVärdeVuxen.Add(i, 0.0);
                månadAckVärdeTotalt.Add(i, 0.0);
            }
            MånadAckVärde.Add("Barn", månadAckVärdeBarn);
            MånadAckVärde.Add("Vuxen", månadAckVärdeVuxen);
            MånadAckVärde.Add("Totalt", månadAckVärdeTotalt);

            ÅrAckVärde.Add("Barn", 0.0);
            ÅrAckVärde.Add("Vuxen", 0.0);
            ÅrAckVärde.Add("Totalt", 0.0);
            ÅrAckVärde.Add("Medel", 0.0);
        }

        public void LäggTill(string typ, int månad, double ackVärde)
        {
            MånadAckVärde[typ][månad] += ackVärde;
            MånadAckVärde["Totalt"][månad] += ackVärde;
            ÅrAckVärde[typ] += ackVärde;
            ÅrAckVärde["Totalt"] += ackVärde;
            ÅrAckVärde["Medel"] = ÅrAckVärde["Totalt"] / ++antalMånaderMedAckVärden;
        }

        public void SättTotalMedelAckVärde(double medelÅrTotalMedelAckVärde)
        {
            TotalMedelAckVärde = ÅrAckVärde["Medel"] - medelÅrTotalMedelAckVärde;
        }
    }
}
