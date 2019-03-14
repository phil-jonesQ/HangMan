using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HangMan
{
    public partial class HangMan : Form
    {
        bool gallows_base_display ;
        bool gallows_post_display ;
        bool gallows_top_post_display ;
        bool gallows_head_display ;
        bool gallows_rope_display ;
        bool gallows_body_display ;
        bool gallows_arm_right_display ;
        bool gallows_arm_left_display ;
        bool gallows_leg_right_display ;
        bool gallows_leg_left_display ;
        bool gameOver = false;
        bool failedGuess = false;
        int lives = 0;
        int failedGuessCount = 0;
        string word;
        string guess;
        int correct = 0;
        string hiddenWord;
        string realWord;
        int strLen;
        char[] sb;
        WordDB worddb = new WordDB();
        int cat = 1;
        string randWord;

        public HangMan()
        {
            InitializeComponent();
            resetGame();
            if (!gameOver)
            {
                resetButton.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gallowsTop_Click(object sender, EventArgs e)
        {

        }
        // Logic to Perform when click a letter
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            //Only do this if guess is wrong
            //System.Diagnostics.Debug.WriteLine("Debug: Word I have is " + word);
            System.Diagnostics.Debug.WriteLine("START OF CLICK PROCESS....");
            guess = b.Text;
            failedGuessCount = 0;
            StringBuilder realWord = new StringBuilder(word);

            for (int i = 0; i < strLen; i++)
            {

                if (guess == realWord[i].ToString())

                 {
                    // Call display method with index to reveal correct letters
                    displayWord(i);
                    correct++;

                }
                    
                else

                 {
                        failedGuessCount++;
                 }

                    if (failedGuessCount >= strLen)
                    {
                        failedGuess = true;
                    }


            }

            if (failedGuess)
            {
                lives++;
                populateGallows();
                failedGuess = false;
            }


            if (correct == strLen)
            { 
              System.Diagnostics.Debug.WriteLine("Debug: YOU WON!!!!!!!!");
                gameMessages.Text = "YOU WON!!!!!!!";
                resetButton.Show();
            }

        }


        private void populateGallows()
        {
            if (lives == 1)
            {
                gallowsBase.Show();
            }
            if (lives == 2)
            {
                gallowsPost.Show();
            }
            if (lives == 3)
            {
                gallowsTop.Show();
            }
            if (lives == 4)
            {
                rope.Show();
            }
            if (lives == 5)
            {
                gallowsHead.Show();
            }
            if (lives == 6)
            {
                body.Show();
            }
            if (lives == 7)
            {
                armRight.Show();
            }
            if (lives == 8)
            {
                armLeft.Show();
            }
            if (lives == 9)
            {
                legRight.Show();
            }
            if (lives == 10)
            {
                legLeft.Show();
                resetButton.Show();
                gameMessages.Text = "You lost! The word was " + realWord;

                //Disable ALL Buttons apart from Reset Gamne
                foreach (Control c in Controls)
                     {
                        Button b = c as Button;
                        if ((b != null) && (b != resetButton))
                        {
                            b.Enabled = false;
                        }
                    }

                gameOver = true;
            }

                
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        public void resetGame()
        {

            gallows_base_display = false;
            gallows_post_display = false;
            gallows_top_post_display = false;
            gallows_head_display = false;
            gallows_rope_display = false;
            gallows_body_display = false;
            gallows_arm_right_display = false;
            gallows_arm_left_display = false;
            gallows_leg_right_display = false;
            gallows_leg_left_display = false;
            gameOver = false;
            lives = 0;
            correct = 0;
            failedGuess = false;



            //Initialise The Display
            if (!gallows_base_display)
            {
                gallowsBase.Hide();
            }
            if (!gallows_post_display)
            {
                gallowsPost.Hide();
            }
            if (!gallows_top_post_display)
            {
                gallowsTop.Hide();
            }
            if (!gallows_rope_display)
            {
                rope.Hide();
            }
            if (!gallows_head_display)
            {
                gallowsHead.Hide();
            }
            if (!gallows_body_display)
            {
                body.Hide();
            }
            if (!gallows_arm_right_display)
            {
                armRight.Hide();
            }
            if (!gallows_arm_left_display)
            {
                armLeft.Hide();
            }
            if (!gallows_leg_right_display)
            {
                legRight.Hide();
            }
            if (!gallows_leg_left_display)
            {
                legLeft.Hide();
            }

            //Enable Buttons

            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                }
            }


            generateWord();
            //Initialise array with *
            sb = new char[strLen];
            sb = sb.Select(i => '*').ToArray();
            resetButton.Hide();
            displayWord(-1);
            setCategory();

        }

        public void displayWord(int index)
        {
            
            int strLen = word.Length;
            char[] ab = word.ToCharArray();

            // Show the user the amount
            if (index == -1)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    hiddenWord = new string(sb);
                    realWord = new string(ab);
                }
            }

            if (index != -1)
            {
                sb[index] = ab[index];
                hiddenWord = new string(sb);
                realWord = new string(ab);
            }
            wordBox.Text = hiddenWord;
            
            System.Diagnostics.Debug.WriteLine("Debug: real Word is " + realWord);


        }


        public void generateWord()
        {
            //word = "woopie";
            worddb = new WordDB();
            word = worddb.AddWord(randWord, cat);
            word = word.ToUpper();
            strLen = word.Length;
        }


        public void setCategory()
        {

            switch (cat)
            {
                case 1:
                    gameMessages.Text = "SELECTED CATEGORY: NAMES";
                    break;
                case 2:
                    gameMessages.Text = "SELECTED CATEGORY: ANIMALS";
                    break;
                case 3:
                    gameMessages.Text = "SELECTED CATEGORY: MISC";
                    break;
                default:
                    gameMessages.Text = "The category is names..";
                    break;
            }


        }

        private void gameMessages_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void categorySelect_Click(object sender, EventArgs e)
        {
            cat++;
            if (cat > 3)
            {
                cat = 1;
            }
            resetGame();

        }
    }
}
