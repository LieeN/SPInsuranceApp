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
    public partial class FormSkapaFörsäkring : Form
    {
        public FormSkapaFörsäkring()
        {
            InitializeComponent();
        }
        BusinessManager bm = new BusinessManager();

        // Sparar inskriva värderna till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbAnsökningsId.Text);
                Företagsansökan nyFöretagsansökan = new Företagsansökan()
                {
                    försäkringsbolag = tbFörsäkringsbolag.Text,
                    försäkringsTyp = cbFörsäkringstyp.Text,
                    begynnelsedatum = dtpBegynnelsedatum.Value,
                    förfallodag = dtpFörfallodag.Value,
                    betalningsform = cbBetalningsform.Text,
                    premie = int.Parse(tbPremie.Text),
                    Anteckning = tbAnteckning.Text,
                };
                FörsäkringstagareFöretag nyFörsäkringstagareFöretag = new FörsäkringstagareFöretag()
                {
                    orgNr = long.Parse(tbOrgnr.Text),
                    företagsNamn = tbFöretagsnamn.Text,
                    gatuAdress = tbGatuadress.Text,
                    ort = tbOrt.Text,
                    postNr = int.Parse(tbPostnr.Text),
                    kFNamn = tbFörnamn.Text,
                    kENamn = tbEfternamn.Text,
                    tel1 = int.Parse(tbTelnr.Text),
                    email1 = tbEpost.Text,
                    faxNr = int.Parse(tbFaxnr.Text),
                };

                FörsäkringFöretag nyFörsäkringsFöretag = new FörsäkringFöretag()
                {
                    försäkringsNr = tbFörsäkringsNummer.Text,
                    provisionsbelopp = int.Parse(tbProvisionsbelopp.Text),
                    betald = DateTime.Parse(dtpBetald.Text)
                };


                bm.SkapaFöretagFörsäkring(ID, nyFörsäkringsFöretag);
                bm.SkapaUpdateFöretagFörsäkring(ID, nyFöretagsansökan, nyFörsäkringstagareFöretag);

                MessageBox.Show("Försäkringen är skapad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }

        }

        // Stänger nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
