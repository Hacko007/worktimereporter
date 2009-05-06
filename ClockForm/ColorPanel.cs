using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Hackovic.FreshUserControls
{
    public class ColorPanel : System.Windows.Forms.Panel
    {
        public Color BgColor1 { get; set; }
        public Color BgColor2 { get; set; }
       

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            this.DoubleBuffered = true;

            base.OnPaintBackground(e);

            //BgColor1 = Color.Beige;
            //BgColor2 = Color.Black;

            System.Drawing.Drawing2D.LinearGradientBrush grad_brush = new LinearGradientBrush(
                new Point((int)(this.Width / 2), 0)
              , new Point((int)(this.Width / 2), this.Height)
              , this.BgColor1
              , this.BgColor2);

            //System.Drawing.Drawing2D.LinearGradientBrush grad_brush2
            //    = new LinearGradientBrush(
            //          new Point((int)(this.Width / 2), 0)
            //        , new Point((int)(this.Width / 2), this.Height)
            //        , this.BgColor3
            //        , this.BgColor4);
            
            e.Graphics.FillRectangle(grad_brush, this.ClientRectangle);            

        }
    }
}
