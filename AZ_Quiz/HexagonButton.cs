using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace AZ_Quiz
{
    public class HexagonButton : Button
    {
        //Fields
        public int hexagonSide = 10;

        //Properties
        [Category("Hexagon properties")]
        public int HexagonSide
        {
            get { return hexagonSide; }
            set
            {
                hexagonSide = value;
                this.Invalidate();
            }
        }

        [Category("Hexagon properties")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Hexagon properties")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public HexagonButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Purple;
            this.Name = "Hexagon";
            this.Size = new Size(50, 58);
            this.Location = new Point(445, 575);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Size = new Size(2 * hexagonSide, (int)(1.73 * hexagonSide));
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int side)
        {
            GraphicsPath path = new GraphicsPath();
            //float curveSize = radius * 2F;

            int thirdOfSide = rect.Width / 3;
            int quarterOfSide = rect.Width / 4;

            path.StartFigure();
            //path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            //path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            //path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            //path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);

            // ADAM:
            //path.AddLine(rect.X + side/2, rect.Y, rect.X + 3*side/2, rect.Y);
            //path.AddLine(rect.X + 3 * side / 2, rect.Y, rect.Right, (rect.Y + rect.Bottom) / 2);
            //path.AddLine(rect.Right, (rect.Y + rect.Bottom) / 2, rect.X + 3*side/2, rect.Bottom);
            //path.AddLine(rect.X + 3*side/2, rect.Bottom, rect.X + side/2, rect.Bottom);
            //path.AddLine(rect.X + side / 2, rect.Bottom, rect.X, (rect.Y + rect.Bottom) / 2);
            //path.AddLine(rect.X, (rect.Y + rect.Bottom) / 2, rect.X + side / 2, rect.Y);

            // first try:
            //path.AddLine(rect.X + thirdOfSide, rect.Y, rect.X + 2 * thirdOfSide, rect.Y);
            //path.AddLine(rect.X + 2 * thirdOfSide, rect.Y, rect.Right, (rect.Y + rect.Bottom) / 2);
            //path.AddLine(rect.Right, (rect.Y + rect.Bottom) / 2, rect.X + 2 * thirdOfSide, rect.Bottom);
            //path.AddLine(rect.X + 2 * thirdOfSide, rect.Bottom, rect.X + thirdOfSide, rect.Bottom);
            //path.AddLine(rect.X + thirdOfSide, rect.Bottom, rect.X, (rect.Y + rect.Bottom) / 2);
            //path.AddLine(rect.X, (rect.Y + rect.Bottom) / 2, rect.X + thirdOfSide, rect.Y);

            // Second try:
            path.AddLine(rect.X, rect.Y + quarterOfSide, rect.X + rect.Width / 2, rect.Y);
            path.AddLine(rect.X + rect.Width / 2, rect.Y, rect.Right, rect.Y + quarterOfSide);

            path.AddLine(rect.Right, rect.Y + quarterOfSide, rect.Right, rect.Bottom - quarterOfSide);

            path.AddLine(rect.Right, rect.Bottom - quarterOfSide, rect.X + rect.Width / 2, rect.Bottom);
            path.AddLine(rect.X + rect.Width / 2, rect.Bottom, rect.X, rect.Bottom - quarterOfSide);

            path.AddLine(rect.X, rect.Bottom - quarterOfSide, rect.X, rect.Y + quarterOfSide);

            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            int smoothSize = 2;

            if (hexagonSide > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, hexagonSide))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
