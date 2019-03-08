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
using DataLayer;

namespace Viewlayer.Views
{
    public partial class FormLäggTillGrundbelopp : Form
    {
        public FormLäggTillGrundbelopp()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        //Sparar inskriva värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                string FörsäkringsTyp = tbFörsäkringsTyp.Text;
                Grundbelopp nyGrundbelopp = new Grundbelopp()
                {
                    grundBelopp = int.Parse(tbGrundbelopp.Text),
                    datum = dtpDatum.Value,
                    ackVärde = double.Parse(tbAckVärde.Text)
                };
                bm.SkapaGrundbelopp(nyGrundbelopp, FörsäkringsTyp);
                MessageBox.Show("Grundbelopp har lagts till");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }
            
        }

        //Stänger ner inskriva fönstret
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
