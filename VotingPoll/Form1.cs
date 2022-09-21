using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingPoll
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObect = (Button)sender;
            int buttonTag = int.Parse((string)senderObect.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered "  + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Most_Talkative;
                    lblQuestion.Text = "Who was the most talkative in class?";
                    button1.Text = "Jose";
                    button2.Text = "Hosie";
                    button3.Text = "Evan";
                    button4.Text = "Ihab";

                    correctAnswer = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Quiet;
                    lblQuestion.Text = "Who was the most quiet in class?";
                    button1.Text = "Derek";
                    button2.Text = "Yun";
                    button3.Text = "Clay";
                    button4.Text = "Joel";

                    correctAnswer = 4;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Energetic;
                    lblQuestion.Text = "Who was the most energetic in class?";
                    button1.Text = "DJ";
                    button2.Text = "N8";
                    button3.Text = "Jessica";
                    button4.Text = "Ashley";

                    correctAnswer = 1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.NoWorries;
                    lblQuestion.Text = "Who always used the phrase.....No Worries?";
                    button1.Text = "Rubi";
                    button2.Text = "Lydia";
                    button3.Text = "Amoriss";
                    button4.Text = "Jennie";

                    correctAnswer = 3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.C_;
                    lblQuestion.Text = "Who instructor was the most called on in class?";
                    button1.Text = "Andrea";
                    button2.Text = "Amoriss";
                    button3.Text = "Morgan";
                    button4.Text = "Jeremy";

                    correctAnswer = 4;
                    break;

            }
        }
    }
}
