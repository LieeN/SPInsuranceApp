using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewlayer
{
    public class Trend
    {
        public int anstId { get; set; }
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public Dictionary<int, double> månadAckVärdeSummaBarn { get; set; }
        public Dictionary<int, double> månadAckVärdeSummaVuxen { get; set; }

        public Trend(int anstId, string fNamn, string eNamn)
        {
            this.anstId = anstId;
            this.fNamn = fNamn;
            this.eNamn = eNamn;

            månadAckVärdeSummaBarn = new Dictionary<int, double>();
            månadAckVärdeSummaVuxen = new Dictionary<int, double>();
            for (int i = 1; i <= 12; i++)
            {
                månadAckVärdeSummaBarn.Add(i, 0.0);
                månadAckVärdeSummaVuxen.Add(i, 0.0);
            }
        }
    }
}
