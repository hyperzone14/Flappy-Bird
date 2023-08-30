using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_Demon
{
    internal class CircularPicturebox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            using (GraphicsPath gpp = new GraphicsPath())
            {
                gpp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(gpp);
                base.OnPaint(pe);
            }
        }
    }
}
