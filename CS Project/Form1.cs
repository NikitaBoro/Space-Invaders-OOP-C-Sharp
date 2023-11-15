using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace CS_Project
{
    public partial class mainmenu : Form
    {
        bool goDown = true;
        bool goUp = false;


        public mainmenu()
        {
            //for music to play enetr path to a music file and uncomment the next lines:

            //SoundPlayer player = new SoundPlayer(@"C:\example\example.wav");
            //player.Play();
            
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            lblStartGame.ForeColor = Color.Green;
            
           
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red;
        }

        private void lblStartGame_MouseLeave(object sender, EventArgs e)
        {
            lblStartGame.ForeColor = Color.White;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureSpaceGuy.Location.X;
            int y = pictureSpaceGuy.Location.Y;
           
            if(goDown==true)
            {
                pictureSpaceGuy.Location = new Point(x, y + 2);
                if (y>300)
                {
                    
                    goDown= false;
                    goUp = true;
                }
            }

          if(goUp==true)
            {
                pictureSpaceGuy.Location = new Point(x, y - 2);
                if(y<230)
                {
                    goDown = true;
                    goUp = false;
                }
            }

    
       
        }

       

        
    }
}
