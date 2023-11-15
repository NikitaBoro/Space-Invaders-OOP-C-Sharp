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
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;

using ENEMIES;
using BULLETS;



namespace CS_Project
{
    public partial class Form2 : Form
    {
        
        int level = 1;
        bool goLeft, goRight;
        int playerSpeed = 12;
        int score = 0;
        invader2Big invBig;
        Enemies inv2;
        bool shooting;
        bool isGameOver;
        bool isGamePaused = false;
        bool goDown = true;
        bool goUp = false;
        bool lvl3 = false;
        bool lvl2 = false;
        bool lvl4 = false;
        int maxScore;


        public Form2()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            gameSetup(level);
        }

        private void mainGmeTimerEvent(object sender, EventArgs e)
        {
            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight && player.Left < 830)
            {
                player.Left += playerSpeed;
            }
            if (level == 1)
            {
                level1();
            }
            else if (level == 2)
            {
                level2();
            }
            else if (level == 3)
            {
                level3();
            }
            else if (level == 4)
            {
                level4();
            }
        }

        private void level1()
        {
            lvl2 = false;
            lvl3=false;
            lvl4 = false;

            maxScore = 15;
            txtScore.Text = "Score: " + score;



            inv2.EnemyBulletTimer -= 10;

            if (inv2.EnemyBulletTimer < 1)
            {
                inv2.EnemyBulletTimer = 300;
                chooseEnemyFire();

            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Invaders")
                {
                    x.BringToFront();

                    x.Left += inv2.Speed;


                    if (x.Left > 900) // if enemy reach and of screen
                    {
                        x.Top += 65; // lower the enemies
                        x.Left = -80; // put enemies at the right of the screen
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver("Invaders got you!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblExitToMenu.Show();
                        lblTryAgain.Show();
                    }

                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            PictureBox alien = (PictureBox)x;
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {

                                this.Controls.Remove(x);
                                inv2.removeInvader(alien);
                                this.Controls.Remove(y);
                                score += 1;
                                shooting = false;
                            }
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20; //player bullet speed

                    if (x.Top < 15) //player bullet reach top of screen
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemyBullet")
                {
                    x.Top += 20;//enemy bullet speed
                    if (x.Top > 620) // enemy bullet reach end of screen
                    {
                        this.Controls.Remove(x);
                    }


                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("You've been hit!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblLvlComp.BringToFront();
                        lblExitToMenu.Show();
                        lblExitToMenu.BringToFront();
                        lblTryAgain.Show();
                        lblTryAgain.BringToFront();
                    }
                }

            }

            if (score == maxScore)
            {
                level = 2;
                gameOver("You Won!");
                lblLvlComp.Text = "Level Complete";
                lblLvlComp.Show();
                lblSaveGame.Show();
                lblNextLevel.Show();
                lblExitToMenu.Show();
                
            }


        }
        private void level2()
        {
            maxScore = 10;
            txtScore.Text = "Score: " + score;
            lvl2 = true;
            lvl3 = false;
            lvl4 = false;


            inv2.EnemyBulletTimer -= 10;

            if (inv2.EnemyBulletTimer < 1)
            {
                inv2.EnemyBulletTimer = 220;
                chooseEnemyFire();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Invaders")
                {
                    x.BringToFront();
                    x.Left -= inv2.Speed;


                    if (x.Left < 0) // if enemy reach and of screen
                    {
                        x.Top += 65; // lower the enemies
                        x.Left = +880; // put enemies at the left of the screen
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver("Invaders got you!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblLvlComp.BringToFront();
                        lblExitToMenu.Show();
                        lblExitToMenu.BringToFront();
                        lblTryAgain.Show();
                        lblTryAgain.BringToFront();
                    }

                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            PictureBox alien = (PictureBox)x;
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                inv2.removeInvader(alien);
                                this.Controls.Remove(y);
                                score += 1;
                                shooting = false;
                            }
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20; //player bullet speed

                    if (x.Top < 15) //player bullet reach top of screen
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemyBullet")
                {
                    x.Top += 20;//enemy bullet speed
                    if (x.Top > 620) // enemy bullet reach end of screen
                    {
                        this.Controls.Remove(x);
                    }


                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("You've been hit!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblLvlComp.BringToFront();
                        lblExitToMenu.Show();
                        lblExitToMenu.BringToFront();
                        lblTryAgain.Show();
                        lblTryAgain.BringToFront();
                    }
                }

            }

            if (score > 5)
            {
                inv2.Speed = 15;
            }
            if (score == maxScore)
            {
                level = 3;
                gameOver("You Won!");
                lblLvlComp.Text = "Level Complete";
                lblLvlComp.Show();
                lblSaveGame.Show();
                lblNextLevel.Show();
                lblExitToMenu.Show();
               
            }
        }

        private void level3()
        {
            txtScore.Text = "Score: " + score;
            maxScore = 15;
            invBig.EnemyBulletTimer -= 10;
            lvl2 = false;
            lvl3 = true;
            lvl4 = false;

            if (invBig.EnemyBulletTimer < 1)
            {
                invBig.EnemyBulletTimer = 220;
                chooseEnemyFire();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Invaders")
                {
                    x.BringToFront();
                    x.Left -= invBig.Speed;

                    if (x.Left == 200) invBig.Speed = 0;


                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {


                                if ((string)x.Name == "invader0")
                                {
                                    invBig.reduceOne(0);
                                    if (invBig.getHealth(0) == 0)
                                    {
                                        PictureBox alien = (PictureBox)x;
                                        this.Controls.Remove(x);
                                        invBig.removeInvader(alien);
                                        score += 5;
                                    }
                                }
                                if ((string)x.Name == "invader1")
                                {
                                    invBig.reduceOne(1);
                                    if (invBig.getHealth(1) == 0)
                                    {
                                        PictureBox alien = (PictureBox)x;
                                        this.Controls.Remove(x);
                                        invBig.removeInvader(alien);
                                        score += 5;
                                    }
                                }
                                if ((string)x.Name == "invader2")
                                {
                                    invBig.reduceOne(2);
                                    if (invBig.getHealth(2) == 0)
                                    {
                                        PictureBox alien = (PictureBox)x;
                                        this.Controls.Remove(x);
                                        invBig.removeInvader(alien);
                                        score += 5;
                                    }
                                }

                                this.Controls.Remove(y);
                                shooting = false;
                            }
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20; //player bullet speed

                    if (x.Top < 15) //player bullet reach top of screen
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemyBullet")
                {
                    x.Top += 20;//enemy bullet speed
                    if (x.Top > 620) // enemy bullet reach end of screen
                    {
                        this.Controls.Remove(x);
                    }


                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("You've been hit!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblLvlComp.BringToFront();
                        lblExitToMenu.Show();
                        lblExitToMenu.BringToFront();
                        lblTryAgain.Show();
                        lblTryAgain.BringToFront();
                    }
                }

            }


            if (score == maxScore)
            {
                level = 4;
                gameOver("You Won!");
                lblLvlComp.Text = "Level Complete";
                lblLvlComp.Show();
                lblSaveGame.Show();
                lblNextLevel.Show();
                lblExitToMenu.Show();
                
            }
        }

        private void level4()
        {
            lvl3 = false;
            lvl4 = true;
            lvl2 = false;
            txtScore.Text = "Score: " + score;
            maxScore = 20;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Invaders")
                {
                    x.BringToFront();
                    x.Left += inv2.Speed;


                    if (x.Left > 900) // if enemy reach and of screen
                    {
                        x.Top += 65; // lower the enemies
                        x.Left = -80; // put enemies at the right of the screen
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver("Invaders got you!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblLvlComp.BringToFront();
                        lblExitToMenu.Show();
                        lblExitToMenu.BringToFront();
                        lblTryAgain.Show();
                        lblTryAgain.BringToFront();

                    }

                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            PictureBox alien = (PictureBox)x;
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                inv2.removeInvader(alien);
                                this.Controls.Remove(y);
                                score += 1;
                                shooting = false;
                            }
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20; //player bullet speed

                    if (x.Top < 15) //player bullet reach top of screen
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemyBullet")
                {
                    x.Top += 20;//enemy bullet speed
                    if (x.Top > 620) // enemy bullet reach end of screen
                    {
                        this.Controls.Remove(x);
                    }


                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("You've been hit!");
                        lblLvlComp.Text = "You've Lost!";
                        lblLvlComp.Show();
                        lblLvlComp.BringToFront();
                        lblExitToMenu.Show();
                        lblExitToMenu.BringToFront();
                        lblTryAgain.Show();
                        lblTryAgain.BringToFront();

                    }
                }

            }

            inv2.EnemyBulletTimer -= 10;

            if (inv2.EnemyBulletTimer < 1)
            {
                inv2.EnemyBulletTimer = 300;
                chooseEnemyFire();
            }
            if (score > 10)
            {
                inv2.Speed = 15;
            }
            if (score > 15)
            {
                inv2.Speed = 20;
            }
            if (score == maxScore)
            {
                gameOver("You Won!");
                lblLvlComp.Text = "You Won!";
                lblLvlComp.Show();
                lblExitToMenu.Show();

            }
        }
    


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                makeBullet("bullet");
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeAll();
                if (level==3 && score==inv2.ListSize)
                {
                    
                    gameSetup(level);
                    level3();
                }
               else if(level==2 && score==inv2.ListSize)
                {
                    
                    gameSetup(level);
                        level2();
                }
               else if(level==4 && lvl3==true&& score==invBig.ListSize*5 )
                {
                    
                    gameSetup(level);
                    level4();
                }
                else
                {
                    
                    gameSetup(level);
                }
            }
        }

        private void keyidpressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Escape)
            {
                gamePaused();
            }
        }
        private void makeInvaders(int num)
        {
            if(num==1)
            {
                inv2 = new invader1();
                inv2.CreateOne(this);
            }
           

            if(num==2)
            {
                inv2 = new invader2();
                inv2.CreateOne(this);
            }
          

            if (num==3 )
            {
                invBig = new invader2Big();
                invBig.setHealth();
                invBig.CreateOne(this);
            }

            if(num==4 )
            {
                inv2 = new invader2Small();
                inv2.CreateOne(this);
            }
            
        }

        private void makeInvadersFromLoad(int num,int size)
        {
            if (num == 1)
            {
                inv2 = new invader1();
                inv2.createTest(this,size);
            }


            if (num == 2)
            {
                inv2 = new invader2();
                inv2.createTest(this,size);
            }


            if (num == 3)
            {
                invBig = new invader2Big();
                invBig.setHealth();
                invBig.createTest(this,size);
            }

            if (num == 4)
            {
                inv2 = new invader2Small();
                inv2.createTest(this,size);
            }

        }


        private void gameSetup(int num)
        {
            pictureSpaceGuy.Hide();
            pictureSpaceGuy2.Hide();
            pictureSpaceGuy3.Hide();
            pictureSpaceGuy4.Hide();

            picturePlanet1.Hide();
            picturePlanet2.Hide();
            picturePlanet3.Hide();
            picturePlanet4.Hide();

            lblLvlComp.Hide();
            lblNextLevel.Hide();
            lblTryAgain.Hide();
            lblExitToMenu.Hide();
           
            txtScore.Text = "Score: 0";
            score = 0;
            isGameOver = false;
            panelPause.Hide();
            shooting = false;
            makeInvaders(num);
            gameTimer.Start();
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text = "Score: " + score + " " + message;

        }

        private void removeAll()
        {
            if (level == 1 || level == 2 || level==4)
            {

                inv2.DeleteArray(this);

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if ((string)x.Tag == "bullet" || (string)x.Tag == "enemyBullet")
                        {
                            this.Controls.Remove(x);
                        }
                    }
                }
            }
            else if(level==3 && lvl3==true)
            {
                invBig.DeleteArray(this);

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if ((string)x.Tag == "bullet" || (string)x.Tag == "enemyBullet")
                        {
                            this.Controls.Remove(x);
                        }
                    }
                }

            }
            else if(level == 3 && lvl3 == false)
            {
                inv2.DeleteArray(this);

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if ((string)x.Tag == "bullet" || (string)x.Tag == "enemyBullet")
                        {
                            this.Controls.Remove(x);
                        }
                    }
                }

            }
        }

        private void lblExitToMenu_MouseHover(object sender, EventArgs e)
        {
            lblExitToMenu.ForeColor = Color.Red;
            lblExitToMenu2.ForeColor = Color.Red;
        }

        private void lblExitToMenu_MouseLeave(object sender, EventArgs e)
        {
            lblExitToMenu.ForeColor = Color.White;
            lblExitToMenu2.ForeColor = Color.White;
        }

        private void lblExitToMenu_Click(object sender, EventArgs e)
        {
            mainmenu f1 = new mainmenu();
            f1.Show();
            this.Hide();
        }

        private void lblNextLevel_Click(object sender, EventArgs e)
        {
            removeAll();
            gameSetup(level);
            if (level == 2)
                level2();
            else if (level == 3)
                level3();
            else if (level == 4)
                level4();
        }

       
        private void lblNextLevel_MouseHover(object sender, EventArgs e)
        {
            lblNextLevel.ForeColor = Color.Green;
        }

        private void lblNextLevel_MouseLeave(object sender, EventArgs e)
        {
            lblNextLevel.ForeColor = Color.White;
        }

        private void makeBullet(string bulletTag)
        {
            CircularPictureBox b=new CircularPictureBox();
            b.Top = player.Top - 10;
            b.Left = player.Left + player.Width / 2;
            b.Size = new Size(15, 15);
            b.Tag= bulletTag;
            b.BackColor = Color.Red;
            this.Controls.Add(b);
            b.BringToFront();


        }


        private void makeEnemyBullet(PictureBox a)
        {

            CircularPictureBox b = new CircularPictureBox();
            b.Location= new Point(a.Location.X + a.Width / 2, a.Location.Y + 20);
            b.Size = new Size(6, 25);
            b.Tag = "enemyBullet";
            b.BackColor = Color.Yellow;
            this.Controls.Add(b);
            b.BringToFront();


        }

        private void chooseEnemyFire()
        {
            if (level == 1 || level == 2 || level==4)
            {
                Random r = new Random();
                int pick;

                if (inv2.getListCount() > 0)
                {

                    pick = r.Next(inv2.getListCount());

                    makeEnemyBullet(inv2.getEnemyInIndex(pick));
                }
            }
            else
            {
                Random r = new Random();
                int pick;

                if (invBig.getListCount() > 0)
                {

                    pick = r.Next(invBig.getListCount());

                    makeEnemyBullet(invBig.getEnemyInIndex(pick));
                }


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (level == 1)
            {
                pictureSpaceGuy.Show();
                pictureSpaceGuy2.Hide();
                pictureSpaceGuy3.Hide();
                pictureSpaceGuy4.Hide();

                picturePlanet1.Show();  
                picturePlanet2.Hide();
                picturePlanet3.Hide();
                picturePlanet4.Hide();


 

                int x = pictureSpaceGuy.Location.X;
                int y = pictureSpaceGuy.Location.Y;

                if (goDown == true)
                {
                    pictureSpaceGuy.Location = new Point(x, y + 2);
                    if (y > 310)
                    {

                        goDown = false;
                        goUp = true;
                    }
                }

                if (goUp == true)
                {
                    pictureSpaceGuy.Location = new Point(x, y - 2);
                    if (y < 225)
                    {
                        goDown = true;
                        goUp = false;
                    }
                }
            }
            else if(level == 2 && lvl2==true)
            {
                pictureSpaceGuy.Hide();
                pictureSpaceGuy2.Show();
                pictureSpaceGuy3.Hide();
                pictureSpaceGuy4.Hide();

                picturePlanet1.Hide();
                picturePlanet2.Show();
                picturePlanet3.Hide();
                picturePlanet4.Hide();

                int x = pictureSpaceGuy2.Location.X;
                int y = pictureSpaceGuy2.Location.Y;

                if (goDown == true)
                {
                    pictureSpaceGuy2.Location = new Point(x - 2, y);
                    if (x < 650)
                    {

                        goDown = false;
                        goUp = true;
                    }
                }

                if (goUp == true)
                {
                    pictureSpaceGuy2.Location = new Point(x + 2, y);
                    if (x > 800)
                    {
                        goDown = true;
                        goUp = false;
                    }
                }

            }
            else if(level==3 && lvl3==true)
            {

                pictureSpaceGuy.Hide();
                pictureSpaceGuy2.Hide();
                pictureSpaceGuy3.Show();
                pictureSpaceGuy4.Hide();

                picturePlanet1.Hide();
                picturePlanet2.Hide();
                picturePlanet3.Show();
                picturePlanet4.Hide();

                int x = pictureSpaceGuy3.Location.X;
                int y = pictureSpaceGuy3.Location.Y;

                if (goDown == true)
                {
                    pictureSpaceGuy3.Location = new Point(x, y + 2);
                    if (y > 400)
                    {

                        goDown = false;
                        goUp = true;
                    }
                }

                if (goUp == true)
                {
                    pictureSpaceGuy3.Location = new Point(x, y - 2);
                    if (y < 250)
                    {
                        goDown = true;
                        goUp = false;
                    }
                }

            }

            else if(level==4&& lvl4==true)
            {
                pictureSpaceGuy.Hide();
                pictureSpaceGuy2.Hide();
                pictureSpaceGuy3.Hide();
                pictureSpaceGuy4.Show();

                picturePlanet1.Hide();
                picturePlanet2.Hide();
                picturePlanet3.Hide();
                picturePlanet4.Show();

                int x = pictureSpaceGuy4.Location.X;
                int y = pictureSpaceGuy4.Location.Y;

                if (goDown == true)
                {
                    pictureSpaceGuy4.Location = new Point(x, y + 2);
                    if (y > 310)
                    {

                        goDown = false;
                        goUp = true;
                    }
                }

                if (goUp == true)
                {
                    pictureSpaceGuy4.Location = new Point(x, y - 2);
                    if (y < 225)
                    {
                        goDown = true;
                        goUp = false;
                    }
                }

            }
        }

        private void lblSaveGame_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();

                List<infoToSave> info = new List<infoToSave>();
                if (level == 1 || level == 2 || level == 4)
                {
                    int listsize = inv2.getListCount();
                    int i = 0;
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && (string)x.Tag == "Invaders")
                        {
                            info.Add(new infoToSave());
                            info[0].lvl = level;
                            info[i].leftPos = x.Left;
                            info[i].topPos = x.Top;
                            info[0].speed = inv2.Speed;
                            info[0].score = score;

                            i++;
                        }
                    }
                }
                else if(level ==3)
                {
                    int listsize = invBig.getListCount();
                    int i = 0;
                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && (string)x.Tag == "Invaders")
                        {
                            info.Add(new infoToSave());
                            info[0].lvl = level;
                            info[i].leftPos = x.Left;
                            info[i].topPos = x.Top;
                            info[0].speed = invBig.Speed;
                            info[0].score = score;


                            if(x.IsAccessible && (string)x.Name == "invader0")
                            {
                                info[0].health = invBig.getHealth(0);
                            }
                            if (x.IsAccessible && (string)x.Name == "invader1")
                            {
                                info[1].health = invBig.getHealth(1);
                            }
                            if (x.IsAccessible && (string)x.Name == "invader2")
                            {
                                info[2].health = invBig.getHealth(2);
                            }
                            i++;
                        }
                    }

                }
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    
                    formatter.Serialize(stream,info);

                }
            }
        }

        private void lblLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                BinaryFormatter bf = new BinaryFormatter();

                List<infoToSave> info = (List<infoToSave>)bf.Deserialize(stream);
                removeAll();
                if (info[0].lvl == 1 || info[0].lvl == 2 || info[0].lvl == 4)
                {
                    level = info[0].lvl;
                    removeAll();
                    makeInvadersFromLoad(level, info.Count);
                   
                
                    score = info[0].score;
                    for (int i = 0; i < info.Count; i++)
                    {

                        inv2.getEnemyInIndex(i).Top = info[i].topPos;
                        inv2.getEnemyInIndex(i).Left = info[i].leftPos;
                        inv2.Speed = info[0].speed;
                    } 
                }
                if(info[0].lvl==3)
                {
                    level = info[0].lvl;
                    removeAll();
                    makeInvadersFromLoad(level, info.Count);

                    score = info[0].score;
                    for (int i = 0; i < info.Count; i++)
                    {

                        invBig.getEnemyInIndex(i).Top = info[i].topPos;
                        invBig.getEnemyInIndex(i).Left = info[i].leftPos;
                        invBig.Speed = info[0].speed;

                    }
                    foreach(Control x in this.Controls)
                    {
                        if (x is PictureBox && (string)x.Tag == "Invaders")
                        {
                            if (x.IsAccessible && (string)x.Name == "invader0")
                            {
                                invBig.setHelthByIndex(0,info[0].health);
                            }
                            if (x.IsAccessible && (string)x.Name == "invader1")
                            {
                                invBig.setHelthByIndex(1, info[1].health);
                            }
                            if (x.IsAccessible && (string)x.Name == "invader2")
                            {
                                invBig.setHelthByIndex(2, info[2].health);
                            }
                        }

                    }

                            

                }
   
            }
        }
        private void lblSaveGame_MouseHover(object sender, EventArgs e)
        {
            lblSaveGame.ForeColor = Color.Blue;
            
        }

        private void lblSaveGame_MouseLeave(object sender, EventArgs e)
        {
            lblSaveGame.ForeColor = Color.White;
        
        }

        private void lblLoadGame_MouseHover(object sender, EventArgs e)
        {
            lblLoadGame.ForeColor = Color.Blue;
            
        }

        private void lblLoadGame_MouseLeave(object sender, EventArgs e)
        {
            lblLoadGame.ForeColor = Color.White;
        }

       
        private void gamePaused()
        {
            if (isGameOver != true)
            {
                if (isGamePaused == false)
                {
                    isGamePaused = true;
                    gameTimer.Stop();
                    panelPause.Show();
                    panelPause.BringToFront();
                    lblSaveGame.Show();
                    lblExitToMenu.Show();
                }
                else if (isGamePaused == true)
                {

                    isGamePaused = false;
                    gameTimer.Start();
                    panelPause.Hide();
                    lblSaveGame.Hide();
                    lblExitToMenu.Hide();

                }
            }
            
        }

    }
}
