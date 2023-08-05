using System;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {
        bool turn = true;//True = X turn; False = O turn
        int turn_count = 0;
        static string player1;
        static string player2;

        public static void setPlayerNames(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            playerOneLabel.Text = player1;
            playerTwoLabel.Text = player2;
            if (playerOneLabel.Text == "")
            {
                playerOneLabel.Text = "X";
            }
            if (playerTwoLabel.Text == "")
            {
                playerTwoLabel.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        
        private void checkForWinner()
        {
            bool thereIsAWinner = false;

            //Horizontal Checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsAWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            //Vertical Checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            //Diagonal Checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                disabledButtons();//Disables all the buttons once the result is declared
                String winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins!", "Result");
            }

            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!", "Result");
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                }
            }
        }

        //FILE ___ MenuStrip

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            enabledButton();
            resetButtonText();
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //HELP ___ MenuStrip

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By\n Shahzeb\n Yasir\n Ismail\n\n OOP Final Project!\n\n shahzebdasti98@gmail.com", "About");
        }

        private void enabledButton()
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
        }

        private void disabledButtons()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }

        private void resetButtonText()
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}