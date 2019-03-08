using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace Viewlayer.Views
{
    public partial class FormRedigeraInloggningsprofil : Form
    {
        public FormRedigeraInloggningsprofil()
        {
            InitializeComponent();

        }

        //Uppdatera Funktion 5 Uppdaterar säljare i inloggningsprofil
        private void btnSpara_Click(object sender, EventArgs e)
        {
            BusinessManager bm = new BusinessManager();
            string fNamn = "felv";                          //OBS HÅRDKODAD
            var hämtad = bm.HämtaInloggningsprofil(fNamn);

            int ID = int.Parse(tbanställningsID.Text);
            Personal nyPersonal = new Personal()
            {

                agenturNr = int.Parse(tbagentnr.Text),
                persNr = int.Parse(tbPersnr.Text),
                eNamn = tbenamn.Text,
                fNamn = tbfnamn.Text,
                gatuAdress = tbgatuadr.Text,
                ort = tbort.Text,
                postNr = int.Parse(tbpostnr.Text),
                tel1 = int.Parse(tbtelfonbo.Text),
                tel2 = int.Parse(tbtelfonbo.Text),
                email = tbepost.Text,
                lösenord = tblösenord.Text,
                skattesats = int.Parse(tbskattesats.Text),
                anställningsId = int.Parse(tbanställningsID.Text)
            };


            bm.UppdateraMinProfil(ID, nyPersonal);

            MessageBox.Show("Profilen är redigerad");
            this.Close();
        }
    }
}
