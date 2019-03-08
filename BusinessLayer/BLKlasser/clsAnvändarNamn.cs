using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsAnvändarNamn
    {

        
        public static int AnställningsId { get; set; }
        public static string fNamn { get; set; }
        public void AnvändarNamn(int AnställningsId)
        {
            DataManager dm = new DataManager();
           string fnamn= dm.dmAnvändarFnamn(AnställningsId);
            fNamn = fnamn;
            
            
            //DataModelContainer dmc = new DataModelContainer();
            //var query = (from x in dmc.PersonalSet
            //             where x.anställningsId == AnställningsId
            //             select x.fNamn + x.eNamn).FirstOrDefault();
            //string namn = query;
            //Namn = namn;
            //return;
        }
    }
}
