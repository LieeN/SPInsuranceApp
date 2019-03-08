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
    public partial class FormSkapaPrivatFörsäkring : Form
    {
        public FormSkapaPrivatFörsäkring()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();


        //Sparar inskrivna värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbAnsökningsId.Text);
                int GrundBelopp = int.Parse(cbGrundbelopp.Text);
                string Försäkringstyp = cbFörsäkringsTyp.Text;
                int AgentturNr = int.Parse(tbAgenturnummer.Text);

                Privatansökan nyPrivatansökan = new Privatansökan()
                {
                    privatFörsäkradPersNr = long.Parse(tbPersonNrFörsäkrad.Text),
                    privatFörsäkradFNamn = tbFörnamnFörsäkrad.Text,
                    privatFörsäkradENamn = tbefternamnFörsäkrad.Text,
                    paGatuadress = tbGatuadressFörsäkrad.Text,
                    paOrt = tbOrtFörsäkrad.Text,
                    paPostnr = int.Parse(tbpostNrFörsäkrad.Text),
                    ankomstdatum = dtpAnkomstdatum.Value,
                    betalningsform = cbBetalningsform.Text,
                    vuxen = cbVuxenBarn.Text,
                    premie = int.Parse(tbPremie.Text),
                    tillvalsNamn = cbÖnskatTV.Text,
                    grundBelopp = int.Parse(cbGrundbelopp.Text),
                    tvGrundbelopp = int.Parse(cbÖnskatTB.Text),
                    försäkringsbolag = tbFörsäkringsbolag.Text
                };

                FörsäkringstagarePrivat nyFörsäkringstagarePrivat = new FörsäkringstagarePrivat()
                {
                    persNr = long.Parse(tbpersonNrFörsäkringstagare.Text),
                    fNamn = tbförnamnFörsäkringstagare.Text,
                    eNamn = tbefternamnFörsäkringstagare.Text,
                    gatuAdress = tbgatuadressFörsäkringstagare.Text,
                    ort = tbOrtFörsäkringstagare.Text,
                    postNr = int.Parse(tbpostNrFörsäkringstagare.Text),
                    tel1 = int.Parse(tbtelNrMobil.Text),
                    tel2 = int.Parse(tbtelNrBostad.Text),
                    email1 = tbepost1.Text,
                    email2 = tbepost2.Text,
                };


                Försäkring nyPrivatFörsäkring = new Försäkring()
                {
                    försäkringsNr = tbFörsäkringsNummer.Text,
                    betald = DateTime.Parse(dtpBetald.Text),
                    provisionsbelopp = int.Parse(tbProvisionsbelopp.Text),
                };

                bm.UpdateGrundbeloppFörsäkring(ID, GrundBelopp);
                bm.SkapaPrivatFörsäkring(ID, nyPrivatFörsäkring);
                bm.SkapaUpdatePrivatFörsäkring(ID, Försäkringstyp, AgentturNr, nyPrivatansökan, nyFörsäkringstagarePrivat);
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

        // Laddar in datasets
        private void FormSkapaPrivatFörsäkring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tillValsBeloppTabell.TillvalGrundbeloppSet' table. You can move, or remove it, as needed.
            this.tillvalGrundbeloppSetTableAdapter.Fill(this.tillValsBeloppTabell.TillvalGrundbeloppSet);
            // TODO: This line of code loads data into the 'tillvalsTypTabell.TillvalSet' table. You can move, or remove it, as needed.
            this.tillvalSetTableAdapter.Fill(this.tillvalsTypTabell.TillvalSet);
            // TODO: This line of code loads data into the 'försäkringsTypTabell.FörsäkringsTypSet' table. You can move, or remove it, as needed.
            this.försäkringsTypSetTableAdapter.Fill(this.försäkringsTypTabell.FörsäkringsTypSet);
            // TODO: This line of code loads data into the 'grundbeloppTabell.GrundbeloppSet' table. You can move, or remove it, as needed.
            this.grundbeloppSetTableAdapter.Fill(this.grundbeloppTabell.GrundbeloppSet);

        }

        // Ändrar värdet i comboboxen beroende på en annan combobox
        private void cbFörsäkringsTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FörsäkringsTyp = cbFörsäkringsTyp.Text;
            cbGrundbelopp.DataSource = bm.VisaFörsäkringstyp(FörsäkringsTyp);
        }
        
        // Ändrar värdet i comboboxen beroende på en annan combobox
        private void cbÖnskatTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tillval = cbÖnskatTV.Text;
            cbÖnskatTB.DataSource = bm.VisaTillval(Tillval);
        }
    }
}
