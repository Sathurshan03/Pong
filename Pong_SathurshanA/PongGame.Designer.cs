namespace Pong_SathurshanA
{
    partial class Form_Pong
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
            this.components = new System.ComponentModel.Container();
            this.tmr_GameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSTART = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.pcbCompPaddle = new System.Windows.Forms.PictureBox();
            this.pcbBall = new System.Windows.Forms.PictureBox();
            this.pcbPaddle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_GameTimer
            // 
            this.tmr_GameTimer.Interval = 1;
            this.tmr_GameTimer.Tick += new System.EventHandler(this.tmr_GameTimer_Tick);
            // 
            // btnSTART
            // 
            this.btnSTART.BackgroundImage = global::Pong_SathurshanA.Pictures.BlueButton;
            this.btnSTART.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSTART.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTART.ForeColor = System.Drawing.Color.Teal;
            this.btnSTART.Location = new System.Drawing.Point(316, 156);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(172, 58);
            this.btnSTART.TabIndex = 13;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.MistyRose;
            this.lblScore.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Teal;
            this.lblScore.Location = new System.Drawing.Point(412, 391);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(40, 44);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "0";
            // 
            // pcbCompPaddle
            // 
            this.pcbCompPaddle.BackColor = System.Drawing.Color.Black;
            this.pcbCompPaddle.BackgroundImage = global::Pong_SathurshanA.Pictures.Paddle;
            this.pcbCompPaddle.Location = new System.Drawing.Point(316, -2);
            this.pcbCompPaddle.Name = "pcbCompPaddle";
            this.pcbCompPaddle.Size = new System.Drawing.Size(172, 12);
            this.pcbCompPaddle.TabIndex = 12;
            this.pcbCompPaddle.TabStop = false;
            // 
            // pcbBall
            // 
            this.pcbBall.BackColor = System.Drawing.Color.SaddleBrown;
            this.pcbBall.Location = new System.Drawing.Point(389, 166);
            this.pcbBall.Name = "pcbBall";
            this.pcbBall.Size = new System.Drawing.Size(17, 17);
            this.pcbBall.TabIndex = 5;
            this.pcbBall.TabStop = false;
            // 
            // pcbPaddle
            // 
            this.pcbPaddle.BackColor = System.Drawing.Color.Black;
            this.pcbPaddle.BackgroundImage = global::Pong_SathurshanA.Pictures.Paddle;
            this.pcbPaddle.Location = new System.Drawing.Point(316, 348);
            this.pcbPaddle.Name = "pcbPaddle";
            this.pcbPaddle.Size = new System.Drawing.Size(172, 13);
            this.pcbPaddle.TabIndex = 4;
            this.pcbPaddle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 8);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblScoreTitle.Location = new System.Drawing.Point(291, 395);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(115, 40);
            this.lblScoreTitle.TabIndex = 16;
            this.lblScoreTitle.Text = "SCORE:";
            // 
            // Form_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.pcbCompPaddle);
            this.Controls.Add(this.pcbBall);
            this.Controls.Add(this.pcbPaddle);
            this.KeyPreview = true;
            this.Name = "Form_Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Pong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbPaddle;
        private System.Windows.Forms.PictureBox pcbBall;
        private System.Windows.Forms.Timer tmr_GameTimer;
        private System.Windows.Forms.PictureBox pcbCompPaddle;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScoreTitle;
    }
}

