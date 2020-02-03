using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzaleGame
{
    public partial class GameOver : Form
    {
        private int score;
        public GameOver(int score)
        {
            InitializeComponent();
            this.score = score;
            ScoreLabel.Text = score.ToString();
        }
        
        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            PuzzaleGame pg = new PuzzaleGame();
            pg.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
