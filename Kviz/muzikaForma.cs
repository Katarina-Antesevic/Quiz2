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
    public partial class muzikaForma : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";



        public muzikaForma()
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

                    pbSlika.Image = Properties.Resources.sabbath;
                    lbPitanje.Text = "Ko je zamijenio Ozzy-a Osbourne-a kao vodeceg pjevaca Black Sabbath-a?";

                    button1.Text = "Ronnie James Dio";
                    button2.Text = "Rob Halford";
                    button3.Text = "Brian Johnson";
                    button4.Text = "Axl Rose";

                    correctAnswer = 1;

                    break;
                case 2:
                    pbSlika.Image = Properties.Resources.radio;
                    lbPitanje.Text = "Koja pjesma je najvise pustana u 20. vijeku u SAD-u?";

                    button1.Text = "Just Once in My Life";
                    button2.Text = "Danger Zone";
                    button3.Text = "Soul and Inspiration";
                    button4.Text = "You’ve Lost That Loving Feeling";

                    correctAnswer = 4;

                    break;

                case 3:

                    pbSlika.Image = Properties.Resources.eva;

                    lbPitanje.Text = "Kako se zove pjevacica grupe Evanescence?";

                    button1.Text = "Jen Majura";
                    button2.Text = "Lzzy Hale";
                    button3.Text = "Ben Moody";
                    button4.Text = "Amy Lee";

                    correctAnswer = 4;

                    break;

                case 4:

                    pbSlika.Image = Properties.Resources.guns;

                    lbPitanje.Text = "Koji Victoria Secret model se pojavio u spotovima za pjesme Don’t Cry i November Rain grupe Guns N’ Roses?";

                    button1.Text = "Christy Turlington";
                    button2.Text = "Karen Mulder";
                    button3.Text = "Stephanie Seymour";
                    button4.Text = "Peter M Brant";

                    correctAnswer = 3;

                    break;

                case 5:

                    pbSlika.Image = Properties.Resources.ques;

                    lbPitanje.Text = "Koliko zica ima instrument Ukulele?";

                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "5";
                    button4.Text = "6";

                    correctAnswer = 2;

                    break;

                case 6:

                    pbSlika.Image = Properties.Resources.roll;

                    lbPitanje.Text = "Koji clan grupe Rolling stones ima broj 1 hit kao solo izvodjac?";

                    button1.Text = "Ted Kennedy";
                    button2.Text = "Bill Wyman";
                    button3.Text = "Pete Townshend";
                    button4.Text = "Jackson Brownie";

                    correctAnswer = 2;

                    break;

                case 7:

                    pbSlika.Image = Properties.Resources._5;

                    lbPitanje.Text = "Ko je najstariji clan grupe The Jackson 5?";

                    button1.Text = "Jackie Jackson";
                    button2.Text = "Michael Jackson";
                    button3.Text = "Randy Jackson";
                    button4.Text = "Jermaine Jackson";

                    correctAnswer = 1;

                    break;

                case 8:

                    pbSlika.Image = Properties.Resources.kkk;

                    lbPitanje.Text = "Koliko godina su imali Jimi Hendrix, Amy Winehouse i Kurt Cobain kada su umrli?";

                    button1.Text = "25";
                    button2.Text = "26";
                    button3.Text = "27";
                    button4.Text = "28";

                    correctAnswer = 3;

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

        private void muzikaForma_FormClosing(object sender, FormClosingEventArgs e)
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
