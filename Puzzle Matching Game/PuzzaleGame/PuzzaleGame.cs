using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzaleGame
{
    public partial class PuzzaleGame : Form
    {
        public PuzzaleGame()
        {
            InitializeComponent();
            
        }

        public void Button_Position()
        {
            Random random = new Random();

            cOne.Location = new Point(random.Next(100, 230), random.Next(94, 250));
            CTwo.Location = new Point(random.Next(150, 310), random.Next(100, 290));

            dOne.Location = new Point(random.Next(200, 380), random.Next(100, 300));
            dTwo.Location = new Point(random.Next(180, 300), random.Next(110, 200));

            coOne.Location = new Point(random.Next(150, 430), random.Next(150, 300));
            coTwo.Location = new Point(random.Next(80, 150), random.Next(200, 320));

            pOne.Location = new Point(random.Next(50, 80), random.Next(86, 120));
            pTwo.Location = new Point(random.Next(110, 260), random.Next(89, 200));

            fOne.Location = new Point(random.Next(70, 320), random.Next(90, 150));
            fTwo.Location = new Point(random.Next(360, 380), random.Next(92, 190));
        }

        public void Button_Visiable()
        {
            cOne.Visible = true;
            CTwo.Visible = true;
            dOne.Visible = true;
            dTwo.Visible = true;
            coOne.Visible = true;
            coTwo.Visible = true;
            pOne.Visible = true;
            pTwo.Visible = true;
            fOne.Visible = true;
            fTwo.Visible = true;

        }

        string firstClick;
        string secondClick;
        string firstName;
        string secondName;
        int count = 0;
        int score = 500;
        int check = 0;

        private void PuzzaleGame_Load(object sender, EventArgs e)
        {
            Button_Position();
            ScoreLabel.Text = score.ToString();
        }
       

        private void Button_Clidk(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            button.ForeColor = Color.AliceBlue;
            count++;
            if (count == 1)
            {
                firstClick = button.Text;
                firstName = button.Name;
            }
            else if (count == 2)
            {
                secondClick = button.Text;
                secondName = button.Name;
                count = 0;
               

                if (firstClick == secondClick && firstName != secondName)
                {
                    score += 50;
                    ScoreLabel.Text = score.ToString();
                    switch (firstClick)
                    {
                        case "Cat":
                            cOne.Hide();
                            CTwo.Hide();
                            check++;
                            break;
                        case "Cow":
                            coOne.Hide();
                            coTwo.Hide();
                            check++;
                            break;
                        case "Dog":
                            dTwo.Hide();
                            dOne.Hide();
                            check++;
                            break;

                        case "Falcon":
                            fOne.Hide();
                            fTwo.Hide();
                            check++;
                            break;
                        case "Parrot":
                            pOne.Hide();
                            pTwo.Hide();
                            check++;
                            break;
                    }
                }
                if (firstClick != secondClick || firstName == secondName)
                {
                    score = score - 50;
                    ScoreLabel.Text = score.ToString();
                   
                }

                if (check == 5)
                {
                    GameOver go = new GameOver(score);
                    go.Show();
                    this.Hide();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_Visiable();
            Button_Position();

            score = 500;
            check = 0;
            ScoreLabel.Text = score.ToString();

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            button.ForeColor = Color.FromArgb(184, 59, 94);
        }

        private void ChangaViewBtn_Click(object sender, EventArgs e)
        {
            Button_Position();
        }
    }
}
