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
    public partial class popKulturaForma : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";

        public popKulturaForma()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel1.Text = "Broj tacnih odgovora je: 0";
        }

        
        private void popKulturaForma_FormClosing(object sender, FormClosingEventArgs e)
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


        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;

                toolStripStatusLabel1.Text = "Broj tacnih odgovora: " + score;

            }




            toolStripProgressBar1.Value = questionNumber;

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

                    pbSlika.Image = Properties.Resources.grammy;
                    lbPitanje.Text = "Ko je 2001. godine dobio Grammy-ja za najboljeg novog umjetnika?";

                    button1.Text = "Sam Smith";
                    button2.Text = "Amy Winehouse";
                    button3.Text = "Meghan Trainor";
                    button4.Text = "Alessia Cara";

                    correctAnswer = 2;

                    break;
                case 2:
                    pbSlika.Image = Properties.Resources.mariaj;
                    lbPitanje.Text = "Za koga se Mariah Carey udala 1993. godine?";

                    button1.Text = "Nick Cannon";
                    button2.Text = "James Packer";
                    button3.Text = "Tommy Mottola";
                    button4.Text = "Benny Medina";

                    correctAnswer = 3;

                    break;

                case 3:

                    pbSlika.Image = Properties.Resources.spice;

                    lbPitanje.Text = "Ko je najstariji clan grupe Spice girls?";

                    button1.Text = "Geri Halliwell";
                    button2.Text = "Mel B";
                    button3.Text = "Victoria Beckham";
                    button4.Text = "Emma Bunton";

                    correctAnswer = 1;

                    break;

                case 4:

                    pbSlika.Image = Properties.Resources.jack;

                    lbPitanje.Text = "Kako se zvao broj kapetana Jack-a Sparrow-a?";

                    button1.Text = "The Maurader";
                    button2.Text = "The Jolly Roger";
                    button3.Text = "The Wyndlass";
                    button4.Text = "The Black Pearl";

                    correctAnswer = 4;

                    break;

                case 5:

                    pbSlika.Image = Properties.Resources.eelvis;

                    lbPitanje.Text = "Koliko je Grammy-ja osvojio Elvis Presley?";

                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "5";
                    button4.Text = "6";

                    correctAnswer = 1;

                    break;

                case 6:

                    pbSlika.Image = Properties.Resources.Harry;

                    lbPitanje.Text = "Kako su princ Herry i Meghan objavili da se povlace sa svojih duznosti u kraljevskoj porodici?";

                    button1.Text = "Kraljica je odrzala pres konferenciju";
                    button2.Text = "Putem drustvenih mreza ";
                    button3.Text = "Kraljica je obavijetila gledaoce putem TV ekrana";
                    button4.Text = "Tokom turneje po Africi";

                    correctAnswer = 2;

                    break;

                case 7:

                    pbSlika.Image = Properties.Resources.vogue;

                    lbPitanje.Text = "Ko je prvi muskarac koji se sam pojavio na naslovnici casopisa Vogue?";

                    button1.Text = "Timothée Chalamet";
                    button2.Text = "Michael B. Jordan";
                    button3.Text = "JZayn Malik";
                    button4.Text = "Harry Styles";

                    correctAnswer = 4;

                    break;

                case 8:

                    pbSlika.Image = Properties.Resources.john;

                    lbPitanje.Text = "Snimajuci koji spot je John Legend upoznao svoju zenu Chrissy Teigen?";

                    button1.Text = "Stereo";
                    button2.Text = "All of me";
                    button3.Text = "Tonight";
                    button4.Text = "Love me now";

                    correctAnswer = 1;

                    break;

            }


        }

    }
}
