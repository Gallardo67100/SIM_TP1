using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistogramControl
{
    public partial class HistogramControl: UserControl
    {
        private int maxHeight = 0;
        private int maxWidth = 0;
        public double minX { get; set; } = 0;

        public Dictionary<double, int> DataSource { get; set; }

        public HistogramControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Call the OnPaint method of the base class.
            base.OnPaint(pe);

            maxWidth = Convert.ToInt32(this.Size.Width * 0.8);
            maxHeight = Convert.ToInt32(this.Size.Height * 0.8);

            var X = this.Size.Width / 8;
            int Y, barWidth, barHeight;

            // Declare and instantiate a new pen that will be disposed of at the end of the method.
            var myBrush = new SolidBrush(Color.BlueViolet);

            if (DataSource != null)
            {
                DefineYAxisLabels(pe);
                DefineXAxisLabels();

                barWidth = maxWidth / DataSource.Count();

                foreach (var item in DataSource)
                {
                    barHeight = DefineHeight(item);
                    Y = this.Size.Height - (this.Size.Height - maxHeight)/2 - barHeight;

                    // Create a rectangle that represents the size of the control, minus 1 pixel.
                    var area = new Rectangle(new Point(X, Y), new Size(barWidth, barHeight));

                    // Draw an aqua rectangle in the rectangle represented by the control.
                    pe.Graphics.FillRectangle(myBrush, area);

                    X += barWidth + 1;
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            CleanLabels();

            this.Refresh();
        }

        public void CleanLabels()
        {
            Controls.Clear();
        }

        private int DefineHeight(KeyValuePair<double, int> interval)
        {
            var percentualValue = (decimal)interval.Value * 100 / DataSource.Values.Max();

            return Convert.ToInt32(Math.Floor(percentualValue * this.maxHeight / 100));
        }

        private void DefineYAxisLabels(PaintEventArgs pe)
        {
            var maxValue = Math.Ceiling((decimal)DataSource.Values.Max() / 10) * 10;
            var interval = Math.Ceiling(maxValue / 10);
            var myPen = new Pen(Color.Gray);

            for (int i = 0; i < 11; i++)
            {
                var label = new Label();
                var Ylabel = this.Size.Height - (this.Size.Height - maxHeight) / 2 - 6 - (decimal)maxHeight / 10 * i;
                var Yline = this.Size.Height - (this.Size.Height - maxHeight) / 2 - (decimal)maxHeight / 10 * i;
                var point1 = new Point(6, Convert.ToInt32(Yline));
                var point2 = new Point(this.Size.Width, Convert.ToInt32(Yline));

                pe.Graphics.DrawLine(myPen, point1, point2);

                label.Size = new Size(Convert.ToInt32(this.Size.Width * 0.05), 12);
                label.Location = new Point(6, Convert.ToInt32(Ylabel));
                label.Text = (interval * i).ToString();
                label.TextAlign = ContentAlignment.MiddleRight;
                this.Controls.Add(label);
            }
        }

        private void DefineXAxisLabels()
        {
            var numberOfIntervals = DataSource.Count();

            var label = new Label();
            var Y = Size.Height - 25;
            var labelWidth = Convert.ToInt32(this.Size.Width * 0.1); 
            var X = this.Size.Width / 8;

            label.Size = new Size(labelWidth, 12);
            label.Location = new Point(X, Convert.ToInt32(Y));
            label.Text = this.minX.ToString("0.0");
            label.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label);

            foreach (var item in DataSource)
            {
                label = new Label();
                X += Convert.ToInt32(maxWidth / numberOfIntervals) + 1;

                label.Size = new Size(labelWidth, 12);
                label.Location = new Point(X, Convert.ToInt32(Y));
                label.Text = (item.Key).ToString();
                label.TextAlign = ContentAlignment.MiddleLeft;
                this.Controls.Add(label);
                label.BringToFront();
            }
        }
    }
}
