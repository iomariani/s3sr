namespace mktm.ts3tools.s3sr
{
    partial class frmAbout
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.linkBlog = new System.Windows.Forms.LinkLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.linkGNU = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.linkPeter = new System.Windows.Forms.LinkLabel();
            this.linkAnach = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.picS3SR = new System.Windows.Forms.PictureBox();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.picGNU = new System.Windows.Forms.PictureBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.lblUpdateFalse = new System.Windows.Forms.Label();
            this.radUpdateGUI = new System.Windows.Forms.RadioButton();
            this.radUpdateAlways = new System.Windows.Forms.RadioButton();
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.linkProject = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picS3SR)).BeginInit();
            this.tabLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGNU)).BeginInit();
            this.tabUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBorder.Location = new System.Drawing.Point(16, 92);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(250, 4);
            this.panelBorder.TabIndex = 12;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(26, 144);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(230, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Version ";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(192, 110);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(10, 13);
            this.lblP2.TabIndex = 8;
            this.lblP2.Text = ")";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(81, 110);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(10, 13);
            this.lblP1.TabIndex = 9;
            this.lblP1.Text = "(";
            // 
            // linkBlog
            // 
            this.linkBlog.AutoSize = true;
            this.linkBlog.Location = new System.Drawing.Point(91, 110);
            this.linkBlog.Name = "linkBlog";
            this.linkBlog.Size = new System.Drawing.Size(103, 13);
            this.linkBlog.TabIndex = 7;
            this.linkBlog.TabStop = true;
            this.linkBlog.Text = "http://mktm.co.uk/";
            this.linkBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBlog_LinkClicked);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(26, 66);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "s3sr (Scripter)";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkGNU
            // 
            this.linkGNU.AutoSize = true;
            this.linkGNU.Location = new System.Drawing.Point(77, 123);
            this.linkGNU.Name = "linkGNU";
            this.linkGNU.Size = new System.Drawing.Size(148, 13);
            this.linkGNU.TabIndex = 1;
            this.linkGNU.TabStop = true;
            this.linkGNU.Text = "GNU General Public Licence";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "This application is distributed under the terms of:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Controls.Add(this.tabLicense);
            this.tabControl1.Controls.Add(this.tabUpdate);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(291, 219);
            this.tabControl1.TabIndex = 18;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.linkPeter);
            this.tabAbout.Controls.Add(this.linkAnach);
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Controls.Add(this.picS3SR);
            this.tabAbout.Controls.Add(this.lblDescription);
            this.tabAbout.Controls.Add(this.linkBlog);
            this.tabAbout.Controls.Add(this.lblP1);
            this.tabAbout.Controls.Add(this.lblP2);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.panelBorder);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(283, 193);
            this.tabAbout.TabIndex = 0;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // linkPeter
            // 
            this.linkPeter.AutoSize = true;
            this.linkPeter.Location = new System.Drawing.Point(119, 171);
            this.linkPeter.Name = "linkPeter";
            this.linkPeter.Size = new System.Drawing.Size(76, 13);
            this.linkPeter.TabIndex = 26;
            this.linkPeter.TabStop = true;
            this.linkPeter.Text = "Peter L. Jones";
            // 
            // linkAnach
            // 
            this.linkAnach.AutoSize = true;
            this.linkAnach.Location = new System.Drawing.Point(213, 171);
            this.linkAnach.Name = "linkAnach";
            this.linkAnach.Size = new System.Drawing.Size(39, 13);
            this.linkAnach.TabIndex = 28;
            this.linkAnach.TabStop = true;
            this.linkAnach.Text = "Anach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Special thanks to:                         and";
            // 
            // picS3SR
            // 
            this.picS3SR.Image = global::mktm.ts3tools.s3sr.Properties.Resources.s3sr_48;
            this.picS3SR.Location = new System.Drawing.Point(114, 10);
            this.picS3SR.Name = "picS3SR";
            this.picS3SR.Size = new System.Drawing.Size(51, 49);
            this.picS3SR.TabIndex = 25;
            this.picS3SR.TabStop = false;
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.picGNU);
            this.tabLicense.Controls.Add(this.linkGNU);
            this.tabLicense.Controls.Add(this.label3);
            this.tabLicense.Location = new System.Drawing.Point(4, 22);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(283, 193);
            this.tabLicense.TabIndex = 1;
            this.tabLicense.Text = "License";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // picGNU
            // 
            this.picGNU.Image = global::mktm.ts3tools.s3sr.Properties.Resources.gplv3;
            this.picGNU.Location = new System.Drawing.Point(80, 27);
            this.picGNU.Name = "picGNU";
            this.picGNU.Size = new System.Drawing.Size(127, 51);
            this.picGNU.TabIndex = 26;
            this.picGNU.TabStop = false;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.lblUpdateFalse);
            this.tabUpdate.Controls.Add(this.radUpdateGUI);
            this.tabUpdate.Controls.Add(this.radUpdateAlways);
            this.tabUpdate.Controls.Add(this.cbxUpdate);
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(283, 193);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Updates";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // lblUpdateFalse
            // 
            this.lblUpdateFalse.AutoSize = true;
            this.lblUpdateFalse.Location = new System.Drawing.Point(38, 157);
            this.lblUpdateFalse.Name = "lblUpdateFalse";
            this.lblUpdateFalse.Size = new System.Drawing.Size(227, 13);
            this.lblUpdateFalse.TabIndex = 3;
            this.lblUpdateFalse.Text = "Your software is up to date at the moment.";
            this.lblUpdateFalse.Visible = false;
            // 
            // radUpdateGUI
            // 
            this.radUpdateGUI.AutoSize = true;
            this.radUpdateGUI.Location = new System.Drawing.Point(23, 55);
            this.radUpdateGUI.Name = "radUpdateGUI";
            this.radUpdateGUI.Size = new System.Drawing.Size(66, 17);
            this.radUpdateGUI.TabIndex = 2;
            this.radUpdateGUI.Text = "GUI-only";
            this.radUpdateGUI.UseVisualStyleBackColor = true;
            // 
            // radUpdateAlways
            // 
            this.radUpdateAlways.AutoSize = true;
            this.radUpdateAlways.Checked = true;
            this.radUpdateAlways.Location = new System.Drawing.Point(23, 32);
            this.radUpdateAlways.Name = "radUpdateAlways";
            this.radUpdateAlways.Size = new System.Drawing.Size(58, 17);
            this.radUpdateAlways.TabIndex = 2;
            this.radUpdateAlways.TabStop = true;
            this.radUpdateAlways.Text = "Always";
            this.radUpdateAlways.UseVisualStyleBackColor = true;
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Checked = true;
            this.cbxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUpdate.Location = new System.Drawing.Point(10, 11);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(115, 17);
            this.cbxUpdate.TabIndex = 1;
            this.cbxUpdate.Text = "Check for Updates";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            this.cbxUpdate.Click += new System.EventHandler(this.cbxUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(78, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Check Now";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // linkProject
            // 
            this.linkProject.AutoSize = true;
            this.linkProject.Location = new System.Drawing.Point(232, 14);
            this.linkProject.Name = "linkProject";
            this.linkProject.Size = new System.Drawing.Size(72, 13);
            this.linkProject.TabIndex = 24;
            this.linkProject.TabStop = true;
            this.linkProject.Text = "ts3tools/s3sr";
            this.linkProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProject_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Project: ";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 245);
            this.Controls.Add(this.linkProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::mktm.ts3tools.s3sr.Properties.Resources.help;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About s3sr";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picS3SR)).EndInit();
            this.tabLicense.ResumeLayout(false);
            this.tabLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGNU)).EndInit();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panelBorder;
        internal System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.Label lblP2;
        internal System.Windows.Forms.Label lblP1;
        internal System.Windows.Forms.LinkLabel linkBlog;
        internal System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.LinkLabel linkGNU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.CheckBox cbxUpdate;
        private System.Windows.Forms.RadioButton radUpdateGUI;
        private System.Windows.Forms.RadioButton radUpdateAlways;
        private System.Windows.Forms.Label lblUpdateFalse;
        private System.Windows.Forms.LinkLabel linkProject;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.LinkLabel linkPeter;
        private System.Windows.Forms.LinkLabel linkAnach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picS3SR;
        private System.Windows.Forms.PictureBox picGNU;
    }
}