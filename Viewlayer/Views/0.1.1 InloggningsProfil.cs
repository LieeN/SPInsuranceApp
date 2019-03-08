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
using Microsoft.Office.Interop.Excel;

namespace Viewlayer.Views
{
    public partial class FormInloggningsProfil : Form
    {
        BusinessManager bm = new BusinessManager();
        public FormInloggningsProfil()
        {
            InitializeComponent();
            labelAnvändare.Text = ("Användare: " + clsAnvändarNamn.fNamn).ToUpper();
            användare.Enabled = false;
            // Behörighetskontroller
            if (BusinessLayer.clsBehörighet.Behörighet != 3)
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

            //Hämtar användaruppgifter från inloggades data             
            tbfnamnRUBRIK.Text = (clsAnvändarNamn.fNamn);
            string fNamn = tbfnamnRUBRIK.Text;
            var hämtad = bm.HämtaInloggningsprofil(fNamn);

            //Visar hämtade användaruppgifter
            tbPersnr.Text = Convert.ToInt64(hämtad[0].persNr).ToString();
            tbfnamn.Text = hämtad[0].fNamn;
            tbenamn.Text = hämtad[0].eNamn;
            tbgatuadr.Text = hämtad[0].gatuAdress;
            tbpostnr.Text = Convert.ToInt32(hämtad[0].postNr).ToString();
            tbort.Text = hämtad[0].ort;
            tbanställningsID.Text = Convert.ToUInt32(hämtad[0].anställningsId).ToString();
            tbagentnr.Text = Convert.ToUInt32(hämtad[0].agenturNr).ToString();
            tbtelfonmo.Text = Convert.ToUInt32(hämtad[0].tel1).ToString();
            tbtelfonbo.Text = Convert.ToUInt32(hämtad[0].tel2).ToString();
            tbepost.Text = hämtad[0].email;
            tbskattesats.Text = Convert.ToDouble(hämtad[0].skattesats).ToString();
            tblösenord.Text = hämtad[0].lösenord;
            tblösenord.PasswordChar = '*';
        }

        // Uppdaterar rutan med data
        public void UpdateUI()
        {
            tbfnamnRUBRIK.Text = (clsAnvändarNamn.fNamn);
            string fNamn = tbfnamnRUBRIK.Text;
            var hämtad = bm.HämtaInloggningsprofil(fNamn);

            tbfnamnRUBRIK.Text = hämtad[0].fNamn + " " + hämtad[0].eNamn;
            tbPersnr.Text = Convert.ToInt64(hämtad[0].persNr).ToString();
            tbfnamn.Text = hämtad[0].fNamn;
            tbenamn.Text = hämtad[0].eNamn;
            tbgatuadr.Text = hämtad[0].gatuAdress;
            tbpostnr.Text = Convert.ToInt32(hämtad[0].postNr).ToString();
            tbort.Text = hämtad[0].ort;
            tbanställningsID.Text = Convert.ToUInt32(hämtad[0].anställningsId).ToString();
            tbagentnr.Text = Convert.ToUInt32(hämtad[0].agenturNr).ToString();
            tbtelfonmo.Text = Convert.ToUInt32(hämtad[0].tel1).ToString();
            tbtelfonbo.Text = Convert.ToUInt32(hämtad[0].tel2).ToString();
            tbepost.Text = hämtad[0].email;
            tbskattesats.Text = Convert.ToDouble(hämtad[0].skattesats).ToString();
            tblösenord.Text = hämtad[0].lösenord;
            tblösenord.PasswordChar = '*';
        }

        #region Menystrip

        // Menystrip 1. Öppnar huvudmeny via menynstripen samt stänger ner nuvarande ruta
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

        // Menystrip - 2.1 Öppnar företagsregister via menynstripen samt stänger ner nuvarande ruta
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

       

        // Läser in data till textboxes
        private void btnRedigera_Click(object sender, EventArgs e)
        {
            FormRedigeraInloggnignsprofil nyFormredigeraInloggningsprofil = new FormRedigeraInloggnignsprofil(this);

            nyFormredigeraInloggningsprofil.tbPersnr.Text = tbPersnr.Text.ToString();
            nyFormredigeraInloggningsprofil.tbfnamn.Text = tbfnamn.Text.ToString();
            nyFormredigeraInloggningsprofil.tbenamn.Text = tbenamn.Text.ToString();
            nyFormredigeraInloggningsprofil.tbgatuadr.Text = tbgatuadr.Text.ToString();
            nyFormredigeraInloggningsprofil.tbpostnr.Text = tbpostnr.Text.ToString();
            nyFormredigeraInloggningsprofil.tbort.Text = tbort.Text.ToString();
            nyFormredigeraInloggningsprofil.tbanställningsID.Text = tbanställningsID.Text.ToString();
            nyFormredigeraInloggningsprofil.tbagentnr.Text = tbagentnr.Text.ToString();
            nyFormredigeraInloggningsprofil.tbtelfonmo.Text = tbtelfonmo.Text.ToString();
            nyFormredigeraInloggningsprofil.tbtelfonbo.Text = tbtelfonbo.Text.ToString();
            nyFormredigeraInloggningsprofil.tbepost.Text = tbepost.Text.ToString();
            nyFormredigeraInloggningsprofil.tbskattesats.Text = tbskattesats.Text.ToString();
            nyFormredigeraInloggningsprofil.tblösenord.Text = tblösenord.Text.ToString();
            nyFormredigeraInloggningsprofil.Show();
        }




        #endregion

    }

}
