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
    public partial class geografijaForma : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";



        public geografijaForma()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            progresBar.Value = 0;
            stripStatusLabela.Text = "Broj tacnih odgovora je: 0";
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            if (pomocKliknuta < 4)
            {
                switch (correctAnswer)
                {
                    case 1:
                        odgovor = button1.Text.Trim();
                        break;

                    case 2:
                        odgovor = button2.Text.Trim();
                        break;

                    case 3:
                        odgovor = button3.Text.Trim();
                        break;

                    case 4:
                        odgovor = button4.Text.Trim();
                        break;
                }


                MessageBox.Show("Tacan odgovor je: " + odgovor);
                pomocKliknuta++;
            }
            else
            {
                MessageBox.Show("Iskoristili ste pravo na pomoc!");
            }

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;

                stripStatusLabela.Text = "Broj tacnih odgovora: " + score;

            }




            progresBar.Value = questionNumber;

            if (questionNumber == totalQuestions)
            {




                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show(Form1.instance.textBoxIme.Text.Trim()+" zavrsili ste kviz!" + Environment.NewLine +
                                "Imate " + score + " tacnih odgovora!" + Environment.NewLine +
                                "Postotak vase tacnosti je " + percentage + " %" + Environment.NewLine +
                                "Kliknite Ok da biste ponovo igrali!"

                    );




                Form categoriesForm = new Categories();
                categoriesForm.Show();

                this.Hide();

                /* score = 0;
                 questionNumber = 0;

                 askQuestion(questionNumber);
                */
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {



            switch (qnum)
            {

                case 1:

                    pbSlika.Image = Properties.Resources.kina;
                    lbPitanje.Text = "Koliko vremenskih zona ima Kina?";

                    button1.Text = "1";
                    button2.Text = "3";
                    button3.Text = "5";
                    button4.Text = "7";

                    correctAnswer = 1;

                    break;
                case 2:
                    pbSlika.Image = Properties.Resources.najmanja;
                    lbPitanje.Text = "Koja je najmanja drzava na svijetu?";

                    button1.Text = "Luksemburg";
                    button2.Text = "Vatikan";
                    button3.Text = "Monako";
                    button4.Text = "Nauru";

                    correctAnswer = 2;

                    break;

                case 3:

                    pbSlika.Image = Properties.Resources.cccp;

                    lbPitanje.Text = "Koja drzava nije bila dio Sovjetskog Saveza?";

                    button1.Text = "Ukrajina";
                    button2.Text = "Gruzija";
                    button3.Text = "Rumunija";
                    button4.Text = "Turkmenistan";

                    correctAnswer = 3;

                    break;

                case 4:

                    pbSlika.Image = Properties.Resources.stepenice;

                    lbPitanje.Text = "U kom gradu se nalaze ``Spanske stepenice``?";

                    button1.Text = "Madridu";
                    button2.Text = "Rimu";
                    button3.Text = "Barseloni";
                    button4.Text = "Milanu";

                    correctAnswer = 2;

                    break;

                case 5:

                    pbSlika.Image = Properties.Resources.United_Kingdom;

                    lbPitanje.Text = "Koliko drzava cine Ujedinjeno Kraljevstvo?";

                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "5";
                    button4.Text = "6";

                    correctAnswer = 2;

                    break;

                case 6:

                    pbSlika.Image = Properties.Resources.rusija;

                    lbPitanje.Text = "Koliko vremenskih zona ima Rusija?";

                    button1.Text = "8";
                    button2.Text = "9";
                    button3.Text = "10";
                    button4.Text = "11";

                    correctAnswer = 4;

                    break;

                case 7:

                    pbSlika.Image = Properties.Resources.australija;

                    lbPitanje.Text = "Koji grad je glavni grad Australije?";

                    button1.Text = "Sydney";
                    button2.Text = "Canberra";
                    button3.Text = "Melbourne";
                    button4.Text = "Perth";

                    correctAnswer = 2;

                    break;

                case 8:

                    pbSlika.Image = Properties.Resources.zastava;

                    lbPitanje.Text = "Koliko zvjezdica ima na zastavi SAD-a?";

                    button1.Text = "49";
                    button2.Text = "50";
                    button3.Text = "51";
                    button4.Text = "52";

                    correctAnswer = 2;

                    break;

            }


        }

        private void geografijaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ans = MessageBox.Show("Zelite li napustiti kviz?", "Potvrdite napustanje igre", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
