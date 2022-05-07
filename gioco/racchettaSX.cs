using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pong
{
    public class racchettaSX : PictureBox
    {
        public int punto;
        private int speed = 10;
        public racchettaSX()
        {
            this.BackColor = System.Drawing.Color.Blue;
            this.Location = new System.Drawing.Point(22, 190);
            this.Name = "racchetta2";
            this.Size = new System.Drawing.Size(10, 100);
        }

        public void moveSx(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) this.Top -= speed;
            else if (e.KeyCode == Keys.S) this.Top += speed;
        }
    }
}
