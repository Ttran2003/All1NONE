using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GameForm : Form
    {
        //create a string of worse, random generator, and integers
        string[] words = { "coding", "final", "project", "random", "hello", "interesting", "integers", "closed", "accident", "oopsy daisy" };
        Random randWord = new Random();
        int correct = 0;
        int incorrect = 0;
        public GameForm()
        {
            //make the word label produce a random word from the string (words)
            InitializeComponent();
            WordLabel.Text = words[randWord.Next(0, words.Length)];

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
        }

        private void EnterBtn(object sender, KeyEventArgs e)
        {

            //check the user input using the keypress of the enter button

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == WordLabel.Text)
                {
                    WordLabel.Text = words[randWord.Next(0, words.Length)];
                    textBox1.Text = null;
                    correct++;
                }
                else
                {
                    textBox1.Text = words[randWord.Next(0, words.Length)];
                    textBox1.Text = null;
                    incorrect++;
                }

                CorrectLabel.Text = "Correct: " + correct;
                IncorrectLabel.Text = "Incorrect: " + incorrect;


                // check if the player won or lost and rest them
                if (correct == 5)
                {
                    MessageBox.Show("Congrats you won the game! Press ok to play again!");
                    CorrectLabel.Text = "Correct: " + 0;
                    IncorrectLabel.Text = "Incorrect: " + 0;

                    correct = 0;
                    incorrect = 0;
                }

                if (incorrect == 5)
                {
                    MessageBox.Show("SORRY you LOST the game! Press ok to play again!");
                    CorrectLabel.Text = "Correct: " + 0;
                    IncorrectLabel.Text = "Incorrect: " + 0;

                    correct = 0;
                    incorrect = 0;
                }
            }
        }


        //reset button, sets the values back to 0
        private void button1_Click(object sender, EventArgs e)
        {
            CorrectLabel.Text = "Correct: " + 0;
            IncorrectLabel.Text = "Incorrect: " + 0;
            correct = 0;
            incorrect = 0;
        }




        //
    }
}