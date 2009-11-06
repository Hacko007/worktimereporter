using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hackovic.FreshUserControls
{
    public class ColorButton:Button
    {
		

        public Color FgColor1 { get; set; }
		public Color FgColor2 { get; set; }
		public Color TextShadowColor { get; set; }      
        public Color BgColor1 { get; set; }
        public Color BgColor2 { get; set; }

        public bool TextHasShadow { get; set; }

		#region Capture Mouse movments
		enum MouseLocation
		{
			Out, In, Down
		}
		private MouseLocation MouseStatus { get; set; }

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.MouseStatus = MouseLocation.In;
			this.Invalidate();
		}
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			this.MouseStatus = MouseLocation.Down;
			this.Invalidate();
		}
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.MouseStatus = MouseLocation.In;
			this.Invalidate();
		}
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.MouseStatus = MouseLocation.Out;
			this.Invalidate();
		}
		#endregion Capture Mouse movments

		protected override void OnPaint(PaintEventArgs e)
		{
			this.DoubleBuffered = true;
			int shadow_dist = 2;
			

			base.OnPaint(e);
			//BgColor1 = BgColor1 ?? Color.Beige;
			//BgColor2 = BgColor2 ?? Color.Black;
			Color b1 = BgColor1;
			Color b2 = BgColor2;

			switch (this.MouseStatus)
			{
				case MouseLocation.In:
					shadow_dist = 1;
					b1 = BgColor2;
					b2 = BgColor1;
					break;
				case MouseLocation.Out:
					shadow_dist = 2;
					break;
				case MouseLocation.Down:
					shadow_dist = 0;
					b1 = Color.Green;
					b2 = Color.White;
					break;
				default:
					break;
			}

			Rectangle r = this.DisplayRectangle;
			//r.Location = new Point(0, +shadow_dist);
			r.Size = new Size(r.Width + shadow_dist, r.Height + shadow_dist);
			e.Graphics.FillRectangle(Brushes.Black, r);


			System.Drawing.Drawing2D.LinearGradientBrush grad_brush = new LinearGradientBrush(
				new Point((int)(this.Width / 2), 0)
			  , new Point((int)(this.Width / 2), this.Height)
			  , b1
			  , b2);


			System.Drawing.Drawing2D.LinearGradientBrush grad_brush2 = new LinearGradientBrush(
				new Point((int)(this.Width / 2), 0)
			  , new Point((int)(this.Width / 2), this.Height)
			  , this.FgColor1
			  , this.FgColor2);

			Rectangle rec_grad = this.ClientRectangle;
			rec_grad.Width -= shadow_dist;
			rec_grad.Height -= shadow_dist;
			e.Graphics.FillRectangle(grad_brush, rec_grad);

			SizeF text_sz = e.Graphics.MeasureString(this.Text, this.Font);


			Point str_start = new Point(Math.Abs((int)(Width / 2) - (int)(text_sz.Width / 2)),
				Math.Abs((int)(Height / 2) - (int)(text_sz.Height / 2)));
			Point str_start2 = str_start;

			str_start2.X += shadow_dist;
			str_start2.Y += shadow_dist;

			if (this.TextHasShadow)
				e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(TextShadowColor ), str_start2);

			e.Graphics.DrawString(this.Text, this.Font, grad_brush2, str_start);

		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);

		}
       
    }
}

