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
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Diagnostics;


namespace Viewlayer.Views
{
    public partial class FormRedigeraFöretagsprofil : Form
    {
        public FormRedigeraFöretagsprofil()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();


        //Sparar de redigerade värderna i databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbID.Text);
                FörsäkringstagareFöretag nyFörsäkringstagareFöretag = new FörsäkringstagareFöretag()
                {
                    företagsNamn = tbFöretag.Text,
                    gatuAdress = tbGatuadr.Text,
                    postNr = int.Parse(tbPostnr.Text),
                    ort = tbOrt.Text,
                    kFNamn = tbKFNamn.Text,
                    kENamn = tbKENamn.Text,
                    tel1 = int.Parse(tbTel.Text),
                    email1 = tbEpost.Text,
                    faxNr = int.Parse(tbFax.Text),
                    orgNr = long.Parse(tbOrgNr.Text)
                };
                bm.UppdateraFöretagsprofil(ID, nyFörsäkringstagareFöretag);
                MessageBox.Show("Profilen är redigerad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }
            
        }


        //Stänger ner nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
