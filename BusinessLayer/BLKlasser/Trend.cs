using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.BLKlasser
{
    public class Trend
    {
        public Dictionary<int, TrendRad> Rader { get; private set; }
        public double TotalÅrMedelAckVärde { get; private set; }
        public double MedelÅrMedelAckVärde { get; private set; }

        public Trend()
        {
            Rader = new Dictionary<int, TrendRad>();
            TotalÅrMedelAckVärde = 0.0;
            MedelÅrMedelAckVärde = 0.0;
        }

        public void LäggTill(int anstId, string fNamn, string eNamn, string typ, int månad, double ackVärde)
        {
            TrendRad rad;
            if (!Rader.TryGetValue(anstId, out rad))
            {
                rad = new TrendRad(anstId, fNamn, eNamn);
                Rader.Add(anstId, rad);
            }

            TotalÅrMedelAckVärde -= rad.ÅrAckVärde["Medel"];
            rad.LäggTill(typ, månad, ackVärde);
            TotalÅrMedelAckVärde += rad.ÅrAckVärde["Medel"];
            MedelÅrMedelAckVärde = TotalÅrMedelAckVärde / Rader.Count();

            foreach (TrendRad r in Rader.Values)
                r.SättTotalMedelAckVärde(MedelÅrMedelAckVärde);
        }
    }
}
