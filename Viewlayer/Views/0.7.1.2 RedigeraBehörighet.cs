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
    public partial class FormRedigeraBehörighet : Form
    {
        public FormRedigeraBehörighet()
        {
            InitializeComponent();
        }

        BusinessManager bm = new BusinessManager();

        // Sparar inskriva värdet till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(tbUppdateraID.Text);
                int BehörighetsTyp = int.Parse(tbUppdateraBehörighet.Text);
                string RollNamn = tbRoll.Text;
                bm.UppdateraBehörighet(ID, BehörighetsTyp, RollNamn);
                MessageBox.Show("Behörighet är redigerad");
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
