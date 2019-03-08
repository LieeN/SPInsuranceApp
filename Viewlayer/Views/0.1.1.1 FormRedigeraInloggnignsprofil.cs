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
    public partial class FormRedigeraInloggnignsprofil : Form
    {
        FormInloggningsProfil _FormInloggningsProfil;
        public FormRedigeraInloggnignsprofil(FormInloggningsProfil FormInloggningsProfil)
        {
            InitializeComponent();
            _FormInloggningsProfil = FormInloggningsProfil;
        }
        BusinessManager bm = new BusinessManager();

        // Sparar de inskriva värderna till databasen
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                string fNamn = (clsAnvändarNamn.fNamn);

                var hämtad = bm.HämtaInloggningsprofil(fNamn);

                int ID = int.Parse(tbanställningsID.Text);

                Personal nyPersonal = new Personal()
                {

                    agenturNr = int.Parse(tbagentnr.Text),
                    persNr = Convert.ToInt64(tbPersnr.Text),
                    eNamn = tbenamn.Text,
                    fNamn = tbfnamn.Text,
                    gatuAdress = tbgatuadr.Text,
                    ort = tbort.Text,
                    postNr = int.Parse(tbpostnr.Text),
                    tel1 = int.Parse(tbtelfonmo.Text),
                    tel2 = int.Parse(tbtelfonbo.Text),
                    email = tbepost.Text,
                    lösenord = tblösenord.Text,
                    skattesats = double.Parse(tbskattesats.Text),
                    anställningsId = int.Parse(tbanställningsID.Text)
                };

                bm.UppdateraMinProfil(ID, nyPersonal);
                _FormInloggningsProfil.UpdateUI();
                MessageBox.Show("Profilen är redigerad");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Felaktiga värden. Vänligen försök igen!");
            }

        }
    }
}

