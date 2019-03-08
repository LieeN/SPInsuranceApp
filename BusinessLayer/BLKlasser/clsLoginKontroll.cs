using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace BusinessLayer
{
     public class clsLoginKontroll
    {
      


        public static bool IsValid(int anställningsId, string lösenord)
        {


            DataManager dm = new DataManager();
            return dm.dmIsValid(anställningsId, lösenord);

        }
    }
}
