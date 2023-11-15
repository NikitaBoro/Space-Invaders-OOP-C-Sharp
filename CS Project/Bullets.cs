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
using System.Drawing.Drawing2D;

namespace BULLETS
{
    class CircularPictureBox:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (GraphicsPath obj = new GraphicsPath())
            {
                obj.AddEllipse(0,0,this.Width-1,this.Height-1);
                
                Region = new Region(obj);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new System.Drawing.Pen(new SolidBrush(this.BackColor),1),0,0,this.Width-1,this.Height-1);
            }
        }
    }
}
