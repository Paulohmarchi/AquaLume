namespace project_AquaLumia
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.pbCarrega = new System.Windows.Forms.ProgressBar();
            this.pbcCarrega = new System.Windows.Forms.PictureBox();
            this.pbSlpash = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbcCarrega)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCarrega
            // 
            this.pbCarrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCarrega.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pbCarrega.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pbCarrega.Location = new System.Drawing.Point(14, 391);
            this.pbCarrega.Name = "pbCarrega";
            this.pbCarrega.Size = new System.Drawing.Size(573, 0);
            this.pbCarrega.TabIndex = 5;
            // 
            // pbcCarrega
            // 
            this.pbcCarrega.Location = new System.Drawing.Point(-4, -4);
            this.pbcCarrega.Name = "pbcCarrega";
            this.pbcCarrega.Size = new System.Drawing.Size(654, 375);
            this.pbcCarrega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcCarrega.TabIndex = 4;
            this.pbcCarrega.TabStop = false;
            // 
            // pbSlpash
            // 
            this.pbSlpash.Enabled = false;
            this.pbSlpash.Location = new System.Drawing.Point(14, 386);
            this.pbSlpash.Name = "pbSlpash";
            this.pbSlpash.Size = new System.Drawing.Size(627, 23);
            this.pbSlpash.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 421);
            this.Controls.Add(this.pbSlpash);
            this.Controls.Add(this.pbCarrega);
            this.Controls.Add(this.pbcCarrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pbcCarrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar pbCarrega;
        private System.Windows.Forms.PictureBox pbcCarrega;
        private System.Windows.Forms.ProgressBar pbSlpash;
        private System.Windows.Forms.Timer timer1;
    }
}