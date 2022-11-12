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
    public partial class istorijaForma : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int pomocKliknuta=0;
        string odgovor="";
       

        public istorijaForma()
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

                stripStatusLabela.Text = "Broj tacnih odgovora: "+score;

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

                    pbSlika.Image = Properties.Resources.vojnici;
                    lbPitanje.Text = "Koje godine je poceo prvi svjetski rat?";

                    button1.Text = "1912";
                    button2.Text = "1913";
                    button3.Text = "1914";
                    button4.Text = "1915";

                    correctAnswer = 3;

                    break;
                case 2:
                    pbSlika.Image = Properties.Resources.hirosima;
                    lbPitanje.Text = "Na koje mjesto je bacena prva atomska bomba?";

                    button1.Text = "Hiroshima";
                    button2.Text = "Nagasaki";
                    button3.Text = "Osaka";
                    button4.Text = "Kyushu";

                    correctAnswer = 1;

                    break;

                case 3:

                    pbSlika.Image = Properties.Resources.kolumbbo;

                    lbPitanje.Text = "Koje godine je Cristopher Columbus doplovio do obale Amerike prvi put?";

                    button1.Text = "1494";
                    button2.Text = "1492";
                    button3.Text = "1496";
                    button4.Text = "1498";

                    correctAnswer = 2;

                    break;

                case 4:

                    pbSlika.Image = Properties.Resources.Ivo;

                    lbPitanje.Text = "Koje godine je Ivo Andric dobio Nobelovu nagradu za knjizevnost?";

                    button1.Text = "1963";
                    button2.Text = "1971";
                    button3.Text = "1973";
                    button4.Text = "1961";

                    correctAnswer = 4;

                    break;

                case 5:

                    pbSlika.Image = Properties.Resources.titanik;

                    lbPitanje.Text = "Koje godine je potonuo brod Titanik?";

                    button1.Text = "1911";
                    button2.Text = "1912";
                    button3.Text = "1913";
                    button4.Text = "1914";

                    correctAnswer = 2;

                    break;

                case 6:

                    pbSlika.Image = Properties.Resources.alkatraz;

                    lbPitanje.Text = "Koje godine je u potrunosti prestao sa radom zatvor Alkatraz?";

                    button1.Text = "1965";
                    button2.Text = "1963";
                    button3.Text = "1973";
                    button4.Text = "1976";

                    correctAnswer = 2;

                    break;

                case 7:

                    pbSlika.Image = Properties.Resources.bijelaKuca;

                    lbPitanje.Text = "Kako se zvao 3. americki predsjednik?";

                    button1.Text = "George Washington";
                    button2.Text = "Thomas Jefferson";
                    button3.Text = "James Madison";
                    button4.Text = "Andrew Jackson";

                    correctAnswer = 2;

                    break;

                case 8:

                    pbSlika.Image = Properties.Resources.bijelaKuca;

                    lbPitanje.Text = "Koje godine je ukinuto ropstvo u SAD-u?";

                    button1.Text = "1798";
                    button2.Text = "1819";
                    button3.Text = "1853";
                    button4.Text = "1863";

                    correctAnswer = 4;

                    break;

            }


            }

        private void istorijaForma_FormClosing(object sender, FormClosingEventArgs e)
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
                    case 1: odgovor = button1.Text.Trim();
                        break;

                    case 2: odgovor = button2.Text.Trim();
                        break;

                    case 3: odgovor = button3.Text.Trim();
                        break;

                    case 4: odgovor = button4.Text.Trim();
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
