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
        public class HexagonPosition
        {
            public bool rightSide;
            public bool leftSide;
            public bool bottomSide;

            public bool ConnectsAllSides()
            {
                return (rightSide && leftSide && bottomSide);
            }
        }


        //Fields
        public int hexagonSide = 10;

        public HexagonPosition HexPosition = new HexagonPosition();

        public List<HexagonButton> Neighbours = new List<HexagonButton>();

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
            this.ForeColor = Color.White;
            this.Size = new Size(2 * hexagonSide, (int)(1.73 * hexagonSide));
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int side)
        {
            GraphicsPath path = new();
            //float curveSize = radius * 2F;

            int thirdOfSide = rect.Width / 3;
            int quarterOfSide = rect.Width / 4;

            path.StartFigure();

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
