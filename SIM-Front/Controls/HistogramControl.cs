using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Front.Controls
{
    public partial class HistogramControl : Control
    {
        public HistogramControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Call the OnPaint method of the base class.
            base.OnPaint(pe);

            // Declare and instantiate a new pen that will be disposed of at the end of the method.
            var myPen = new Pen(Color.Aqua);

            // Create a rectangle that represents the size of the control, minus 1 pixel.
            var area = new Rectangle(new Point(0, 0), new Size(this.Size.Width - 1, this.Size.Height - 1));

            // Draw an aqua rectangle in the rectangle represented by the control.
            pe.Graphics.DrawRectangle(myPen, area);
        }

    }
}
