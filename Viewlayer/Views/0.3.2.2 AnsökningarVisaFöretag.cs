﻿using System;
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
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Viewlayer.Views
{
    public partial class FormAnsökningarVisaFöretag : Form
    {
        public FormAnsökningarVisaFöretag()
        {
            InitializeComponent();
            // Visar namnet på den som är inloggad
            användare.Text = ("Användare: " + clsAnvändarNamn.fNamn).ToUpper();
            // Behörighetkontroller
            if (clsBehörighet.Behörighet != 3)
            {
                grunduppgifterToolStripMenuItem.Enabled = false;
                provisionToolStripMenuItem.Enabled = false;
                visaProvsionsvärdetabellToolStripMenuItem.Enabled = false;
                visaSemesterersättningToolStripMenuItem.Enabled = false;
                behörighetToolStripMenuItem.Enabled = false;

                visaSemesterersättningToolStripMenuItem.Enabled = false;
                behörighetToolStripMenuItem.Enabled = false;
                prospektToolStripMenuItem.Enabled = false;
            }
            if (clsBehörighet.Behörighet > 3)
            {
                personalToolStripMenuItem.Enabled = false;
                visaTrendToolStripMenuItem.Enabled = false;
                visaStatistikToolStripMenuItem.Enabled = false;
            }
        }

        BusinessManager bm = new BusinessManager();

        #region Menystrip

        // Menystrip - 1. Öppnar huvudmeny via menynstripen samt stänger ner nuvarande ruta
        private void mSStartHuvudMeny(object sender, EventArgs e)
        {
            var VisaHuvudMeny = new FormHuvudMeny();
            VisaHuvudMeny.Show();
            this.Hide();
        }

        // Menystrip - 1.1 Öppnar personprofil via menynstripen samt stänger ner nuvarande ruta
        private void mSStartMinProfil(object sender, EventArgs e)
        {
            var PersonProfil = new FormInloggningsProfil();
            PersonProfil.Show();
            this.Hide();
        }

        // Menystrip - 1.2 Loggar ut och återvänder till inloggnings vyn 0.0 Login
        private void loggaUtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new FormLogin();
            login.Show();
            this.Hide();
        }

        // Menystrip - 2.1 Öppnar privatregister via menynstripen samt stänger ner nuvarande ruta
        private void mSRegisterPrivat(object sender, EventArgs e)
        {
            var PrivatRegister = new FormPrivatRegister();
            PrivatRegister.Show();
            this.Hide();
        }

        // Menystrip - 2.1 Öppnar privatregister via menynstripen samt stänger ner nuvarande ruta
        private void mSRegisterFöretag(object sender, EventArgs e)
        {
            var FöretagRegister = new FormFöretagRegister();
            FöretagRegister.Show();
            this.Hide();
        }

        // Menystrip - 3.1 Öppnar skapa ny ansökan person via menynstripen samt stänger ner nuvarande ruta
        private void mSSkapaNyAnsökanPrivat(object sender, EventArgs e)
        {
            var SkapaNyAnsökanPrivat = new FormSkapaNyAnsökanPrivat();
            SkapaNyAnsökanPrivat.Show();
            this.Hide();
        }

        // Menystrip - 3.1 Öppnar skapa ny ansökan företag via menynstripen samt stänger ner nuvarande ruta
        private void mSSkapaNyAnsökanFöretag(object sender, EventArgs e)
        {
            var SkapaNyAnsökanFöretag = new FormSkapaNyAnsökanFöretag();
            SkapaNyAnsökanFöretag.Show();
            this.Hide();
        }

        // Menystrip - 3.2 Öppnar visa ansökan privat via menynstripen samt stänger ner nuvarande ruta
        private void mSAnsökningarVisaPrivat(object sender, EventArgs e)
        {
            var VisaAnsökanPrivat = new FormAnsökningarVisaPrivat();
            VisaAnsökanPrivat.Show();
            this.Hide();
        }

        // Menystrip - 3.2 Öppnar visa ansökan företag via menynstripen samt stänger ner nuvarande ruta
        private void mSAnsökningarVisaFöretag(object sender, EventArgs e)
        {
            var VisaAnsökanFöretag = new FormAnsökningarVisaFöretag();
            VisaAnsökanFöretag.Show();
            this.Hide();
        }

        // Menystrip - 4.1 Öppnar visa försäkringar privat via menynstripen samt stänger ner nuvarande ruta
        private void mSFörsäkringarVisaPrivat(object sender, EventArgs e)
        {
            var FörsäkringarVisaPrivat = new FormFörsäkringsarVisaPrivat();
            FörsäkringarVisaPrivat.Show();
            this.Hide();
        }

        // Menystrip - 4.1 Öppnar visa försäkringar företag via menynstripen samt stänger ner nuvarande ruta
        private void mSFörsäkringarVisaFöretag(object sender, EventArgs e)
        {
            var FörsäkringarVisaFöretag = new FormFörsäkringarVisaFöretag();
            FörsäkringarVisaFöretag.Show();
            this.Hide();
        }

        // Menystrip - 5.1 Öppnar försäkringstyp/tillval via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaFörsäkringstypTillval(object sender, EventArgs e)
        {
            var VisaFörsäkringstypTillval = new FormFörsäkringstypTillval();
            VisaFörsäkringstypTillval.Show();
            this.Hide();
        }

        // Menystrip - 5.2 Öppnar provisionvärdetabell företag via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaProvisionsvärdetabell(object sender, EventArgs e)
        {
            var VisaProvisionsvärdetabell = new FormProvisionsvärdetabell();
            VisaProvisionsvärdetabell.Show();
            this.Hide();
        }

        // Menystrip - 5.3 Öppnar semesterersättning  via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaSemesterersättning(object sender, EventArgs e)
        {
            var VisaSemesterersättning = new FormSemesterersättning();
            VisaSemesterersättning.Show();
            this.Hide();
        }

        // Menystrip - 7.1 Öppnar visa personal via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaPersonal(object sender, EventArgs e)
        {
            var VisaPersonal = new FormPersonal();
            VisaPersonal.Show();
            this.Hide();
        }

        // Menystrip - 7.2 Öppnar behörighet via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaBehörighet(object sender, EventArgs e)
        {
            var VisaBehörighet = new FormBehörighet();
            VisaBehörighet.Show();
            this.Hide();
        }

        // Menystrip - 8.1 Öppnar provision via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaProvision(object sender, EventArgs e)
        {
            var VisaProvision = new FormProvision();
            VisaProvision.Show();
            this.Hide();
        }

        // Menystrip - 9.1 Öppnar försäljningsstatistik via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaFörsäljningsstatistik(object sender, EventArgs e)
        {
            var VisaFörsäljningsstatistik = new FormFörsäljningsStatistik();
            VisaFörsäljningsstatistik.Show();
            this.Hide();
        }

        // Menystrip - 9.2 Öppnar trend via menynstripen samt stänger ner nuvarande ruta
        private void mSVisaTrend(object sender, EventArgs e)
        {
            var VisaTrend = new FormTrend();
            VisaTrend.Show();
            this.Hide();
        }

        //Menystrip - 6.0 Skriver ut Prospekt
        private void skrivUtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var prospekt = bm.HämtaFörsäkringsProspekt();


            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            xla.Visible = true;

            #region Columns
            ws.Columns[1].ColumnWidth = 25;
            ws.Columns[2].ColumnWidth = 25;
            ws.Columns[3].ColumnWidth = 25;
            ws.Columns[4].ColumnWidth = 25;
            ws.Columns[5].ColumnWidth = 25;
            ws.Columns[6].ColumnWidth = 25;
            ws.Columns[7].ColumnWidth = 25;
            ws.Columns[8].ColumnWidth = 25;
            ws.Columns[9].ColumnWidth = 25;
            ws.Columns[10].ColumnWidth = 25;
            ws.Columns[11].ColumnWidth = 25;
            ws.Columns[12].ColumnWidth = 25;
            ws.Columns[13].ColumnWidth = 25;
            ws.Columns[14].ColumnWidth = 25;
            ws.Columns[15].ColumnWidth = 25;
            ws.Columns[16].ColumnWidth = 25;
            ws.Columns[17].ColumnWidth = 25;
            ws.Columns[18].ColumnWidth = 25;
            ws.Columns[19].ColumnWidth = 25;
            ws.Columns[20].ColumnWidth = 25;
            ws.Columns[21].ColumnWidth = 25;
            ws.Columns[22].ColumnWidth = 25;

            ws.Cells[1, 1] = "Förnamn";
            ws.Cells[1, 2] = "Efternamn";
            ws.Cells[1, 3] = "Personnummer";
            ws.Cells[1, 4] = "Gatuadress";
            ws.Cells[1, 5] = "Postnummer";
            ws.Cells[1, 6] = "Ort";
            ws.Cells[1, 7] = "Telefonnummer mobil";
            ws.Cells[1, 8] = "Telefonnummer bostad";
            ws.Cells[1, 9] = "Email1";
            ws.Cells[1, 10] = "Email2";
            ws.Cells[1, 11] = "Anummer för såld BF";
            ws.Cells[1, 12] = "Utskrifsdatum";

            ws.Cells[4, 14] = "Kontakt Datum:";
            ws.Cells[5, 14] = "Utfall:";
            ws.Cells[6, 14] = "Säljare:";
            ws.Cells[7, 14] = "Agentur:";
            ws.Cells[8, 14] = "Notering för säljare";
            ws.Cells[4, 15] = "";
            ws.Cells[5, 15] = "";
            ws.Cells[6, 15] = "";
            ws.Cells[7, 15] = "";
            ws.Cells[8, 15] = "";

            #endregion

            for (int i = 0; i < prospekt.Count; i++)
            {
                ws.Cells[2 + i, 1] = prospekt[i].fNamn;
                ws.Cells[2 + i, 2] = prospekt[i].eNamn;
                ws.Cells[2 + i, 3] = prospekt[i].persNr;
                ws.Cells[2 + i, 4] = prospekt[i].gatuAdress;
                ws.Cells[2 + i, 5] = prospekt[i].postNr;
                ws.Cells[2 + i, 6] = prospekt[i].ort;
                ws.Cells[2 + i, 7] = prospekt[i].telNrMobil;
                ws.Cells[2 + i, 8] = prospekt[i].telNrBostad;
                ws.Cells[2 + i, 9] = prospekt[i].email1;
                ws.Cells[2 + i, 10] = prospekt[i].email2;
                ws.Cells[2 + i, 11] = prospekt[i].agenturNr;
                ws.Cells[2 + i, 12] = DateTime.Now;

            }

        }


        #endregion

        // Visar listan
        private void btnVisa_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bm.VisaFöretagsansökanFörsäkringstagare();
        }

        // Klick för att komma till popupp med möjlighet att redigera värden
        private void btnRedigera_Click(object sender, EventArgs e)
        {
            try
            {
                FormRedigeraFöretagsansökan nyFormRedigeraFöretagsansökan = new FormRedigeraFöretagsansökan();
                nyFormRedigeraFöretagsansökan.tbFöretagsansökningsID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbAgenturnummer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbOrgnr.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbFöretagsnamn.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbGatuadress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbOrt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbPostnr.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbFörnamn.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbEfternamn.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbTelnr.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbEpost.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbFaxnr.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbFörsäkringsbolag.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                nyFormRedigeraFöretagsansökan.cbFörsäkringstyp.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                nyFormRedigeraFöretagsansökan.dtpBegynnelsedatum.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                nyFormRedigeraFöretagsansökan.dtpFörfallodag.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                nyFormRedigeraFöretagsansökan.cbBetalningsform.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbPremie.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                nyFormRedigeraFöretagsansökan.tbAnteckning.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();

                nyFormRedigeraFöretagsansökan.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Försök igen. Välj en befintlig i rutan!");
            }

        }
        // Söker i listan
        private void btnSök_Click(object sender, EventArgs e)
        {

            long orgNr = 0;
            string FöretagsNamn = "";
            try
            {
                orgNr = long.Parse(tbSök.Text);
            }

            catch
            {
                FöretagsNamn = tbSök.Text;
            }

            dataGridView1.DataSource = bm.SökaFöretagsansökanFörsäkringstagare(orgNr, FöretagsNamn);
        }

        // Öppnar fönster för att skapa en försäkring
        private void btnSkapaFörsäkring_Click(object sender, EventArgs e)
        {
            try
            {
                FormSkapaFörsäkring nyFormSkapaFörsäkring = new FormSkapaFörsäkring();
                nyFormSkapaFörsäkring.tbAnsökningsId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                nyFormSkapaFörsäkring.tbAgenturnr.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                nyFormSkapaFörsäkring.tbFöretagsnamn.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                nyFormSkapaFörsäkring.tbOrgnr.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                nyFormSkapaFörsäkring.tbFörnamn.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nyFormSkapaFörsäkring.tbEfternamn.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                nyFormSkapaFörsäkring.tbGatuadress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                nyFormSkapaFörsäkring.tbOrt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                nyFormSkapaFörsäkring.tbPostnr.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                nyFormSkapaFörsäkring.tbTelnr.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                nyFormSkapaFörsäkring.tbEpost.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                nyFormSkapaFörsäkring.tbFaxnr.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                nyFormSkapaFörsäkring.tbFörsäkringsbolag.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                nyFormSkapaFörsäkring.cbFörsäkringstyp.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                nyFormSkapaFörsäkring.tbPremie.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                nyFormSkapaFörsäkring.cbBetalningsform.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                nyFormSkapaFörsäkring.dtpBegynnelsedatum.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                nyFormSkapaFörsäkring.dtpFörfallodag.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                nyFormSkapaFörsäkring.tbAnteckning.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                nyFormSkapaFörsäkring.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Försök igen. Välj en befintlig i rutan!");
            }

        }


    }
}
