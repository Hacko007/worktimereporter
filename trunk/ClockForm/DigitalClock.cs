using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using Hackovic.FreshUserControls.Properties;

namespace Hackovic.FreshUserControls
{

    public enum DigitalClockStyle
    {
        FullClock,
        BitmapBackground,
        PlainBackground
    }
    
    public partial class DigitalClock : System.Windows.Forms.Control   
    {
        public DigitalClock()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.background_color_2 = this.BackColor;
            this.ForeColor2 = this.ForeColor;
            try
            {
                //this.DateTimeFormat = Settings.Default.DateTimeFormat;
            }
            catch 
            {
                this.DateTimeFormat = "HH:mm:ss";                
            }
            this.ContextMenuStrip = this.DigitalClock_contextMenuStrip;
        }

        private DigitalClockStyle digital_clock_style = DigitalClockStyle.FullClock;
        
        public DigitalClockStyle ClockStyle { 
            get{return this.digital_clock_style; }
            set { this.digital_clock_style = value; }
        }


        private Color background_color_2;
        
        [Browsable(true)]
        public Color BackColor2 { 
            get { return this.background_color_2; }
            set { this.background_color_2 = value; }
        }

        private Color fore_color_2;

        public Color ForeColor2 {
            get { return this.fore_color_2; }
            set { fore_color_2 = value; }
        }

        private string datetime_formatstring;

        /// <summary>
        /// DateTime format string 
        /// yyyy - four digit year
        /// MM - two digit month (01-12)
        /// dd - date ( 01-31)
        /// HH - hours (00-23)
        /// mm - minutes (00-59)
        /// ss - secunds (00-59)
        /// </summary>
        [Browsable(true)]
        public string DateTimeFormat { 
            get{ 
                return datetime_formatstring;
            }
            set
            {
                datetime_formatstring = value;
                //Settings.Default.DateTimeFormat = value;
                Settings.Default.Save();
            }
        }

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			if (ClockStyle == DigitalClockStyle.PlainBackground)
			{
				base.OnPaintBackground(pevent);
			}
			else
			{
				pevent.Graphics.FillRectangle(Brushes.Transparent, pevent.ClipRectangle);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            switch (this.ClockStyle)
            {
                case DigitalClockStyle.BitmapBackground:
                //break;
                case DigitalClockStyle.FullClock:
                    this.DigitalClock_Paint_FullClock(e);
                    break;
                case DigitalClockStyle.PlainBackground:
                    this.FramePrecent = 0;
                    this.DigitalClock_Paint_Transparent(e);
                    break;
                default:
                    break;
            }


        }
        
        private int frame_prercent_size = 3;

        public int FramePrecent {
            get { return frame_prercent_size; }
            set { frame_prercent_size = value; }
        }

        private Rectangle GetInnerRectangle() {
            Size frame_resize = new Size((int)(this.Width * this.FramePrecent / 100)
                , (int)(this.Height * this.FramePrecent * 3 / 100));

            frame_resize.Width = (frame_resize.Width > -1) ? frame_resize.Width : 0;
            frame_resize.Height = (frame_resize.Height> -1) ? frame_resize.Height : 0;

            return new Rectangle(
               frame_resize.Width
               , frame_resize.Height
               , this.Width - (frame_resize.Width * 2)
               , this.Height - (frame_resize.Height * 2));
        }

