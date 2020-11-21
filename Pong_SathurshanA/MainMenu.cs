using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_SathurshanA
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 19, 2020
            //Title: btnStartGame_Click
            //Purpose: To bring to next form where user types in their name

            UserName Play = new UserName();
            this.Hide();
            Play.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 19, 2020
            //Title: btnExit_Click
            //Purpose: To exit the application 

            Application.Exit();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 19, 2020
            //Title: btnInstructions_Click
            //Purpose: To bring up the form with the instructions to the game

            Instructions Explain = new Instructions();
            this.Hide();
            Explain.Show();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 19, 2020
            //Title: btnHighScore_Click
            //Purpose: To bring the form that displays the top 10 highscores

            HighScore Score = new HighScore();
            this.Hide();
            Score.Show();
        }
    }
}
