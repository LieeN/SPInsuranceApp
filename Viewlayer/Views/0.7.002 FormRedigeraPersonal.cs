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
    public partial class FormRedigeraPersonal : Form
    {
        public FormRedigeraPersonal()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        // Sparar de inskriva värdena till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbAnställningsID.Text);
                string RollNamn = cbRoll.Text;
                Personal nyPersonal = new Personal()
                {
                    agenturNr = int.Parse(tbAgenturNr.Text),
                    persNr = long.Parse(tbPersNr.Text),
                    eNamn = tbENamn.Text,
                    skattesats = double.Parse(tbSkattesats.Text),
                    fNamn = tbFNnamn.Text,
                    gatuAdress = tbGatuAdress.Text,
                    ort = tbOrt.Text,
                    postNr = int.Parse(tbPostNr.Text),
                    tel1 = int.Parse(tbTelNrMobil.Text),
                    tel2 = int.Parse(tbTelNrBostad.Text),
                    email = tbEpost.Text,
                    lösenord = tbLösenord.Text,
                };
                bm.UppdateraPersonal(ID, nyPersonal, RollNamn);

                MessageBox.Show("Profilen är redigerad");
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

        // Laddar in datasets
        private void FormRedigeraPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rollTabell.RollSet' table. You can move, or remove it, as needed.
            this.rollSetTableAdapter.Fill(this.rollTabell.RollSet);

        }
    }
}
