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
    public partial class FormLäggTillPersonal : Form
    {
        public FormLäggTillPersonal()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();


        // Sparar det inskriva värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                string rollNamn = cbRoll.Text;

                Personal nyPersonal = new Personal()
                {
                    fNamn = tbFNnamn.Text,
                    eNamn = tbENamn.Text,
                    persNr = long.Parse(tbPersNr.Text),
                    agenturNr = int.Parse(tbAgenturNr.Text),
                    skattesats = double.Parse(tbSkattesats.Text),
                    postNr = int.Parse(tbPostNr.Text),
                    gatuAdress = tbGatuAdress.Text,
                    ort = tbOrt.Text,
                    tel1 = int.Parse(tbTelNrMobil.Text),
                    tel2 = int.Parse(tbTelNrBostad.Text),
                    email = tbEpost.Text,
                    lösenord = tbLösenord.Text
                };
                bm.SkapaPersonal(rollNamn, nyPersonal);
                MessageBox.Show("Profilen är skapad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }
           
        }

        //Stänger ner nuvarande fönstret
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLäggTillPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rollTabell.RollSet' table. You can move, or remove it, as needed.
            this.rollSetTableAdapter.Fill(this.rollTabell.RollSet);

        }
    }
}
