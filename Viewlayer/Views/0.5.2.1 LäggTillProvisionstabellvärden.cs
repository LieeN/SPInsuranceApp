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
    public partial class FormLäggTillProvisionstabellvärden : Form
    {
        public FormLäggTillProvisionstabellvärden()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();


        //Sparar inskriva värden till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            Provisionstabell nyProvisiontabell = new Provisionstabell()
            {
                totaltMinAckVärde = int.Parse(tbTMinA.Text),
                totaltMaxAckVärde = int.Parse(tbTMaxA.Text),
                provionsAndelVuxen = double.Parse(tbPAV.Text),
                provisionsAndelBarn = double.Parse(tbPAB.Text),
                period = tbPeriod.Text

            };

            bm.SkapaProvisionstabell(nyProvisiontabell);
            MessageBox.Show("Provisionsvärdet är nu registrerat");
            this.Close();
        }

        //Stänger ner nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLäggTillProvisionstabellvärden_Load(object sender, EventArgs e)
        {


        }
    }
}
