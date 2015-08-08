namespace mktm.ts3tools.s3sr
{
    partial class frmUpdate
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
            this.picS3SR = new System.Windows.Forms.PictureBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.linkURL = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picS3SR)).BeginInit();
            this.SuspendLayout();
            // 
            // picS3SR
            // 
            this.picS3SR.Image = global::mktm.ts3tools.s3sr.Properties.Resources.s3sr_48;
            this.picS3SR.Location = new System.Drawing.Point(12, 15);
            this.picS3SR.Name = "picS3SR";
            this.picS3SR.Size = new System.Drawing.Size(51, 49);
            this.picS3SR.TabIndex = 1;
            this.picS3SR.TabStop = false;
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(73, 22);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(311, 13);
            this.lblText1.TabIndex = 2;
            this.lblText1.Text = "There is a new version of this application available for download.";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(74, 45);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(306, 13);
            this.lblText2.TabIndex = 3;
            this.lblText2.Text = "For details and a download link visit the                                     .";
            // 
            // linkURL
            // 
            this.linkURL.AutoSize = true;
            this.linkURL.Location = new System.Drawing.Point(263, 45);
            this.linkURL.Name = "linkURL";
            this.linkURL.Size = new System.Drawing.Size(111, 13);
            this.linkURL.TabIndex = 4;
            this.linkURL.TabStop = true;
            this.linkURL.Text = "application homepage";
            this.linkURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 76);
            this.Controls.Add(this.linkURL);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.picS3SR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::mktm.ts3tools.s3sr.Properties.Resources.help;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Update Available";
            ((System.ComponentModel.ISupportInitialize)(this.picS3SR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picS3SR;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.LinkLabel linkURL;

    }
}