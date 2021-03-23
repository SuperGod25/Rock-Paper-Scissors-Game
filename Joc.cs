using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Joc : Form
    {
        
         public int timp = 6;
         string[] computerChoices = { "rock", "paper", "scissors", "rock", "scissor"};
         string computerCommand;
        int randomNumber;
        Random rand = new Random();
        string playerChoice;
        int playerWins = 0, computerWins = 0;
        string playerName = Microsoft.VisualBasic.Interaction.InputBox("Choose a name", "Rock Paper Scissors", " ", 800, 160);

        public Joc()
        {
            InitializeComponent();
            if (playerName == " ")
            {
                playerName = "unknown";
                playerName_lbl.Text = playerName;
                timer1.Enabled = true;
                playerChoice = " ";
            }
            else
            {
                playerName_lbl.Text = playerName;
                timer1.Enabled = true;
                playerChoice = " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reguli reguli = new Reguli();
            this.Hide();
            reguli.Closed += (s, args) => this.Close();
            reguli.Show();
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 meniu = new Form1();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timp--;
            label5.Text = Convert.ToString(timp);


            if (timp < 1)
            {
                timer1.Enabled = false;
                timp = 6;
                randomNumber = rand.Next(0, 5);
                computerCommand = computerChoices[randomNumber];



                switch (computerCommand)
                {
                    case "rock":
                        computer_pictureBox.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        computer_pictureBox.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        computer_pictureBox.Image = Properties.Resources.scissors;
                        break;

                   
                }



                InGame();
                
            }
                


        }

         void InGame()
        {
            if (playerChoice == "rock" && computerCommand == "paper")
            {

                computerWins++;
                computerScore_lbl.Text = Convert.ToString(computerWins);
                MessageBox.Show("Runda castigata de computer");
                NextRound();
            }
            else if (playerChoice == "paper" && computerCommand == "scissors")
            {
                computerWins++;
                computerScore_lbl.Text = Convert.ToString(computerWins);
                MessageBox.Show("Runda castigata de computer");
                NextRound();
            }
            else if (playerChoice == "scissors" && computerCommand == "rock")
            {
                computerWins++;
                computerScore_lbl.Text = Convert.ToString(computerWins);
                MessageBox.Show("Runda castigata de computer");
                NextRound();
            }

            else if (playerChoice=="rock" && computerCommand == "scissors")
            {
                playerWins++;
                playerScore_lbl.Text = Convert.ToString(playerWins);
                MessageBox.Show("Runda castigata de "+playerName);
                NextRound();
            }
            else if(playerChoice=="paper" && computerCommand == "rock")
            {
                playerWins++;
                playerScore_lbl.Text = Convert.ToString(playerWins);
                MessageBox.Show("Runda castigata de " + playerName);
                NextRound();
            }
            else if(playerChoice=="scrissors" && computerCommand == "paper")
            {
                playerWins++;
                playerScore_lbl.Text = Convert.ToString(playerWins);
                MessageBox.Show("Runda castigata de " + playerName);
                NextRound();
            }
            else if (playerWins == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show(playerName + " a castigat!");
            }
            else if (computerWins == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("Computer-ul a castigat!");
            }
            else if(playerChoice==" ")
            {
                MessageBox.Show("Nu ai selectat nimic");
                NextRound();
            }
            else
            {
                MessageBox.Show("Egal");
                NextRound();
            }
        }

         void NextRound()
         {
            playerChoice = " ";
            computer_pictureBox.Image = Properties.Resources.intrebare;
            player_pictureBox.Image = Properties.Resources.intrebare;
            timer1.Enabled = true;
            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            player_pictureBox.Image = Properties.Resources.rock;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            player_pictureBox.Image = Properties.Resources.paper;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            player_pictureBox.Image = Properties.Resources.scissors;
        }

        private void player_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void computer_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void playerName_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Joc_Load(object sender, EventArgs e)
        {

        }

        void FinishedGame()
        {
            
           
        }
    }
}
