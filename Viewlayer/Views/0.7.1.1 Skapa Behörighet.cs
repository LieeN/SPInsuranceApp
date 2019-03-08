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
    public partial class FormSkapaBehörighet : Form
    {
        public FormSkapaBehörighet()
        {
            InitializeComponent();
        }
        BusinessManager bm = new BusinessManager();

        // Sparar inskriva värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                Behörighet nyBehörighet = new Behörighet()
                {
                    behörighetsTyp = int.Parse(tbBehörighetstyp.Text)
                };

                Roll nyRoll = new Roll()
                {
                    rollNamn = tbRoll.Text
                };
                bm.SkapaBehörighet(nyBehörighet, nyRoll);
                MessageBox.Show("Behörighet är registrerad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }
    
        }
        // Stänger fönstret
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
