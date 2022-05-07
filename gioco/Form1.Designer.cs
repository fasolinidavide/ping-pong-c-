
namespace ping_pong
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_sx = new System.Windows.Forms.Label();
            this.lb_dx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_sx
            // 
            this.lb_sx.AutoSize = true;
            this.lb_sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sx.Location = new System.Drawing.Point(12, 9);
            this.lb_sx.Name = "lb_sx";
            this.lb_sx.Size = new System.Drawing.Size(18, 20);
            this.lb_sx.TabIndex = 0;
            this.lb_sx.Text = "0";
            // 
            // lb_dx
            // 
            this.lb_dx.AutoSize = true;
            this.lb_dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dx.Location = new System.Drawing.Point(735, 15);
            this.lb_dx.Name = "lb_dx";
            this.lb_dx.Size = new System.Drawing.Size(18, 20);
            this.lb_dx.TabIndex = 1;
            this.lb_dx.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_dx);
            this.Controls.Add(this.lb_sx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sx;
        private System.Windows.Forms.Label lb_dx;
    }
}

