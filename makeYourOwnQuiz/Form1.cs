using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


// 2025-11-27
// Alex Spicer
// Programming Assignment 12 - Make your own Quiz
// Quiz game 


// Question 1 - What is Kiran's favourite colour?
// Question 2 - What is Kiran's middle name?
// Question 3 - 
// Question 4 -
// Question 5 - 

namespace makeYourOwnQuiz
{
    public partial class Form1 : Form
    {
        //Global Variables

        Boolean question1 = false;
        Boolean question2 = false;
        Boolean question3 = false;
        Boolean question4 = false;
        Boolean question5 = false;

        int timeLeft = 25;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void countdownTimer()
        {
            //This is the timer for the game, you get 25 seconds for each question before it moves you onto the next question

            timeLeft = 25;

            countDown.Tick += (s, args) =>
            {
                timeLeft--;

                remainingTimeLabel.Text = "Time Remaining: " + timeLeft; //updates UI text

                if (timeLeft <0)
                {
                    this.Close();
                }
            };
            remainingTimeLabel.Visible = true;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            //This just gets rid of the starting screen and shows the buttons and first question

            countdownTimer(); //Start the timer

            startButton.Visible = false;

            //First question
            instructLabel.Text = "What is Kiran's favourite colour?"; 

            questionButton1.Visible = true;
            questionButton2.Visible = true;
            questionButton3.Visible = true;
            questionButton4.Visible = true;

            //4 is correct

            questionButton1.Text = "Brown";
            questionButton2.Text = "Yellow";
            questionButton3.Text = "Red";
            questionButton4.Text = "Blue";

            question1 = true;
        }

        private void answered()
        {
            //This runs each time the player answers

            //Disables the buttons - gives the player time to see their result
            questionButton1.Enabled = false;
            questionButton2.Enabled = false;
            questionButton3.Enabled = false;
            questionButton4.Enabled = false;

            question1 = false;
            question2 = false;
            question3 = false;
            question4 = false;
            question5 = false;

            Refresh();
            Thread.Sleep(2000);

            //Reenables the buttons for the next question
            questionButton1.Enabled = true;
            questionButton2.Enabled = true;
            questionButton3.Enabled = true;
            questionButton4.Enabled = true;

            //Resets the timer (it can be a bit slow/glitchy so I set it to 26 instead of 25)
            timeLeft = 26;

        }

        private void moveQuestion2()
        {
            //Sets up for the second question

            question1 = false;
            question2 = true;

            instructLabel.Text = "What is Kiran's middle name?";

            //3 is correct

            questionButton1.Text = "Pall";
            questionButton2.Text = "Pool";
            questionButton3.Text = "Paul";
            questionButton4.Text = "Pual";
        }

        private void moveQuestion3()
        {
            //sets up for the third question

            question2 = false;
            question3 = true;

            instructLabel.Text = "What is Kiran's Favourite Teacher";

            //1 is correct
            questionButton1.Text = "Wikipedia";
            questionButton2.Text = "Ms. Stone";
            questionButton3.Text = "ChatGPT";
            questionButton4.Text = "Mme. Black";
        }

        private void moveQuestion4()
        {
            //Sets up for the fourth question

            question3 = false;
            question4 = true;

            instructLabel.Text = "How many teeth does Kiran have?";

            //3 is correct
            questionButton1.Text = "20";
            questionButton2.Text = "23";
            questionButton3.Text = "He doesn't know";
            questionButton4.Text = "More than 2";
        }

        private void moveQuestion5()
        {
            //Sets up for the fifth question

            question4 = false;
            question5 = true;

            instructLabel.Text = "Who did Kiran play in the Comm Tech Greek Mythology Script";

            //2 is correct
            questionButton1.Text = "Zeus";
            questionButton2.Text = "Jesus";
            questionButton3.Text = "Poseidon";
            questionButton4.Text = "Hermes";
        }

        private void finalScreen()
        {
            //Hides the buttons for the result final screen 

            question5 = false;

            countDown.Enabled = false;

            remainingTimeLabel.Visible = false;

            questionButton1.Visible = false;
            questionButton2.Visible = false;
            questionButton3.Visible = false;
            questionButton4.Visible = false;

            //Tells you how good you did on the test!
            instructLabel.Text = "Good Job! You got a " + score.ToString() + "/5!";
        }

        private void questionButton1_Click(object sender, EventArgs e) 
        {
            //Checks which question you're on then sees if you got it right, then moves onto the next question

            if (question1 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion2();
            }
            else if (question2 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion3();
            }
            else if (question3 == true)
            {
                instructLabel.Text = "CORRECT";
                answered();
                moveQuestion4();
                score++;
            }
            else if (question4 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion5();
            }
            else if (question5 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                finalScreen();
            }
            
        }

        private void questionButton2_Click(object sender, EventArgs e)
        {
            //Checks which question you're on then sees if you got it right, then moves onto the next question

            if (question1 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion2();
            }
            else if (question2 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion3();
            }
            else if (question3 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion4();
            }
            else if (question4 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion5();
            }
            else if (question5 == true)
            {
                instructLabel.Text = "CORRECT";
                answered();
                score++;
                finalScreen ();
                
            }
            
        }

        private void questionButton3_Click(object sender, EventArgs e)
        {
            //Checks which question you're on then sees if you got it right, then moves onto the next question

            if (question1 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion2();
            }
            else if (question2 == true)
            {
                instructLabel.Text = "CORRECT";
                answered();
                moveQuestion3();
                score++;
            }
            else if (question3 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion4();
            }
            else if (question4 == true)
            {
                instructLabel.Text = "CORRECT";
                answered();
                moveQuestion5();
                score++;
            }
            else if (question5 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                finalScreen();
            }
            
        }

        private void questionButton4_Click(object sender, EventArgs e)
        {
            //Checks which question you're on then sees if you got it right, then moves onto the next question

            if (question1 == true)
            {
                instructLabel.Text = "CORRECT";
                answered();
                moveQuestion2();
                score++;
            }
            else if (question2 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion3();
            }
            else if (question3 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion4();
            }
            else if (question4 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                moveQuestion5();
            }
            else if (question5 == true)
            {
                instructLabel.Text = "INCORRECT";
                answered();
                finalScreen();
            }
            
        }
    }
}
