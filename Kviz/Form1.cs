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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox textBoxIme;

        public Form1()
        {
            InitializeComponent();
            SetNameLabel();
            instance = this;
            textBoxIme = tbIme;
        }

        public void SetNameLabel()
        {
            lbIme.Text = $"Ime igraca ({tbIme.Text.Length}/{tbIme.MaxLength})";
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            SetNameLabel();
        }

        private void About_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

       


        private void btnNapustiKviz_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Zelite li napustiti kviz?", "Potvrdite napustanje igre", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* if (DialogResult.No == MessageBox.Show("Zelite li napustiti kviz?", "Potvrdite napustanje igre", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }*/
          
        }

        private void btnZapocniIgru_Click(object sender, EventArgs e)
        {
            if (tbIme.Text.Length > 2)
            {
                btnZapocniIgru.Enabled = true;
                string player = tbIme.Text;
                MessageBox.Show("Zdravo " + player + "! Zapocnimo kviz!");

                Form categoriesForm = new Categories();
                categoriesForm.Show();
                this.Hide();


                this.timer1.Enabled = false;
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Ime koje ste unijeli je prekratko! Ime mora sadrzati bar 3 znaka!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            //this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1);
            progressBar2.PerformStep();

            

            if (progressBar2.Value==200)
            {
                timer1.Enabled = false;

                Application.Exit();
                /*Form categoriesForm = new Categories();
                categoriesForm.Show();
                this.Hide();*/
            }

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 200;
            progressBar2.Step = 1;
            timer1.Start();
        }

        private void tbIme_Enter(object sender, EventArgs e)
        {

        }
    }
}
