using System;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(playerOneTB.Text, playerTwoTB.Text);
            this.Close();
        }
    }
}