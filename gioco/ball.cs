using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pong
{
    public class ball : PictureBox
    {
        public bool stoppato = true;
        
        private int moveStepX = 3;
        private int moveStepY = 3;

        private racchettaSX psinistra;
        private racchettaDX pdestra;

        public ball(racchettaSX rs, racchettaDX rd)
        {
            psinistra = rs;
            pdestra = rd;

            this.Location = new System.Drawing.Point(375, 175);
            this.Name = "pallina";
            this.Size = new System.Drawing.Size(50, 50);
            this.BackColor = System.Drawing.Color.Red;
        }

        // TODO:
        #region  da spostare nel loop
        public void step()
        {
            //if (!stoppato)
            //{
                
                this.Location = new Point(this.Location.X + moveStepX, this.Location.Y + moveStepY);

                // collisione con le pareti destra e sinistra
                if (this.Right == Parent.ClientRectangle.Right)
                {
                    this.Location = new Point(375, 175);
                    psinistra.punto = psinistra.punto + 1;
                    stoppato = true;
                }

                if (this.Left == Parent.ClientRectangle.Left)
                {
                    this.Location = new Point(375, 175);
                    pdestra.punto = pdestra.punto + 1;
                    stoppato = true;
                }

                // lo fa rimbalzare sopra e sotto
                if (this.Location.Y < 0 || this.Location.Y + this.Size.Height > Parent.ClientSize.Height || this.Location.Y <= 0)
                {
                    moveStepY = -moveStepY;
                }

                if (this.Bounds.IntersectsWith(psinistra.Bounds) || this.Bounds.IntersectsWith(pdestra.Bounds))
                {
                    moveStepX = -moveStepX;
                }
            //}

        }

        public void stopped(object sender, KeyEventArgs e)
        {
            if (stoppato == true && e.KeyCode == Keys.Z)
            {
                stoppato = false;
            }

        }

        #endregion
    }
}