        private void DigitalClock_Paint_FullClock(PaintEventArgs e)
        {


            System.Drawing.Drawing2D.LinearGradientBrush grad_brush = new LinearGradientBrush(               
                  new Point((int)(this.Width / 2), 0)
                , new Point((int)(this.Width / 2), this.Height)                 
                , this.BackColor
                , this.BackColor2);

            System.Drawing.Drawing2D.LinearGradientBrush grad_brush2 
                = new LinearGradientBrush(
                      new Point((int)(this.Width / 2), 0)
                    , new Point((int)(this.Width / 2), this.Height)       
                    , this.BackColor2
                    , this.BackColor);



            SolidBrush border_brush = new SolidBrush(this.BackColor);
            Rectangle border_rec_full = new Rectangle(new Point(0, 0), this.Size);
            Rectangle border_rec_inner = this.GetInnerRectangle();

            Pen out_pen = new Pen(this.BackColor, 1);

            e.Graphics.FillRectangle(grad_brush2, border_rec_full);            
            //e.Graphics.FillRectangle(grad_brush, border_rec_inner);

            e.Graphics.DrawRectangle(out_pen, border_rec_full);            
            e.Graphics.DrawRectangle(out_pen, border_rec_inner);



            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(border_rec_inner);

            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterColor = Color.SeaShell;
            pthGrBrush.CenterPoint = new PointF(Math.Max(0, (int)(Width * 2 / 3)), Math.Max(0, (int)(Height * 2 / 3)));
            Color[] colors = { BackColor, BackColor2, Color.SeaShell, ForeColor2};
            pthGrBrush.SurroundColors = colors;
            e.Graphics.FillRectangle(pthGrBrush, border_rec_inner);

            this.DrawTimeString(e);

        }


        private void DigitalClock_Paint_Transparent( PaintEventArgs e)
        {
            DrawTimeString(e);
        }


        private Rectangle DrawTimeString(PaintEventArgs e)
        {

            Rectangle border_rec = this.GetInnerRectangle();

            System.Drawing.Drawing2D.LinearGradientBrush grad_brush_text = new LinearGradientBrush(
                new Point(0, 0)
                , new Point(this.Size)
                , this.ForeColor
                , this.ForeColor2);
            grad_brush_text.GammaCorrection = true;

            System.Drawing.Drawing2D.LinearGradientBrush grad_brush_shadow = new LinearGradientBrush(
                new Point(0, 0)
                , new Point(this.Size)
                , this.BackColor
                , this.BackColor2);

            float font_size = (this.Height  > 5) ? this.Height - 5 : 8;
            Font clock_font = new Font(FontFamily.GenericSerif, font_size, FontStyle.Bold);
            string time_str = DateTime.Now.ToString(this.DateTimeFormat );
            SizeF str_size = e.Graphics.MeasureString(time_str, clock_font);

            /// 
            /// Find Font that fittes this control
            /// 
            bool not_fitting = true;
            while (not_fitting && font_size > 5f)
            {
                font_size -= 0.2f;
                clock_font = new Font(FontFamily.GenericSerif, font_size, FontStyle.Bold);
                str_size = e.Graphics.MeasureString(time_str, clock_font);

                if ((str_size.Width + 2 < border_rec.Width)
                    && (str_size.Height + 2 < border_rec.Height))
                {
                    not_fitting = false;
                }
            }            
            
            /// Find center
            int top = border_rec.Top + ( Math.Max( (int)((border_rec.Height - str_size.Height)/2) , 0));
            int left = border_rec.Left+ (Math.Max((int)((border_rec.Width - str_size.Width) / 2), 0));

            /// Draw time sting shadow
            e.Graphics.DrawString(time_str
                , clock_font
                , grad_brush_shadow
                , left
                , top
                );
            
            //HatchBrush hbrush = new HatchBrush(HatchStyle.ZigZag, this.ForeColor, this.ForeColor2);
            
            /// Draw time string
            e.Graphics.DrawString(time_str
                , clock_font
                , grad_brush_text
                , left - 2
                , top - 2
                );
            return border_rec;
        }


        private void Clock_timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void toolStripTextBox_DateTimeFormat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /// If invalide input , exception is thrown
                DateTime.Now.ToString(toolStripTextBox_DateTimeFormat.TextBox.Text);
                
                this.DateTimeFormat = toolStripTextBox_DateTimeFormat.TextBox.Text;
                this.Invalidate();
                this.Refresh();
            }
            catch { }

        }

        private void DigitalClock_contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            toolStripTextBox_DateTimeFormat.TextBox.Text = this.DateTimeFormat;
        }

        
    }
}
