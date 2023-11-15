namespace CS_Project
{
    partial class mainmenu
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
            this.lblStartGame = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureSpaceGuy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.Color.Black;
            this.lblStartGame.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(389, 277);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(374, 79);
            this.lblStartGame.TabIndex = 1;
            this.lblStartGame.Text = "Start Game";
            this.lblStartGame.Click += new System.EventHandler(this.label1_Click);
            this.lblStartGame.MouseLeave += new System.EventHandler(this.lblStartGame_MouseLeave);
            this.lblStartGame.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(499, 404);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(149, 79);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(275, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 157);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Game";
            // 
            // pictureSpaceGuy
            // 
            this.pictureSpaceGuy.BackColor = System.Drawing.Color.Transparent;
            this.pictureSpaceGuy.BackgroundImage = global::CS_Project.Properties.Resources.sp1;
            this.pictureSpaceGuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSpaceGuy.Location = new System.Drawing.Point(100, 230);
            this.pictureSpaceGuy.Name = "pictureSpaceGuy";
            this.pictureSpaceGuy.Size = new System.Drawing.Size(167, 174);
            this.pictureSpaceGuy.TabIndex = 4;
            this.pictureSpaceGuy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CS_Project.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(914, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CS_Project.Properties.Resources.MainMenu;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureSpaceGuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblStartGame);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "mainmenu";
            this.Text = "Space Invaders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpaceGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureSpaceGuy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}