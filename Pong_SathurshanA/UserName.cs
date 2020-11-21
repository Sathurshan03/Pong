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
    public partial class UserName : Form
    {
        public UserName()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 18, 2020
            //Title: btnReturn_Click
            //Purpose: To return to the Main Menu

            MainMenu Return = new MainMenu();
            this.Hide();
            Return.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 18, 2020
            //Title: btnStart_Click
            //Purpose: To bring up the GamePong Form

            Form_Pong Play = new Form_Pong();
            this.Hide();
            Play.Show();

            //Sends the username to to WinResults Form
            WinResults.strUserName = this.txtUserName.Text;
        }
    }
}
