using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pong_SathurshanA
{
    public partial class WinResults : Form
    {
        public WinResults()
        {
            InitializeComponent();
        }
        //Global Variables
        public static string strWinResults;
        public static int intFinalScore;
        public static string strUserName;


        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 18, 2020
            //Title: btnPlayAgain_Click
            //Purpose: To bring back GamePong form so that the user can play again

            Form_Pong Play = new Form_Pong();
            this.Hide();
            Play.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 18, 2020
            //Title: btnReturn_Click
            //Purpose: To open the Main Menu

            MainMenu Return = new MainMenu();
            this.Hide();
            Return.Show();
        }

        private void WinResults_Load(object sender, EventArgs e)
        {
            //Name: Sathurhsan Arulmohan
            //Date: June 19, 2020
            //Title: WinResults_Load
            //Purpose: To display the score and the win result of the game

            //Displays if player won or not
            this.lblWinResults.Text = strWinResults;
            
            //Double points if user won
            ExtraPoints();

            //Display player score
            this.lblFinalScore.Text = intFinalScore.ToString();

            //Write the player score into HighScore.txt
            WriteScore();
        }
        public static void ExtraPoints()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 19, 2020
            //Title: ExtraPoints
            //Purpose: To give double to points if the user won the game 

            if (strWinResults == "YOU WIN!")
            {
                intFinalScore = intFinalScore * 2;

            }
        }
        public void WriteScore()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 19, 2020
            //Title: WriteScore
            //Purpose: To write the player highscore into HighScore.txt

            //Variables
            string[] strRead;
            string strInput = null;
            int intCounter = 0;

            StreamReader re = File.OpenText("HighScore.txt");

            //Count how many records are there
            while ((strInput = re.ReadLine()) != null)
            {
                intCounter++;
            }

            re.Close();

            //Set array size
            strRead = new string[intCounter + 1];

            re = File.OpenText("HighScore.txt");

            //Read and store data into array
            for(int i = 0; i< intCounter; i++)
            {
                strRead[i] = re.ReadLine();
            }
            
            re.Close();

            //Put recent score into array
            strRead[strRead.Length - 1] = strUserName + "," + intFinalScore;

            FileInfo t = new FileInfo("HighScore.txt");
            StreamWriter Tex = t.CreateText();

            //Write eveerything back into the file
            for (int i = 0; i < strRead.Length; i++)
            {
                Tex.WriteLine(strRead[i]);
            }

            Tex.Close();
        }
    }
}
