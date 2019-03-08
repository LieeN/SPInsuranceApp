using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataLayer;
using BusinessLayer;
using System.Data.Entity.Validation;
using System.Diagnostics;


namespace Viewlayer.Views
{
    public partial class FormProvision : Form
    {
        public FormProvision()
        {
            InitializeComponent();
            // Visar namnet på den som är inloggad
            användare.Text = ("Användare: " + clsAnvändarNamn.fNamn).ToUpper();
            // Behörighetskontroller
            if (clsBehörighet.Behörighet != 3)
            {
                toolStripMenuItem17.Enabled = false;
                provisionToolStripMenuItem.Enabled = false;
                visaProvsionsvärdetabellToolStripMenuItem.Enabled = false;
                visaSemesterersättningToolStripMenuItem.Enabled = false;
                behörighetToolStripMenuItem.Enabled = false;

                visaSemesterersättningToolStripMenuItem.Enabled = false;

                prospektToolStripMenuItem.Enabled = false;
            }
            if (clsBehörighet.Behörighet > 3)
            {
                toolStripMenuItem21.Enabled = false;
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
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
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
        private void toolStripMenuItem20_Click(object sender, EventArgs e)
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

        // Laddar in datasets
        private void FormProvision_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasourceProvision.PersonalSet' table. You can move, or remove it, as needed.
            this.personalSetTableAdapter.Fill(this.datasourceProvision.PersonalSet);
        }

        // Exporterar alla värden från textboxen till excel
        private void btnExportera_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            xla.Visible = true;

            ws.Cells[1, 4] = "Provisioner";

            ws.Cells[8, 1] = "Ba Summa Ackvärde";
            ws.Cells[9, 1] = "Vu Summa Ackvärde";
            ws.Cells[10, 1] = "Summa ackvärde";
            ws.Cells[12, 1] = "Liv Summa ackvärde";
            ws.Cells[14, 1] = "Övrig provision";
            ws.Cells[15, 1] = "Semesterersättning";
            ws.Cells[17, 1] = "Preliminär skatt";
            ws.Cells[19, 1] = "Insättning på bankkonto den:";
            ws.Cells[10, 6] = "Prov So";
            ws.Cells[12, 6] = "Prov Liv";
            ws.Cells[14, 6] = "Prov Övrigt";
            ws.Cells[15, 6] = "Semesterers:";
            ws.Cells[16, 6] = "Summa prov:";
            ws.Cells[17, 6] = "Avgår skatt";
            ws.Cells[19, 6] = "Att utbetala";




            ws.Cells[2, 1] = tbNamn.Text;
            ws.Cells[3, 1] = tbadress.Text;
            ws.Cells[4, 1] = tbpostnummer.Text;

            ws.Cells[8, 4] = tbBasummaackvärde.Text;
            ws.Cells[9, 4] = tbVusummaackvärde.Text;
            ws.Cells[10, 4] = tbSummaackvärde.Text;
            ws.Cells[12, 4] = tbLivsummackvärde.Text;
            ws.Cells[14, 4] = tbÖvrigprovision.Text;
            ws.Cells[15, 4] = tbSemesterersättning.Text;
            ws.Cells[17, 4] = tbPremilinärskatt.Text;
            ws.Cells[19, 4] = tbInsättning.Text;
            ws.Cells[10, 8] = tbProvso.Text;
            ws.Cells[12, 8] = tbProvliv.Text;
            ws.Cells[14, 8] = tbProvövrigt.Text;
            ws.Cells[15, 8] = tbSemesterersättning.Text;
            ws.Cells[16, 8] = tbSummaprov.Text;
            ws.Cells[17, 8] = tbAvgårskatt.Text;
            ws.Cells[19, 8] = tbAttutbetala.Text;
        }

