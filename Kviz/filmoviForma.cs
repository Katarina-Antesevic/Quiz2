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
    public partial class filmoviForma : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";

        public filmoviForma()
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

            Form pocetnaForma = new Form1();

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show(Form1.instance.textBoxIme.Text.Trim() + " zavrsili ste kviz!" + Environment.NewLine +
                                "Imate " + score + " tacnih odgovora!" + Environment.NewLine +
                                "Postotak vase tacnosti je " + percentage + " %" + Environment.NewLine +
                                "Kliknite Ok da biste ponovo igrali!"

                    );



                Form categoriesForm = new Categories();
                categoriesForm.Show();
                this.Hide();

                score = 0;

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

                    pbSlika.Image = Properties.Resources.willie;
                    lbPitanje.Text = "Koje od navedene djece nije bilo izabrano da obidje cokoladnu fabriku Willy-a Wonke?";

                    button1.Text = "Billy Warp";
                    button2.Text = "Veruca Salt";
                    button3.Text = "1Mike Teavee";
                    button4.Text = "Charlie Bucket";

                    correctAnswer = 1;

                    break;
                case 2:
                    pbSlika.Image = Properties.Resources.kum;
                    lbPitanje.Text = "Kome je pripadala macka iz filma The Godfather?";

                    button1.Text = "Franciu Ford Coppola-i";
                    button2.Text = "Diani Keaton";
                    button3.Text = "Al Pachino-u";
                    button4.Text = "Nije imala vlasnika";

                    correctAnswer = 4;

                    break;

                case 3:

                    pbSlika.Image = Properties.Resources.joker;

                    lbPitanje.Text = "Koji glumac nije glumio Joker-a?";

                    button1.Text = "Jack Nicholson";
                    button2.Text = "Sean Penn";
                    button3.Text = "Jared Leto";
                    button4.Text = "Mark Hamil";

                    correctAnswer = 2;

                    break;

                case 4:

                    pbSlika.Image = Properties.Resources.elle;

                    lbPitanje.Text = "Koliko je bodova imala Elle Woods na testu LSAT u filmu Legaly blonde?";

                    button1.Text = "172";
                    button2.Text = "167";
                    button3.Text = "179";
                    button4.Text = "155";

                    correctAnswer = 3;

                    break;

                case 5:

                    pbSlika.Image = Properties.Resources.cady;

                    lbPitanje.Text = "U filmu Mean Girls, sa kojeg kontinenta se doselila Cady?";

                    button1.Text = "Australija";
                    button2.Text = "Afrika";
                    button3.Text = "Evropa";
                    button4.Text = "Azija";

                    correctAnswer = 2;

                    break;

                case 6:

                    pbSlika.Image = Properties.Resources.ring;

                    lbPitanje.Text = "Koliko dana zivota je ostalo ljudima koji su pogledali ukletu kasetu u filmu The Ring?";

                    button1.Text = "5";
                    button2.Text = "6";
                    button3.Text = "7";
                    button4.Text = "8";

                    correctAnswer = 3;

                    break;

                case 7:

                    pbSlika.Image = Properties.Resources.oscar;

                    lbPitanje.Text = "Ko je najmladja osoba koja je osvojila oskar?";

                    button1.Text = "Jennifer Lawrence";
                    button2.Text = "Mickey Rooney";
                    button3.Text = "Haley Joel Osment";
                    button4.Text = "Tatum O’Neal";

                    correctAnswer = 4;

                    break;

                case 8:

                    pbSlika.Image = Properties.Resources.os;

                    lbPitanje.Text = "Koja glumica ima najvise osvojinih oskara?";

                    button1.Text = "Katharine Hepburn";
                    button2.Text = "Meryl Streep";
                    button3.Text = "Ingrid Bergman";
                    button4.Text = "Elizabeth Taylor";

                    correctAnswer = 1;

                    break;

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

        private void filmoviForma_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
