using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ping_pong
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        private List<ball> eleBall = new List<ball>();
       

        private racchettaSX rsx = new racchettaSX();
        private racchettaDX rdx = new racchettaDX();

        void Loop(CancellationToken token)
        {

            while (true)
            {   
                // punteggio
                this.Text = $"{rsx.punto} -------- {rdx.punto}";

                // lb_dx.Text = rdx.punto.ToString();
                // lb_sx.Text = rsx.punto.ToString();

                if (cts.IsCancellationRequested)
                {
                    throw new OperationCanceledException(token);
                }
                else
                {
                    foreach (var s in eleBall)
                    {
                        s.step();
                    }
                }
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CheckForIllegalCrossThreadCalls = false;

            ball b = new ball(rsx, rdx);
            var token = cts.Token;

            #region ottimizzazione grafica
            this.UpdateStyles();
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true
            );
            #endregion

            #region comandi 
            this.KeyDown += rdx.moveDx;
            this.KeyDown += rsx.moveSx;
            this.KeyDown += b.stopped;
            this.KeyDown += crete_ball;
            #endregion

            Controls.Add(rsx);
            Controls.Add(rdx);
            Controls.Add(b);
            eleBall.Add(b);

            Task.Run(() =>  
            {
                try
                {
                    Loop(token);
                }
                catch
                {
                    // Console.WriteLine("aaaa");
                }
            }, token);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {//quando si chiude la form si fermano tutti i thread
            cts.Cancel();
        }

        // creazione di più palle
        private void crete_ball(object sender, KeyEventArgs e)
        {
            // per un massimo di creazione di 7 palline
            var token = cts.Token;
            if (e.KeyCode == Keys.Q)
            {
                ball newBall = new ball(rsx, rdx);
                Controls.Add(newBall);
                eleBall.Add(newBall);
                this.KeyDown += newBall.stopped;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
