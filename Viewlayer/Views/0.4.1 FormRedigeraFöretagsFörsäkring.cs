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
    public partial class FormRedigeraFöretagsFörsäkring : Form
    {
        public FormRedigeraFöretagsFörsäkring()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();


        // Sparar redigerade värderna till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbFörsäkringsID.Text);
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
                    orgNr = int.Parse(tbOrgnr.Text),
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

                FörsäkringFöretag nyFörsäkringFöretag = new FörsäkringFöretag()
                {
                    försäkringsNr = tbFörsäkringsnummer.Text,
                    betald = dtpBetald.Value,
                    provisionsbelopp = int.Parse(tbProvisionsbelopp.Text)

                };
                bm.UppdateraFöretagsFörsäkring(ID, nyFöretagsansökan, nyFörsäkringstagareFöretag, nyFörsäkringFöretag);
                MessageBox.Show("Försäkringen är redigerad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }
        }

        // Stänger ner nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
