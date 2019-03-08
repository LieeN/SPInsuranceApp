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
    public partial class FormLäggTillFörsäkringsTyp : Form
    {
        FormFörsäkringstypTillval _FormFörsäkringstypTillval;

        public FormLäggTillFörsäkringsTyp(FormFörsäkringstypTillval FormFörsäkringstypTillval)
        {
            InitializeComponent();
            _FormFörsäkringstypTillval = FormFörsäkringstypTillval;
        }

        BusinessManager bm = new BusinessManager();


        //Klick för att spara inskriva värderna till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                FörsäkringsTyp nyFörsäkringstyp = new FörsäkringsTyp()
                {
                    försäkringsTyp = tbFörsäkringstyp.Text
                };

                bm.SkapaFörsäkringstyp(nyFörsäkringstyp);
                MessageBox.Show("Försäkringstypen är registrerad");
                _FormFörsäkringstypTillval.UpdateUI();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }


        }

        // Stänger nuvarande fönster
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
