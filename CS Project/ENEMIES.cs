using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;



namespace ENEMIES
{
    [Serializable]
    public abstract class Enemies
    {
        protected int _posTop;
        protected int _posLeft;
        protected int _speed;
        protected int _enemyBulletTimer;
        protected int _width;
        protected int _height;
        protected int _listSize;
        public int PosTop
        {
            get { return _posTop; }
            set { _posTop = value; }
        }

        public int PosLeft
        {
            get { return _posLeft; }
            set { _posLeft = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int EnemyBulletTimer
        {
            get { return _enemyBulletTimer; }
            set { _enemyBulletTimer = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int ListSize
        {
            get { return _listSize; }
            set { _listSize = value; }
        }

        public abstract void CreateOne(Form p);
        public abstract void createTest(Form p, int size);
        public abstract void DeleteArray(Form p);
        public abstract int getListCount();
        public abstract PictureBox getEnemyInIndex(int i);
        public abstract void removeInvader(PictureBox pb);
    }
    [Serializable]
    public class invader1 : Enemies
    {

        protected List<PictureBox> invadersList;
        public invader1() : this(5, 0, 5, 300, 60, 50, 15)
        {

        }

        public invader1(int posTop, int posLeft, int speed, int bulletTimer, int width, int height, int listsize)
        {
            PosTop = posTop;
            PosLeft = posLeft;
            Speed = speed;
            EnemyBulletTimer = bulletTimer;
            Width = width;
            Height = height;
            ListSize = listsize;
        }


        public override void CreateOne(Form p)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < ListSize; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders1;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Name = "invaders1";
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(invadersList[i]);
                PosLeft = PosLeft - 80;
            }
        }

        public override void createTest(Form p,int size)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < size; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders1;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Name = "invaders1";
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(invadersList[i]);
              
            }
        }


        public override void DeleteArray(Form p)
        {
            foreach (PictureBox i in invadersList)
            {
                p.Controls.Remove(i);
            }
        }

        public override int getListCount()
        {
            return invadersList.Count();

        }

        public override PictureBox getEnemyInIndex(int i)
        {
            return invadersList[i];

        }

        public override void removeInvader(PictureBox pb)
        {
            invadersList.Remove(pb);

        }

        public List<PictureBox> getList()
        {
            return invadersList;
        }

        public void setList(List<PictureBox> list)
        {
            invadersList = list;

        }


    }


    [Serializable]
    public class invader2 : Enemies
    {
        List<PictureBox> invadersList;
        public invader2() : this(5, 800, 8, 250, 60, 50, 10)
        {

        }

        public invader2(int posTop, int posLeft, int speed, int bulletTimer, int width, int height, int listsize)
        {
            PosTop = posTop;
            PosLeft = posLeft;
            Speed = speed;
            EnemyBulletTimer = bulletTimer;
            Width = width;
            Height = height;
            ListSize = listsize;
        }


        public override void CreateOne(Form p)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < ListSize; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders2;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
          
                p.Controls.Add(invadersList[i]);
             
                PosLeft = PosLeft + 80;
            }
        }

        public override void createTest(Form p, int size)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < size; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders2;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(invadersList[i]);
       
            }
        }


        public override void DeleteArray(Form p)
        {
            foreach (PictureBox i in invadersList)
            {
                p.Controls.Remove(i);
            }
        }

        public override int getListCount()
        {
            return invadersList.Count();

        }

        public override PictureBox getEnemyInIndex(int i)
        {
            return invadersList[i];

        }

        public override void removeInvader(PictureBox pb)
        {
            invadersList.Remove(pb);

        }
    }


    [Serializable]
    public class invader2Big : invader2
    {
        List<PictureBox> invadersList;
        int[] health = new int[3];
        public invader2Big()
        {
            PosTop = 50;
            PosLeft = 900;
            Width = 150;
            Height = 150;
            Speed = 4;
            ListSize = 3;
        }

        public int getHealth(int i)
        {
            return health[i];
        }
        public void setHealth()
        {
            for (int i = 0; i < health.Length; i++)
                health[i] = 3;

        }
        public void setHelthByIndex(int i,int num)
        {
            health[i] = num;
        }
        public void reduceOne(int i)
        {
            health[i] = health[i] - 1;
        }


        public override void CreateOne(Form p)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < ListSize; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders2Big;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Name = "invader" + i;
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                
                p.Controls.Add(invadersList[i]);
                PosLeft = PosLeft + 200;
            }

        }

        public override void createTest(Form p, int size)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < size; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders2Big;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Name = "invader" + i;
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(invadersList[i]);

            }
        }


        public override void DeleteArray(Form p)
        {
            foreach (PictureBox i in invadersList)
            {
                p.Controls.Remove(i);
            }
        }

        public override int getListCount()
        {
            return invadersList.Count();

        }

        public override PictureBox getEnemyInIndex(int i)
        {
            return invadersList[i];

        }

        public override void removeInvader(PictureBox pb)
        {
            invadersList.Remove(pb);

        }
    }


    [Serializable]
    public class invader2Small : invader2
    {
        List<PictureBox> invadersList;
        

        public invader2Small()
        {
            PosTop = 5;
            PosLeft = 0;
            Width = 40;
            Height = 40;
            Speed = 10;
            EnemyBulletTimer = 300;
            ListSize = 20;

        }


        public override void CreateOne(Form p)
        {

            invadersList = new List<PictureBox>();

            for (int i = 0; i < ListSize; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders2Small;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(invadersList[i]);
                PosLeft = PosLeft - 60;
            }
        }

        public override void createTest(Form p, int size)
        {
            invadersList = new List<PictureBox>();

            for (int i = 0; i < size; i++)
            {
                invadersList.Add(new PictureBox());
                invadersList[i] = new PictureBox();
                invadersList[i].Size = new Size(Width, Height);
                invadersList[i].Image = CS_Project.Properties.Resources.invaders2Small;
                invadersList[i].Top = PosTop; //invaders position acording to top
                invadersList[i].Tag = "Invaders";
                invadersList[i].Name = "invader" + i;
                invadersList[i].Left = PosLeft;
                invadersList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                p.Controls.Add(invadersList[i]);

            }
        }



        public override void DeleteArray(Form p)
        {
            foreach (PictureBox i in invadersList)
            {
                p.Controls.Remove(i);
            }
        }

        public override int getListCount()
        {
            return invadersList.Count();

        }

        public override PictureBox getEnemyInIndex(int i)
        {
            return invadersList[i];

        }

        public override void removeInvader(PictureBox pb)
        {
            invadersList.Remove(pb);

        }
    }


    
}








