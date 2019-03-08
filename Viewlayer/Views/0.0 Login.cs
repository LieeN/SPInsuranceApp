using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Viewlayer.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            

        }


        // Kontrollerar de inskriva uppgifterna med databasen och tillåter passering om dessa stämmer
        public void button1_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            
            if(string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Skriv in användaruppgifter.");
                return;

            }


            // Konverterar string i textbox1 till en int och utför ett metod anrop för att kontrollera att användaruppgifterna stämmer
            int id = int.Parse(textBox1.Text.Trim());
            BusinessLayer.clsAnvändarNamn.AnställningsId = id;
            string namn = BusinessLayer.clsAnvändarNamn.fNamn;
            if(!BusinessLayer.clsLoginKontroll.IsValid(id, textBox2.Text))
            {
                MessageBox.Show("Felaktig användarnamn och/eller lösenord. Försök igen eller kontakta admin.");
            }
            if (BusinessLayer.clsLoginKontroll.IsValid(id, textBox2.Text))
            {
                BusinessLayer.clsAnvändarNamn an = new BusinessLayer.clsAnvändarNamn();
                BusinessLayer.clsBehörighet bl = new BusinessLayer.clsBehörighet();
                
                bl.användarBehörighet(id);
                bl.Inloggad(id);
                an.AnvändarNamn(id);
                var huvudmeny = new FormHuvudMeny();
                MessageBox.Show("Användare: " + BusinessLayer.clsAnvändarNamn.fNamn +  "\n"  + "Behörighet: " + BusinessLayer.clsBehörighet.Behörighet);
                


                huvudmeny.Show();
            this.Hide();
            }

        }

        // Stänger nuvarande fönster
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
