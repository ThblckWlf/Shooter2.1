namespace Shooter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zeichner = new System.Windows.Forms.Timer(this.components);
            this.kills = new System.Windows.Forms.Label();
            this.muni = new System.Windows.Forms.Label();
            this.granaten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zeichner
            // 
            this.zeichner.Enabled = true;
            this.zeichner.Interval = 70;
            this.zeichner.Tick += new System.EventHandler(this.zeichner_Tick);
            // 
            // kills
            // 
            this.kills.AutoSize = true;
            this.kills.Location = new System.Drawing.Point(319, 9);
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(53, 20);
            this.kills.TabIndex = 0;
            this.kills.Text = "Kills: 0";
            this.kills.Click += new System.EventHandler(this.label1_Click);
            // 
            // muni
            // 
            this.muni.AutoSize = true;
            this.muni.Location = new System.Drawing.Point(524, 9);
            this.muni.Name = "muni";
            this.muni.Size = new System.Drawing.Size(77, 20);
            this.muni.TabIndex = 1;
            this.muni.Text = "Munition: ";
            // 
            // granaten
            // 
            this.granaten.AutoSize = true;
            this.granaten.Location = new System.Drawing.Point(607, 9);
            this.granaten.Name = "granaten";
            this.granaten.Size = new System.Drawing.Size(81, 20);
            this.granaten.TabIndex = 2;
            this.granaten.Text = "Granaten:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.granaten);
            this.Controls.Add(this.muni);
            this.Controls.Add(this.kills);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Zombiehoorde";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer zeichner;
        public System.Windows.Forms.Label kills;
        private System.Windows.Forms.Label muni;
        private System.Windows.Forms.Label granaten;
    }
}

