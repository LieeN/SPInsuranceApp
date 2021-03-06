﻿using System;
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
    public partial class FormRedigeraPrivatFörsäkringar : Form
    {
        public FormRedigeraPrivatFörsäkringar()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        //Sparar redigerade värderna in i databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbFörsäkringsID.Text);
                string FörsäkringsTyp = cbFörsäkringsTyp.Text;
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
                    tillvalsNamn = cbTillval.Text,
                    grundBelopp = int.Parse(cbGrundbelopp.Text),
                    tvGrundbelopp = int.Parse(cbTillvalsbelopp.Text),
                    försäkringsbolag = tbFörsäkringsbolag.Text,
                    
                    
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

                Försäkring nyFörsäkring = new Försäkring()
                {
                    betald = dtpBetald.Value,
                    försäkringsNr = tbFörsäkringsnummer.Text,
                    provisionsbelopp = int.Parse(tbProvisionsbelopp.Text),
                    
                };
                
                bm.UppdateraPrivatFörsäkring(ID, FörsäkringsTyp, AgentturNr, nyPrivatansökan, nyFörsäkringstagarePrivat, nyFörsäkring);
                MessageBox.Show("Försäkringen är redigerad");
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


        // Ändrar värdet i comboboxen beroende på en annan combobox
        private void cbFörsäkringsTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FörsäkringsTyp = cbFörsäkringsTyp.Text;
            cbGrundbelopp.DataSource = bm.VisaFörsäkringstyp(FörsäkringsTyp);
        }


        // Ändrar värdet i comboboxen beroende på en annan combobox
        private void cbTillval_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tillval = cbTillval.Text;
            cbTillvalsbelopp.DataSource = bm.VisaTillval(Tillval);
        }

        private void FormRedigeraPrivatFörsäkringar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tillValsBeloppTabell.TillvalGrundbeloppSet' table. You can move, or remove it, as needed.
            this.tillvalGrundbeloppSetTableAdapter.Fill(this.tillValsBeloppTabell.TillvalGrundbeloppSet);
            // TODO: This line of code loads data into the 'tillvalsTypTabell.TillvalSet' table. You can move, or remove it, as needed.
            this.tillvalSetTableAdapter.Fill(this.tillvalsTypTabell.TillvalSet);
            // TODO: This line of code loads data into the 'grundbeloppTabell.GrundbeloppSet' table. You can move, or remove it, as needed.
            this.grundbeloppSetTableAdapter.Fill(this.grundbeloppTabell.GrundbeloppSet);
            // TODO: This line of code loads data into the 'försäkringsTypTabell.FörsäkringsTypSet' table. You can move, or remove it, as needed.
            this.försäkringsTypSetTableAdapter.Fill(this.försäkringsTypTabell.FörsäkringsTypSet);

        }
    }
}
