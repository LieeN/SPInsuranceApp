using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace Viewlayer.Views
{
    public partial class FormRedigeraPrivatprofil : Form
    {
        public FormRedigeraPrivatprofil()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        // Stänger ner nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sparar redigerade värden till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = long.Parse(tbID.Text);
                Privatansökan nyPrivatansökan = new Privatansökan()
                {
                    privatFörsäkradFNamn = tbFFnamn.Text,
                    privatFörsäkradENamn = tbFEnamn.Text,
                    privatFörsäkradPersNr = long.Parse(tbFpersnr.Text),
                    vuxen = cbVuxenBarn.Text,
                    paGatuadress = tbFGatuadress.Text,
                    paOrt = tbFOrt.Text,
                    paPostnr = int.Parse(tbFpostnr.Text),
                };

                FörsäkringstagarePrivat nyFörsäkringstagarePrivat = new FörsäkringstagarePrivat()
                {
                    fNamn = tbFnamn.Text,
                    eNamn = tbEnamn.Text,
                    gatuAdress = tbGatuadress.Text,
                    ort = tbOrt.Text,
                    postNr = int.Parse(tbPostnr.Text),
                    tel1 = int.Parse(tbTelMobil.Text),
                    tel2 = int.Parse(tbTelBostad.Text),
                    email1 = tbEpost.Text,
                    email2 = tbEpost2.Text,
                    persNr = long.Parse(tbPersnr.Text)
                };

                bm.UppdateraPrivatprofil(ID, nyPrivatansökan, nyFörsäkringstagarePrivat);
                MessageBox.Show("Profilen är redigerad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }
            
        }
    }
}
