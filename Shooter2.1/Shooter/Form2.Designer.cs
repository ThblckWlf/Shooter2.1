namespace Shooter
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lebencop = new System.Windows.Forms.Button();
            this.granatencop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lebencop
            // 
            this.lebencop.Location = new System.Drawing.Point(427, 195);
            this.lebencop.Name = "lebencop";
            this.lebencop.Size = new System.Drawing.Size(137, 57);
            this.lebencop.TabIndex = 0;
            this.lebencop.Text = "Leben +1";
            this.lebencop.UseVisualStyleBackColor = true;
            this.lebencop.Click += new System.EventHandler(this.lebencop_Click);
            // 
            // granatencop
            // 
            this.granatencop.Location = new System.Drawing.Point(427, 324);
            this.granatencop.Name = "granatencop";
            this.granatencop.Size = new System.Drawing.Size(137, 61);
            this.granatencop.TabIndex = 1;
            this.granatencop.Text = "Granaten +1";
            this.granatencop.UseVisualStyleBackColor = true;
            this.granatencop.Click += new System.EventHandler(this.granatencop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.granatencop);
            this.Controls.Add(this.lebencop);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lebencop;
        private System.Windows.Forms.Button granatencop;
        private System.Windows.Forms.Button button1;
    }
}