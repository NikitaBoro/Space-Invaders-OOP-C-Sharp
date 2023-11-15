namespace CS_Project
{
    partial class Form2
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLvlComp = new System.Windows.Forms.Label();
            this.lblNextLevel = new System.Windows.Forms.Label();
            this.lblTryAgain = new System.Windows.Forms.Label();
            this.lblExitToMenu = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblSaveGame = new System.Windows.Forms.Label();
            this.panelPause = new System.Windows.Forms.Panel();
            this.lblLoadGame = new System.Windows.Forms.Label();
            this.lblExitToMenu2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureSpaceGuy = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.picturePlanet1 = new System.Windows.Forms.PictureBox();
            this.pictureSpaceGuy2 = new System.Windows.Forms.PictureBox();
            this.picturePlanet2 = new System.Windows.Forms.PictureBox();
            this.picturePlanet3 = new System.Windows.Forms.PictureBox();
            this.pictureSpaceGuy3 = new System.Windows.Forms.PictureBox();
            this.picturePlanet4 = new System.Windows.Forms.PictureBox();
            this.pictureSpaceGuy4 = new System.Windows.Forms.PictureBox();
            this.panelPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Blue;
            this.txtScore.Location = new System.Drawing.Point(34, 589);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(76, 25);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGmeTimerEvent);
            // 
            // lblLvlComp
            // 
            this.lblLvlComp.AutoSize = true;
            this.lblLvlComp.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvlComp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLvlComp.Location = new System.Drawing.Point(351, 127);
            this.lblLvlComp.Name = "lblLvlComp";
            this.lblLvlComp.Size = new System.Drawing.Size(469, 79);
            this.lblLvlComp.TabIndex = 2;
            this.lblLvlComp.Text = "Level Complete";
            // 
            // lblNextLevel
            // 
            this.lblNextLevel.AutoSize = true;
            this.lblNextLevel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextLevel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNextLevel.Location = new System.Drawing.Point(468, 224);
            this.lblNextLevel.Name = "lblNextLevel";
            this.lblNextLevel.Size = new System.Drawing.Size(238, 52);
            this.lblNextLevel.TabIndex = 3;
            this.lblNextLevel.Text = "Next Level";
            this.lblNextLevel.Click += new System.EventHandler(this.lblNextLevel_Click);
            this.lblNextLevel.MouseLeave += new System.EventHandler(this.lblNextLevel_MouseLeave);
            this.lblNextLevel.MouseHover += new System.EventHandler(this.lblNextLevel_MouseHover);
            // 
            // lblTryAgain
            // 
            this.lblTryAgain.AutoSize = true;
            this.lblTryAgain.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTryAgain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTryAgain.Location = new System.Drawing.Point(321, 296);
            this.lblTryAgain.Name = "lblTryAgain";
            this.lblTryAgain.Size = new System.Drawing.Size(566, 52);
            this.lblTryAgain.TabIndex = 4;
            this.lblTryAgain.Text = "Press ENTER To Try Again";
            // 
            // lblExitToMenu
            // 
            this.lblExitToMenu.AutoSize = true;
            this.lblExitToMenu.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitToMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExitToMenu.Location = new System.Drawing.Point(389, 406);
            this.lblExitToMenu.Name = "lblExitToMenu";
            this.lblExitToMenu.Size = new System.Drawing.Size(414, 52);
            this.lblExitToMenu.TabIndex = 5;
            this.lblExitToMenu.Text = "Back To Main Menu";
            this.lblExitToMenu.Click += new System.EventHandler(this.lblExitToMenu_Click);
            this.lblExitToMenu.MouseLeave += new System.EventHandler(this.lblExitToMenu_MouseLeave);
            this.lblExitToMenu.MouseHover += new System.EventHandler(this.lblExitToMenu_MouseHover);
            // 
            // lblPause
            // 
            this.lblPause.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.Indigo;
            this.lblPause.Location = new System.Drawing.Point(142, 22);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(226, 79);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "Paused";
            // 
            // lblSaveGame
            // 
            this.lblSaveGame.AutoSize = true;
            this.lblSaveGame.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaveGame.Location = new System.Drawing.Point(142, 141);
            this.lblSaveGame.Name = "lblSaveGame";
            this.lblSaveGame.Size = new System.Drawing.Size(234, 52);
            this.lblSaveGame.TabIndex = 6;
            this.lblSaveGame.Text = "Save Game";
            this.lblSaveGame.Click += new System.EventHandler(this.lblSaveGame_Click);
            this.lblSaveGame.MouseLeave += new System.EventHandler(this.lblSaveGame_MouseLeave);
            this.lblSaveGame.MouseHover += new System.EventHandler(this.lblSaveGame_MouseHover);
            // 
            // panelPause
            // 
            this.panelPause.BackColor = System.Drawing.Color.DimGray;
            this.panelPause.Controls.Add(this.lblLoadGame);
            this.panelPause.Controls.Add(this.lblExitToMenu2);
            this.panelPause.Controls.Add(this.lblPause);
            this.panelPause.Controls.Add(this.lblSaveGame);
            this.panelPause.Location = new System.Drawing.Point(330, 127);
            this.panelPause.Name = "panelPause";
            this.panelPause.Size = new System.Drawing.Size(544, 393);
            this.panelPause.TabIndex = 6;
            // 
            // lblLoadGame
            // 
            this.lblLoadGame.AutoSize = true;
            this.lblLoadGame.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadGame.ForeColor = System.Drawing.Color.White;
            this.lblLoadGame.Location = new System.Drawing.Point(142, 213);
            this.lblLoadGame.Name = "lblLoadGame";
            this.lblLoadGame.Size = new System.Drawing.Size(237, 52);
            this.lblLoadGame.TabIndex = 8;
            this.lblLoadGame.Text = "Load Game";
            this.lblLoadGame.Click += new System.EventHandler(this.lblLoadGame_Click);
            this.lblLoadGame.MouseLeave += new System.EventHandler(this.lblLoadGame_MouseLeave);
            this.lblLoadGame.MouseHover += new System.EventHandler(this.lblLoadGame_MouseHover);
            // 
            // lblExitToMenu2
            // 
            this.lblExitToMenu2.AutoSize = true;
            this.lblExitToMenu2.BackColor = System.Drawing.Color.DimGray;
            this.lblExitToMenu2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitToMenu2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExitToMenu2.Location = new System.Drawing.Point(57, 284);
            this.lblExitToMenu2.Name = "lblExitToMenu2";
            this.lblExitToMenu2.Size = new System.Drawing.Size(414, 52);
            this.lblExitToMenu2.TabIndex = 7;
            this.lblExitToMenu2.Text = "Back To Main Menu";
            this.lblExitToMenu2.Click += new System.EventHandler(this.lblExitToMenu_Click);
            this.lblExitToMenu2.MouseLeave += new System.EventHandler(this.lblExitToMenu_MouseLeave);
            this.lblExitToMenu2.MouseHover += new System.EventHandler(this.lblExitToMenu_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureSpaceGuy
            // 
            this.pictureSpaceGuy.BackColor = System.Drawing.Color.Transparent;
            this.pictureSpaceGuy.BackgroundImage = global::CS_Project.Properties.Resources.sp4;
            this.pictureSpaceGuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSpaceGuy.Location = new System.Drawing.Point(1001, 225);
            this.pictureSpaceGuy.Name = "pictureSpaceGuy";
            this.pictureSpaceGuy.Size = new System.Drawing.Size(59, 96);
            this.pictureSpaceGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpaceGuy.TabIndex = 9;
            this.pictureSpaceGuy.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::CS_Project.Properties.Resources.tank;
            this.player.Location = new System.Drawing.Point(557, 556);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(72, 85);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // picturePlanet1
            // 
            this.picturePlanet1.BackColor = System.Drawing.Color.Transparent;
            this.picturePlanet1.BackgroundImage = global::CS_Project.Properties.Resources._3;
            this.picturePlanet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlanet1.Location = new System.Drawing.Point(966, 20);
            this.picturePlanet1.Name = "picturePlanet1";
            this.picturePlanet1.Size = new System.Drawing.Size(153, 186);
            this.picturePlanet1.TabIndex = 8;
            this.picturePlanet1.TabStop = false;
            // 
            // pictureSpaceGuy2
            // 
            this.pictureSpaceGuy2.BackColor = System.Drawing.Color.Transparent;
            this.pictureSpaceGuy2.BackgroundImage = global::CS_Project.Properties.Resources.sp5;
            this.pictureSpaceGuy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSpaceGuy2.Location = new System.Drawing.Point(799, 219);
            this.pictureSpaceGuy2.Name = "pictureSpaceGuy2";
            this.pictureSpaceGuy2.Size = new System.Drawing.Size(108, 139);
            this.pictureSpaceGuy2.TabIndex = 14;
            this.pictureSpaceGuy2.TabStop = false;
            // 
            // picturePlanet2
            // 
            this.picturePlanet2.BackColor = System.Drawing.Color.Transparent;
            this.picturePlanet2.BackgroundImage = global::CS_Project.Properties.Resources._7;
            this.picturePlanet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlanet2.Location = new System.Drawing.Point(58, 223);
            this.picturePlanet2.Name = "picturePlanet2";
            this.picturePlanet2.Size = new System.Drawing.Size(136, 135);
            this.picturePlanet2.TabIndex = 15;
            this.picturePlanet2.TabStop = false;
            // 
            // picturePlanet3
            // 
            this.picturePlanet3.BackColor = System.Drawing.Color.Transparent;
            this.picturePlanet3.BackgroundImage = global::CS_Project.Properties.Resources._6;
            this.picturePlanet3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlanet3.Location = new System.Drawing.Point(900, 391);
            this.picturePlanet3.Name = "picturePlanet3";
            this.picturePlanet3.Size = new System.Drawing.Size(147, 145);
            this.picturePlanet3.TabIndex = 17;
            this.picturePlanet3.TabStop = false;
            // 
            // pictureSpaceGuy3
            // 
            this.pictureSpaceGuy3.BackColor = System.Drawing.Color.Transparent;
            this.pictureSpaceGuy3.BackgroundImage = global::CS_Project.Properties.Resources.sp3;
            this.pictureSpaceGuy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSpaceGuy3.Location = new System.Drawing.Point(38, 400);
            this.pictureSpaceGuy3.Name = "pictureSpaceGuy3";
            this.pictureSpaceGuy3.Size = new System.Drawing.Size(196, 169);
            this.pictureSpaceGuy3.TabIndex = 16;
            this.pictureSpaceGuy3.TabStop = false;
            // 
            // picturePlanet4
            // 
            this.picturePlanet4.BackColor = System.Drawing.Color.Transparent;
            this.picturePlanet4.BackgroundImage = global::CS_Project.Properties.Resources._4;
            this.picturePlanet4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlanet4.Location = new System.Drawing.Point(27, 404);
            this.picturePlanet4.Name = "picturePlanet4";
            this.picturePlanet4.Size = new System.Drawing.Size(88, 99);
            this.picturePlanet4.TabIndex = 21;
            this.picturePlanet4.TabStop = false;
            // 
            // pictureSpaceGuy4
            // 
            this.pictureSpaceGuy4.BackColor = System.Drawing.Color.Transparent;
            this.pictureSpaceGuy4.BackgroundImage = global::CS_Project.Properties.Resources.sp2;
            this.pictureSpaceGuy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSpaceGuy4.Location = new System.Drawing.Point(839, 280);
            this.pictureSpaceGuy4.Name = "pictureSpaceGuy4";
            this.pictureSpaceGuy4.Size = new System.Drawing.Size(113, 156);
            this.pictureSpaceGuy4.TabIndex = 20;
            this.pictureSpaceGuy4.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.panelPause);
            this.Controls.Add(this.lblLvlComp);
            this.Controls.Add(this.lblNextLevel);
            this.Controls.Add(this.lblTryAgain);
            this.Controls.Add(this.lblExitToMenu);
            this.Controls.Add(this.pictureSpaceGuy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picturePlanet1);
            this.Controls.Add(this.pictureSpaceGuy2);
            this.Controls.Add(this.picturePlanet2);
            this.Controls.Add(this.picturePlanet3);
            this.Controls.Add(this.pictureSpaceGuy3);
            this.Controls.Add(this.picturePlanet4);
            this.Controls.Add(this.pictureSpaceGuy4);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form2";
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyidpressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panelPause.ResumeLayout(false);
            this.panelPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlanet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblLvlComp;
        private System.Windows.Forms.Label lblNextLevel;
        private System.Windows.Forms.Label lblTryAgain;
        private System.Windows.Forms.Label lblExitToMenu;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblSaveGame;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.Label lblExitToMenu2;
        private System.Windows.Forms.PictureBox picturePlanet1;
        private System.Windows.Forms.PictureBox pictureSpaceGuy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLoadGame;
        private System.Windows.Forms.PictureBox pictureSpaceGuy2;
        private System.Windows.Forms.PictureBox picturePlanet2;
        private System.Windows.Forms.PictureBox picturePlanet3;
        private System.Windows.Forms.PictureBox pictureSpaceGuy3;
        private System.Windows.Forms.PictureBox picturePlanet4;
        private System.Windows.Forms.PictureBox pictureSpaceGuy4;
    }
}

