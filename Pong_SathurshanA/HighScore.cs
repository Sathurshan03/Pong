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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }
        //Global Variables
        string[] strName;
        int[] intScore;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 19, 2020
            //Title: btnReturn_Click
            //Purpose: To bring up the Main Menu when the Return button is clicked 

            MainMenu Return = new MainMenu();
            this.Hide();
            Return.Show();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 19, 2020
            //Title: HighScore_Load
            //Purpose: To display the top 10 highscores in this game

            //Find the File with highscores and sort it 
            FindScore();

            //Display of top 10 highscores
            for(int i = 0; i < 10; i++)
            {
                this.lblName.Text += (i + 1) + ". " +strName[i] + "\n";
                this.lblScore.Text += intScore[i] + "\n";
            }

            
        }

        public void FindScore()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 19, 2020
            //Title: FindScore
            //Purpose: To find file with highscores and sort it 

            //Variables 
            string strTemp;
            int intTemp;
            string strRead;
            int intCounter = -1;
            string strInput = null;

            //opens files
            StreamReader re = File.OpenText("HighScore.txt");
           
            while((strInput = re.ReadLine()) != null)
            {
                intCounter++;
            }
            re.Close();

            //Sets array size
            strName = new string[intCounter + 1];
            intScore = new int[intCounter + 1];


            re = File.OpenText("HighScore.txt");

            //Splice strRead into names and the score
            for(int i = 0; i <= intCounter ;i++)
            {
                strRead = re.ReadLine();
                strName[i] = strRead.Substring(0, strRead.IndexOf(","));
                
                strRead = strRead.Substring(strRead.IndexOf(",") + 1, strRead.Length - strRead.IndexOf(",") - 1);
                
                intScore[i] = Int32.Parse(strRead);

            }

            re.Close();

            //Sort from Highest scores to lowest scores
            for (int i = 0; i < intScore.Length ; i++)
            {
                for(int j = 0; j < intScore.Length-1;j++)
                { 
                if (intScore[j]<intScore[j+1])
                    {
                        intTemp = intScore[j];
                        intScore[j] = intScore[j + 1];
                        intScore[j + 1] = intTemp;

                        strTemp = strName[j];
                        strName[j] = strName[j + 1];
                        strName[j + 1] = strTemp;
                    }
                }
            }
        }
    }
}
