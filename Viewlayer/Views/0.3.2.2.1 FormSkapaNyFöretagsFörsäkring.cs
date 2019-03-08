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
    public partial class FormSkapaNyFöretagsFörsäkring : Form
    {
        public FormSkapaNyFöretagsFörsäkring()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        // 
        private void btnSpara_Click(object sender, EventArgs e)
        {

            int ID = int.Parse(tbFörsäkringsID.Text);
            Försäkring nyFörsäkring = new Försäkring()
            {
                försäkringsNr = int.Parse(tbFörsäkringsNr.Text),
                betald = cbBetald.Text,
                provisionsbelopp = int.Parse(tbProvisionsbelopp.Text),

            };
            bm.SkapaFörsäkring(ID, nyFörsäkring);
        }
        // Stänger nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
