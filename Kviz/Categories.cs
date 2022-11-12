using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();

            lbImeTakmicara.Text= Form1.instance.textBoxIme.Text.Trim()+",";
        }

        private void btnNapusti_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Zelite li napustiti kviz?", "Potvrdite napustanje igre", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            Form historyForm = new istorijaForma();
            Form geographyForm = new geografijaForma();
            Form filmsForm = new filmoviForma();
            Form sportsForm = new sportForma();
            Form musicForm = new muzikaForma();
            Form popCultureForm = new popKulturaForma();

            if (rbFilmovi.Checked)
            {
                filmsForm.Show();
                this.Hide();
            }

            else if (rbMuzika.Checked)
            {
                musicForm.Show();
                this.Hide();
            }

            else if (rbSport.Checked)
            {
                sportsForm.Show();
                this.Hide();
            }

            else if (rbPopKultura.Checked)
            {
                popCultureForm.Show();
                this.Hide();
            }

            else if (rbGeografija.Checked)
            {
                geographyForm.Show();
                this.Hide();
            }

            else if (rbIstorija.Checked)
            {
                historyForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Izaberite kategoriju!");
            }
        }

        private void Categories_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (DialogResult.No == MessageBox.Show("Zelite li napustiti kviz?", "Potvrdite napustanje igre", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
            else*/
            {
                Application.Exit();
            }
        }
    }
}
