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
    public partial class sportForma : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";


        public sportForma()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            progresBar.Value = 0;
            stripStatusLabela.Text = "Broj tacnih odgovora je: 0";
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

                Form pocetnaForma = new Form1();

                MessageBox.Show(Form1.instance.textBoxIme.Text.Trim() + " zavrsili ste kviz!" + Environment.NewLine +
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

                    pbSlika.Image = Properties.Resources.fifa;
                    lbPitanje.Text = "Koliko cesto se odrzava FIFA Svjetski Kup?";

                    button1.Text = "Svake 2 godine";
                    button2.Text = "Svake 3 godine";
                    button3.Text = "Svake 4 godine";
                    button4.Text = "Svakih 5 godine";

                    correctAnswer = 3;

                    break;
                case 2:
                    pbSlika.Image = Properties.Resources.medal;
                    lbPitanje.Text = "Koji ima najvise osvojenih zlatnih olimijskih medalja?";

                    button1.Text = "Larisa Latynina";
                    button2.Text = "Mark Spitz";
                    button3.Text = "Michael Phelps";
                    button4.Text = "Saina Nehwal";

                    correctAnswer = 3;

                    break;

                case 3:

                    pbSlika.Image = Properties.Resources.bolt;

                    lbPitanje.Text = "Koliko iznosi svjetski rekord koji je postavio Usain Bolt za trcanje na 100m?";

                    button1.Text = "14.35 s";
                    button2.Text = "9.58 s";
                    button3.Text = "9.05 s";
                    button4.Text = "10.12 s";

                    correctAnswer = 2;

                    break;

                case 4:

                    pbSlika.Image = Properties.Resources.ali;

                    lbPitanje.Text = "Kojim sportom se bavio Muhammad Ali?";

                    button1.Text = "Dizanje tegova";
                    button2.Text = "Plicanje";
                    button3.Text = "Karate";
                    button4.Text = "Boks";

                    correctAnswer = 4;

                    break;

                case 5:

                    pbSlika.Image = Properties.Resources.fifa;

                    lbPitanje.Text = "Kada je odrzan prvi FIFA Svjetski Kup?";

                    button1.Text = "1918";
                    button2.Text = "1930";
                    button3.Text = "1934";
                    button4.Text = "1935";

                    correctAnswer = 2;

                    break;

                case 6:

                    pbSlika.Image = Properties.Resources.cris;

                    lbPitanje.Text = "Koje godine se Cristiano Ronaldo pridruzio fudbalskom klubu Juventus?";

                    button1.Text = "2017";
                    button2.Text = "2018";
                    button3.Text = "2019";
                    button4.Text = "2020";

                    correctAnswer = 2;

                    break;

                case 7:

                    pbSlika.Image = Properties.Resources.cris;

                    lbPitanje.Text = "Kako glasi puno ime Criatiana Ronalda?";

                    button1.Text = "Cristiano Santos Ronaldo";
                    button2.Text = "Cristiano Ronaldo Santos Aveiro";
                    button3.Text = "Cristiano Ronaldo dos Santos Aveiro";
                    button4.Text = "Cristiano dos Ronaldo";

                    correctAnswer = 3;

                    break;

                case 8:

                    pbSlika.Image = Properties.Resources.kobe;

                    lbPitanje.Text = "Za koji klub je igrao Kobe Bryant?";

                    button1.Text = "Chicago Bulls";
                    button2.Text = "Golden State Warriors";
                    button3.Text = "Miami Heat";
                    button4.Text = "Los Angeles Lakers";

                    correctAnswer = 4;

                    break;

            }


        }

        private void sportForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Zelite li napustiti kviz?", "Potvrdite napustanje igre", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
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
    }
}
