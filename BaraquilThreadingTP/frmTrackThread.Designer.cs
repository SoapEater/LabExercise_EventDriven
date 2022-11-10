namespace BaraquilThreadingTP
{
    partial class frmTrackThread
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
            this.LabelThread = new System.Windows.Forms.Label();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelThread
            // 
            this.LabelThread.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelThread.AutoSize = true;
            this.LabelThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThread.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelThread.Location = new System.Drawing.Point(46, 9);
            this.LabelThread.Name = "LabelThread";
            this.LabelThread.Size = new System.Drawing.Size(122, 20);
            this.LabelThread.TabIndex = 0;
            this.LabelThread.Text = "-Thread Start-";
            this.LabelThread.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(72, 54);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(75, 23);
            this.ButtonRun.TabIndex = 1;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 104);
            this.Controls.Add(this.ButtonRun);
            this.Controls.Add(this.LabelThread);
            this.Name = "frmTrackThread";
            this.Text = "frmTrackThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelThread;
        private System.Windows.Forms.Button ButtonRun;
    }
}

