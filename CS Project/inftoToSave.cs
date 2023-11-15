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

namespace CS_Project
{
    [Serializable]
    public class infoToSave
    {
  
        public int topPos;
        public int leftPos;
        public int speed;
        public int lvl;
        public int score;
        public int health;
        
    }
}
