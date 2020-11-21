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
    public partial class Form_Pong : Form
    {
        public Form_Pong()
        {
            InitializeComponent();
        }
        //Global Variables
        int intBallDirection = 3;

        double dblSpeed = 3.5;
        double dblPaddleSpeed = 15;
        double dblCompSpeed = 3.5;

        int intAngle = 90;
        int intXMove = 0;
        int intYMove = 0;
        int intScore = 0;

        private void Form_Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 16, 2020
            //Title: Form_Pong_KeyDown
            //Purpsoe: To move the player paddle to the left and to the right

            //A key will move to left
            if (e.KeyCode == Keys.A)
            {
                //Makes sure that the paddle does not go off the screen before moving left
                if(this.pcbPaddle.Left > 0)
                {
                    this.pcbPaddle.Left -= (int)dblPaddleSpeed;
                }     
            }
            //D key will move right
            else if (e.KeyCode == Keys.D)
            {
                //Makes sure that the paddle does not go off the screen before moving right
                if (this.pcbPaddle.Left + this.pcbPaddle.Width + 15 < this.Width) 
                {
                    this.pcbPaddle.Left += (int)dblPaddleSpeed;
                }  
            }
        }

        private void tmr_GameTimer_Tick(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 17, 2020
            //Title: Tmr.GameTimer_Tick
            //Purpose: A timer to will run procedures every millisecond of the game

            //Control Ball move
            BallMove();

            //Evaluate Player Paddle
            BouncePlayerPaddle();

            //Control Computer Paddle
            ComputerMove();

        }
        public void BallMove()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 17, 2020
            //Title: BallMove
            //Prupose: To make the ball move 

            //Calcuclate x and y moves
            intXMove = HorizontalPosition(dblSpeed, intAngle);
            intYMove = VerticalPosition(dblSpeed, intAngle);

            //Set direction
            if (intBallDirection == 1)
            {
                intXMove = Math.Abs(intXMove);
                intYMove = Math.Abs(intYMove) * -1;
            }
            else if (intBallDirection == 2)
            {
                intXMove = Math.Abs(intXMove) * -1;
                intYMove = Math.Abs(intYMove) * -1;
            }
            else if (intBallDirection == 3)
            {
                intXMove = Math.Abs(intXMove) * -1;
                intYMove = Math.Abs(intYMove);
            }
            else if (intBallDirection == 4)
            {
                intXMove = Math.Abs(intXMove);
                intYMove = Math.Abs(intYMove);
            }

            //Set Boundaries and directions (clockwise)
            if (intBallDirection == 2 && this.pcbBall.Left < 0)
            {
                intBallDirection = 1;
            }
            else if (intBallDirection == 1 && this.pcbBall.Top < 0)
            {
                //Disable timer
                this.tmr_GameTimer.Enabled = false;

                //Send info to WinResults form
                WinResults.strWinResults = "YOU WIN!";
                WinResults.intFinalScore = intScore;

                //Open WinResults form
                WinResults Result = new WinResults();
                this.Hide();
                Result.Show();
            }
            else if (intBallDirection == 4 && this.pcbBall.Left + this.pcbBall.Width > this.Width)
            {
                intBallDirection = 3;
            }
            else if (intBallDirection == 3 && this.pcbBall.Top > this.pcbPaddle.Top + this.pcbPaddle.Height)
            {
                //Disable timer
                this.tmr_GameTimer.Enabled = false;

                //Send info to WinResults form
                WinResults.strWinResults = "YOU LOSE";
                WinResults.intFinalScore = intScore;

                //Open WinResults form
                WinResults Result = new WinResults();
                this.Hide();
                Result.Show();
            }


            //Set boundaries and directions (counter clockwise)
            if (intBallDirection == 1 && this.pcbBall.Left + this.pcbBall.Width > this.Width)
            {
                intBallDirection = 2;
            }
            else if (intBallDirection == 2 && this.pcbBall.Top < 0)
            {
                //Disable timer
                this.tmr_GameTimer.Enabled = false;

                //Send info to WinResults form
                WinResults.strWinResults = "YOU WIN!";
                WinResults.intFinalScore = intScore;

                //Open WinResults form
                WinResults Result = new WinResults();
                this.Hide();
                Result.Show();
            }
            else if (intBallDirection == 3 && this.pcbBall.Left < 0)
            {
                intBallDirection = 4;
            }
            else if (intBallDirection == 4 && this.pcbBall.Top > this.pcbPaddle.Top + this.pcbPaddle.Height)
            {
                //Dsiable timer
                this.tmr_GameTimer.Enabled = false;

                //Send info to WinResults form
                WinResults.strWinResults = "YOU LOSE!";
                WinResults.intFinalScore = intScore;

                //Open WinResults form
                WinResults Result = new WinResults();
                this.Hide();
                Result.Show();
            }

            //Makes the ball move
            this.pcbBall.Left += intXMove;
            this.pcbBall.Top += intYMove;
        }
        public void BouncePlayerPaddle()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 18, 2020
            //Title: BouncePlayerPaddle
            //Purpose: How the ball bounces off the paddle

            //When the ball intersects with player paddle
            if (this.pcbPaddle.Bounds.IntersectsWith(this.pcbBall.Bounds))
            {
                //increase ball speed and player paddle speed
                dblSpeed += 0.2;
                dblPaddleSpeed += 0.2;

                if (intBallDirection == 4)
                {
                    //if ball hits first 1/9 of paddle, ball reflects angle of 20 in direction 2
                    if (this.pcbBall.Left <= this.pcbPaddle.Left + this.pcbPaddle.Width/9)
                    {
                        intAngle = 20;
                        intBallDirection = 2;
                    }
                    //if ball hits between 1/9 and 2/9 of paddle, ball reflects angle of 30 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 2)
                    {
                        intAngle = 30;
                        intBallDirection = 2;
                    }
                    //if ball hits between 2/9 and 3/9 of paddle, ball reflects angle of 40 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 2 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 3)
                    {
                        intAngle = 40;
                        intBallDirection = 2;
                    }
                    //if ball hits between 3/9 and 4/9 of paddle, ball reflects angle of 60 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 3 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 4)
                    {
                        intAngle = 60;
                        intBallDirection = 2;
                    }
                    //if ball hits between 4/9 and 5/9 of paddle, ball reflects angle of 70 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 4 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 5)
                    {
                        intAngle = 70;
                        intBallDirection = 1;
                    }
                    //if ball hits between 5/9 and 6/9 of paddle, ball reflects angle of 60 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 5 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 6)
                    {
                        intAngle = 60;
                        intBallDirection = 1;
                    }
                    //if ball hits between 6/9 and 7/9 of paddle, ball reflects angle of 40 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 6 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 7)
                    {
                        intAngle = 40;
                        intBallDirection = 1;
                    }
                    //if ball hits between 7/9 and 8/9 of paddle, ball reflects angle of 30 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 7 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 8)
                    {
                        intAngle = 30;
                        intBallDirection = 1;
                    }
                    //if ball hits between 8/9 and above, ball reflects angle of 20 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 8 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width)
                    {
                        intAngle = 20;
                        intBallDirection = 1;
                    }
                }
                else if (intBallDirection == 3)
                {
                    //if ball hits first 1/9 of paddle, ball reflects angle of 20 in direction 2
                    if (this.pcbBall.Left <= this.pcbPaddle.Left + this.pcbPaddle.Width / 9)
                    {
                        intAngle = 20;
                        intBallDirection = 2;
                    }
                    //if ball hits between 1/9 and 2/9 of paddle, ball reflects angle of 30 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 2)
                    {
                        intAngle = 30;
                        intBallDirection = 2;
                    }
                    //if ball hits between 2/9 and 3/9 of paddle, ball reflects angle of 40 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 2 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 3)
                    {
                        intAngle = 40;
                        intBallDirection = 2;
                    }
                    //if ball hits between 3/9 and 4/9 of paddle, ball reflects angle of 60 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 3 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 4)
                    {
                        intAngle = 60;
                        intBallDirection = 2;
                    }
                    //if ball hits between 4/9 and 5/9 of paddle, ball reflects angle of 70 in direction 2
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 4 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 5)
                    {
                        intAngle = 70;
                        intBallDirection = 2;
                    }
                    //if ball hits between 5/9 and 6/9 of paddle, ball reflects angle of 60 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 5 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 6)
                    {
                        intAngle = 60;
                        intBallDirection = 1;
                    }
                    //if ball hits between 6/9 and 7/9 of paddle, ball reflects angle of 40 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 6 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 7)
                    {
                        intAngle = 40;
                        intBallDirection = 1;
                    }
                    //if ball hits between 7/9 and 8/9 of paddle, ball reflects angle of 30 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 7 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 8)
                    {
                        intAngle = 30;
                        intBallDirection = 1;
                    }
                    //if ball hits between 8/9 and above, ball reflects angle of 20 in direction 1
                    else if (this.pcbBall.Left >= this.pcbPaddle.Left + this.pcbPaddle.Width / 9 * 8 && this.pcbBall.Left < this.pcbPaddle.Left + this.pcbPaddle.Width)
                    {
                        intAngle = 20;
                        intBallDirection = 1;
                    }        
                }
                //score is added based on the angle that the player hit the ball with
                intScore += 10 * (90 - intAngle);
                this.lblScore.Text = intScore.ToString();
            }
        }

        public void ComputerMove()
        {
            //Name: Sathurshan Arulmohan 
            //Date: June 17, 2020
            //Title: ComputerMove
            //Purpose: Make the computer paddle move, and calculate how the ball bounces off the computer paddle

            //Making the computer paddle move
            //If the ball is on the left side of left half of computer paddle, computer paddle moves left
            if (this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width/2)
            {
                //Sets boundaries before moving 
                if (this.pcbCompPaddle.Left > 0)
                {
                    //How much computer paddle will move
                    this.pcbCompPaddle.Left -= (int)dblCompSpeed;
                }
            }
            //If the ball is on the right side of right half of computer paddle, computer paddle moves right
            else
            {
                //Sets boundaries before moving
                if (this.pcbCompPaddle.Left + this.pcbCompPaddle.Width < this.Width)
                { 
                    //How much computer paddle will move
                    this.pcbCompPaddle.Left += (int)dblCompSpeed;
                }
            }

            //How ball bounces off paddle
            if (this.pcbCompPaddle.Bounds.IntersectsWith(this.pcbBall.Bounds))
            {
                //Increase ball speed and computer paddle speed
                dblCompSpeed += 0.15;
                dblSpeed += 0.2;

                if (intBallDirection == 1)
                {
                    //if ball hits first 1/9 of paddle, ball reflects angle of 20 in direction 3
                    if (this.pcbBall.Left <= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9)
                    {
                        intAngle = 20;
                        intBallDirection = 3;
                    }
                    //if ball hits between 1/9 and 2/9 of paddle, ball reflects angle of 30 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 2)
                    {
                        intAngle = 30;
                        intBallDirection = 3;
                    }
                    //if ball hits between 2/9 and 3/9 of paddle, ball reflects angle of 40 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 2 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 3)
                    {
                        intAngle = 40;
                        intBallDirection = 3;
                    }
                    //if ball hits between 3/9 and 4/9 of paddle, ball reflects angle of 60 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 3 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 4)
                    {
                        intAngle = 60;
                        intBallDirection = 3;
                    }
                    //if ball hits between 4/9 and 5/9 of paddle, ball reflects angle of 70 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 4 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 5)
                    {
                        intAngle = 70;
                        intBallDirection = 4;
                    }
                    //if ball hits between 5/9 and 6/9 of paddle, ball reflects angle of 60 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 5 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 6)
                    {
                        intAngle = 60;
                        intBallDirection = 4;
                    }
                    //if ball hits between 6/9 and 7/9 of paddle, ball reflects angle of 40 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 6 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 7)
                    {
                        intAngle = 40;
                        intBallDirection = 4;
                    }
                    //if ball hits between 7/9 and 8/9 of paddle, ball reflects angle of 30 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 7 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 8)
                    {
                        intAngle = 30;
                        intBallDirection = 4;
                    }
                    //if ball hits between 8/9 and above, ball reflects angle of 20 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 8 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width)
                    {
                        intAngle = 20;
                        intBallDirection = 4;
                    }
                }
                else if (intBallDirection == 2)
                {
                    //if ball hits first 1/9 of paddle, ball reflects angle of 20 in direction 3
                    if (this.pcbBall.Left <= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9)
                    {
                        intAngle = 20;
                        intBallDirection = 3;
                    }
                    //if ball hits between 1/9 and 2/9 of paddle, ball reflects angle of 30 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 2)
                    {
                        intAngle = 30;
                        intBallDirection = 3;
                    }
                    //if ball hits between 2/9 and 3/9 of paddle, ball reflects angle of 40 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 2 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 3)
                    {
                        intAngle = 40;
                        intBallDirection = 3;
                    }
                    //if ball hits between 3/9 and 4/9 of paddle, ball reflects angle of 60 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 3 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 4)
                    {
                        intAngle = 60;
                        intBallDirection = 3;
                    }
                    //if ball hits between 4/9 and 5/9 of paddle, ball reflects angle of 70 in direction 3
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 4 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 5)
                    {
                        intAngle = 70;
                        intBallDirection = 3;
                    }
                    //if ball hits between 5/9 and 6/9 of paddle, ball reflects angle of 60 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 5 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 6)
                    {
                        intAngle = 60;
                        intBallDirection = 4;
                    }
                    //if ball hits between 6/9 and 7/9 of paddle, ball reflects angle of 40 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 6 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 7)
                    {
                        intAngle = 40;
                        intBallDirection = 4;
                    }
                    //if ball hits between 7/9 and 8/9 of paddle, ball reflects angle of 30 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 7 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 8)
                    {
                        intAngle = 30;
                        intBallDirection = 4;
                    }
                    //if ball hits between 8/9 and above, ball reflects angle of 20 in direction 4
                    else if (this.pcbBall.Left >= this.pcbCompPaddle.Left + this.pcbCompPaddle.Width / 9 * 8 && this.pcbBall.Left < this.pcbCompPaddle.Left + this.pcbCompPaddle.Width)
                    {
                        intAngle = 20;
                        intBallDirection = 4;
                    }
                }
            }
        }
        public int HorizontalPosition (double dblHyp, int intDegree)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 17, 2020
            //Title: HorizontalPosition
            //Purpose: To calculate how much the ball will move on x axis

            //Variables
            int intXPosition;

            //Process (Cosine)
            intXPosition =(int)(dblHyp * Math.Cos((double)intDegree * Math.PI / 180));

            return intXPosition;
        }
        public int VerticalPosition(double dblHyp, int intDegree)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 17, 2020
            //Title: VerticalPosition
            //Purpose: To calculate how much the ball will move on y axis

            //Variables
            int intYPosition;

            //Process (Sine)
            intYPosition = (int)(dblHyp * Math.Sin((double)intDegree * Math.PI / 180));

            return intYPosition;
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 17, 2020
            //Title: btnSTART_Click
            //Purpose: To start the game so player can play

            //Enable the timer
            this.tmr_GameTimer.Enabled = true;

            //Hide the button
            btnSTART.Visible = false;
        }
    }
}
    