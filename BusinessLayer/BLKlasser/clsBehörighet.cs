using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsBehörighet
    {
        
        public static int AnställningsId { get; set; }
        public static int Behörighet { get; set; }

        public void användarBehörighet(int AnställningsId)
        {
            DataManager dm = new DataManager();
            
            int behörighet = dm.dmAnvändarBehörighet(AnställningsId);
            Behörighet = behörighet;
            //dm.dmAnvändarBehörighet(AnställningsId);
            
            
            //DataModelContainer dmc = new DataModelContainer();
            //var query = (from b in dmc.PersonalSet
            //             where b.anställningsId == AnställningsId
            //             select b.Roll.Behörighet.behörighetsId).FirstOrDefault();
            //int behörighet = query;
            //Behörighet = behörighet;
        }
        public void Inloggad(int AnställningsId)
        {
            DataManager dm = new DataManager();
            int anställningsId = dm.KollaAnställningsId(AnställningsId);
            AnställningsId = anställningsId;
        }
    }
}
