using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace RSVCharts
{
    public partial class Graphs : UserControl
    {
        private int initialGroupBoxHeight;
        public Graphs()
        {
            InitializeComponent();
        }

        private void splitContainer6_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int middleY = panel2.Height / 2;
            int lineLength = panel2.Width; // Set the length of the dashed lines to match the width of the panel
            int gap = 15; // Set the gap between the two lines

            // Calculate the Y positions for the two dashed lines
            int topLineY = middleY - gap / 2;
            int bottomLineY = middleY + gap / 2;

            // Draw dashed lines at the middle of the Panel
            using (Pen pen = new Pen(Color.Black))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                // Draw the top line
                e.Graphics.DrawLine(pen, new Point(0, topLineY), new Point(lineLength, topLineY));

                // Draw the bottom line
                e.Graphics.DrawLine(pen, new Point(0, bottomLineY), new Point(lineLength, bottomLineY));
            }
        }
    }
}
