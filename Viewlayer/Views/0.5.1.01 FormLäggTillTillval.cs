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
    public partial class FormLäggTillTillval : Form
    {
        FormFörsäkringstypTillval _FormFörsäkringstypTillval;
        public FormLäggTillTillval(FormFörsäkringstypTillval FormFörsäkringstypTillval)
        {
            InitializeComponent();
            _FormFörsäkringstypTillval = FormFörsäkringstypTillval;
        }

        BusinessManager bm = new BusinessManager();

        // Stänger nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sparar inskriva värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                Tillval nyTillval = new Tillval()
                {
                    tillvalsNamn = tbTillValsNamn.Text,
                    datum = dtpDatum.Value,
                    ackVärdeVariabel = double.Parse(tbAckVärdeVariabel.Text)
                };
                MessageBox.Show("Tillvalet har lagts till");
                bm.SkapaTillval(nyTillval);
                _FormFörsäkringstypTillval.UpdateUI();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }      

        }
        
    }
}
