namespace Pong_SathurshanA
{
    partial class WinResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinResults));
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblWinResults = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.BackColor = System.Drawing.Color.MistyRose;
            this.BtnPlayAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayAgain.BackgroundImage")));
            this.BtnPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlayAgain.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayAgain.ForeColor = System.Drawing.Color.Teal;
            this.BtnPlayAgain.Location = new System.Drawing.Point(80, 173);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(127, 60);
            this.BtnPlayAgain.TabIndex = 0;
            this.BtnPlayAgain.Text = "PLAY AGAIN ";
            this.BtnPlayAgain.UseVisualStyleBackColor = false;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.MistyRose;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Teal;
            this.btnReturn.Location = new System.Drawing.Point(236, 173);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 60);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "RETURN TO MAIN MENU";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblWinResults
            // 
            this.lblWinResults.AutoSize = true;
            this.lblWinResults.BackColor = System.Drawing.Color.Transparent;
            this.lblWinResults.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinResults.ForeColor = System.Drawing.Color.Teal;
            this.lblWinResults.Location = new System.Drawing.Point(154, 69);
            this.lblWinResults.Name = "lblWinResults";
            this.lblWinResults.Size = new System.Drawing.Size(145, 34);
            this.lblWinResults.TabIndex = 2;
            this.lblWinResults.Text = "Win Results";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalScore.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.Color.Teal;
            this.lblFinalScore.Location = new System.Drawing.Point(180, 116);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(72, 34);
            this.lblFinalScore.TabIndex = 3;
            this.lblFinalScore.Text = "Score";
            // 
            // WinResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pong_SathurshanA.Pictures.CandyBackground;
            this.ClientSize = new System.Drawing.Size(398, 245);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblWinResults);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.BtnPlayAgain);
            this.Name = "WinResults";
            this.Text = "WinResults";
            this.Load += new System.EventHandler(this.WinResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlayAgain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblWinResults;
        private System.Windows.Forms.Label lblFinalScore;
    }
}