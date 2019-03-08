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
    public partial class FormLäggTillTillvalsbelopp : Form
    {
        public FormLäggTillTillvalsbelopp()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        //Sparar inskriva värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                string Tillval = tbFormTillvalFörsäkringsId.Text;
                TillvalGrundbelopp nyTillvalsgrundbelopp = new TillvalGrundbelopp()
                {
                    grundBelopp = int.Parse(tbFormTillvalGrundbelopp.Text)
                };
                bm.SkapaTillvalsbelopp(nyTillvalsgrundbelopp, Tillval);
                MessageBox.Show("Tillvalsbelopp har lagts till");
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
