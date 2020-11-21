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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 19, 2020
            //Title: btnReturn_Click
            //Purpose: To return back to the Main Menu

            MainMenu Return = new MainMenu();
            this.Hide();
            Return.Show();
        }
    }
}