        // Räknar ut provisionen
        private void btnVälj_Click(object sender, EventArgs e)
        {
            try
            {
                //Deklarerar variabler beroende på comboboxes
                string fNamn = cbSäljare.Text;
                int Year = int.Parse(cbÅr.Text);
                int Month = int.Parse(cbMånad.Text);
                var säljare = bm.HämtaSäljare(fNamn);
                string Year1 = cbÅr.Text;
                var skattesats = bm.HämtaSkattesats(fNamn);

                //Hämtar och lägger in säljarens uppgifter beroende på vald i comboboxen
                tbNamn.Text = säljare[0].fNamn + " " + säljare[0].eNamn;
                tbadress.Text = säljare[0].gatuAdress;
                tbpostnummer.Text = Convert.ToInt32(säljare[0].postNr).ToString() + " " + (säljare[0].ort);

                //Hämtar barn och vuxen ackvärde till textboxes och adderar sedan dessa in i en textbox
                var baAckvärde = bm.HämtaBaAckvärde(Year, Month, fNamn);
                var vuAckvärde = bm.HämtaVuAckvärde(Year, Month, fNamn);
                var semErsättningAvdrag = bm.HämtaSemesterersättningAvdrag(Year1);
                tbBasummaackvärde.Text = Convert.ToInt32(baAckvärde).ToString();
                tbVusummaackvärde.Text = Convert.ToInt32(vuAckvärde).ToString();
                tbSummaackvärde.Text = Convert.ToInt32((Convert.ToDouble(baAckvärde) + Convert.ToDouble(vuAckvärde))).ToString();

                //Hämtar provisionsvärden för vuxen och barn för uträkningen av provso
                var provVariabelBarn = bm.HämtaProvisionVariablerBarn(double.Parse(tbSummaackvärde.Text), Convert.ToString(Year));
                var provVariabelVuxen = bm.HämtaProvisionVariablerVuxen(double.Parse(tbSummaackvärde.Text), Convert.ToString(Year));
                tbProvso.Text = Convert.ToInt32((Convert.ToDouble(tbBasummaackvärde.Text) * Convert.ToDouble(provVariabelBarn) + (Convert.ToDouble(tbVusummaackvärde.Text) * Convert.ToDouble(provVariabelVuxen))) * Convert.ToDouble(1 - Convert.ToDouble(semErsättningAvdrag))).ToString();

                //Hämta summa ackvärde och grundbelopp för att sedan räkna ut dessa i en textbox (livssummavärde) och sedan in i en annan textbox (provliv)
                var livsSummaAckvärde = bm.HämtaLivsSummaAckvärde(Year, Month, fNamn);
                var livsSummaGrundbelopp = bm.HämtaLivsSummaGrundbelopp(Year, Month, fNamn);
                tbLivsummackvärde.Text = Convert.ToInt32(Convert.ToInt32(livsSummaGrundbelopp)).ToString();
                tbProvliv.Text = Convert.ToInt32(Convert.ToInt32(livsSummaGrundbelopp) * (Convert.ToDouble(livsSummaAckvärde)) * (Convert.ToDouble(1 - semErsättningAvdrag))).ToString();

                //Hämta provisionsbelopp för privat och företag för att sedan räkna ut övrig provision baserade på de tidigare värdena i textboxen
                var provÖvrigtProvisionsbeloppPrivat = bm.HämtaProvÖvrigtSummaProvisionsbeloppPrivat(Year, Month, fNamn);
                var provÖvrigtProvisionsbeloppFöretag = bm.HämtaProvÖvrigtSummaProvisionsbeloppFöretag(Year, Month, fNamn);
                tbÖvrigprovision.Text = (Convert.ToInt32(provÖvrigtProvisionsbeloppPrivat) + Convert.ToInt32(provÖvrigtProvisionsbeloppFöretag)).ToString();
                tbProvövrigt.Text = Convert.ToInt32(Convert.ToDouble(tbÖvrigprovision.Text) * Convert.ToDouble(1 - Convert.ToDouble(semErsättningAvdrag))).ToString();

                //Hämtar semestersats för att räkna ut semesterersättningen
                var semErsättningSats = bm.HämtaSemesterersättningSats(Year1);
                tbSemestersats.Text = Convert.ToDouble(Convert.ToDouble(semErsättningSats)).ToString();
                tbSemesterersättning.Text = Convert.ToInt32((Convert.ToDouble(tbProvso.Text) + (Convert.ToDouble(tbProvliv.Text) + (Convert.ToDouble(tbProvövrigt.Text)))) * Convert.ToDouble(tbSemestersats.Text)).ToString();

                //Beräknar textboxes beroende på värdena i föregående textboxes
                tbSummaprov.Text = Convert.ToInt32(Convert.ToDouble(tbProvso.Text) + (Convert.ToDouble(tbProvliv.Text) + (Convert.ToDouble(tbProvövrigt.Text) + (Convert.ToDouble(tbSemesterersättning.Text))))).ToString();
                tbPremilinärskatt.Text = Convert.ToDouble(skattesats).ToString();
                tbAvgårskatt.Text = Convert.ToInt32(Convert.ToDouble(tbSummaprov.Text) * Convert.ToDouble(tbPremilinärskatt.Text)).ToString();
                tbAttutbetala.Text = Convert.ToInt32(Convert.ToDouble(tbSummaprov.Text) - (Convert.ToDouble(tbAvgårskatt.Text))).ToString();

        }
            catch (Exception)
            {
                MessageBox.Show("Välj en giltig period!");
            }
}
    }
}
