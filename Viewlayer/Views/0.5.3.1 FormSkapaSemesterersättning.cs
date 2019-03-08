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
    public partial class FormSkapaSemesterersättning : Form
    {
        public FormSkapaSemesterersättning()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        // Sparar de inskriva värdena till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                Semesterersättning nySemesterersättning = new Semesterersättning()
                {
                    år = tbÅr.Text,
                    avdrag = double.Parse(tbAvdrag.Text),
                    procentsats = double.Parse(tbProcentsats.Text),
                };
                bm.SkapaSemesterersättning(nySemesterersättning);
                MessageBox.Show("Semesterersättningsvärdet är sparat");
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
    }
}
