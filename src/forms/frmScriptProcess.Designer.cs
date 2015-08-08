namespace mktm.ts3tools.s3sr
{
    partial class frmScriptProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.scriptWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBASE_CASP = new System.Windows.Forms.CheckBox();
            this.cbxBASE_OBJK = new System.Windows.Forms.CheckBox();
            this.cbxBASE_OBJD = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridBASE = new System.Windows.Forms.DataGridView();
            this.colParsed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBASE = new System.Windows.Forms.TabPage();
            this.lblBASE_File = new System.Windows.Forms.Label();
            this.lblBASE_Key = new System.Windows.Forms.Label();
            this.lblBASE_ProcessingKey = new System.Windows.Forms.Label();
            this.tabEP01 = new System.Windows.Forms.TabPage();
            this.tabSP01 = new System.Windows.Forms.TabPage();
            this.tabEP02 = new System.Windows.Forms.TabPage();
            this.tabSP02 = new System.Windows.Forms.TabPage();
            this.tabEP03 = new System.Windows.Forms.TabPage();
            this.tabSP04 = new System.Windows.Forms.TabPage();
            this.tabEP05 = new System.Windows.Forms.TabPage();
            this.VersionImageList = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabSP05 = new System.Windows.Forms.TabPage();
            this.tabEP06 = new System.Windows.Forms.TabPage();
            this.tabSP03 = new System.Windows.Forms.TabPage();
            this.tabEP04 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBASE)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBASE.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processing File:";
            // 
            // scriptWorker
            // 
            this.scriptWorker.WorkerReportsProgress = true;
            this.scriptWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scriptWorker_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxBASE_CASP);
            this.groupBox1.Controls.Add(this.cbxBASE_OBJK);
            this.groupBox1.Controls.Add(this.cbxBASE_OBJD);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // cbxBASE_CASP
            // 
            this.cbxBASE_CASP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxBASE_CASP.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxBASE_CASP.Location = new System.Drawing.Point(375, 19);
            this.cbxBASE_CASP.Name = "cbxBASE_CASP";
            this.cbxBASE_CASP.Size = new System.Drawing.Size(80, 24);
            this.cbxBASE_CASP.TabIndex = 3;
            this.cbxBASE_CASP.Text = "CASP";
            this.cbxBASE_CASP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxBASE_CASP.UseVisualStyleBackColor = true;
            // 
            // cbxBASE_OBJK
            // 
            this.cbxBASE_OBJK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxBASE_OBJK.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxBASE_OBJK.Location = new System.Drawing.Point(265, 19);
            this.cbxBASE_OBJK.Name = "cbxBASE_OBJK";
            this.cbxBASE_OBJK.Size = new System.Drawing.Size(80, 24);
            this.cbxBASE_OBJK.TabIndex = 3;
            this.cbxBASE_OBJK.Text = "OBJK";
            this.cbxBASE_OBJK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxBASE_OBJK.UseVisualStyleBackColor = true;
            // 
            // cbxBASE_OBJD
            // 
            this.cbxBASE_OBJD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxBASE_OBJD.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxBASE_OBJD.Checked = true;
            this.cbxBASE_OBJD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBASE_OBJD.Location = new System.Drawing.Point(155, 19);
            this.cbxBASE_OBJD.Name = "cbxBASE_OBJD";
            this.cbxBASE_OBJD.Size = new System.Drawing.Size(80, 24);
            this.cbxBASE_OBJD.TabIndex = 3;
            this.cbxBASE_OBJD.Text = "OBJD";
            this.cbxBASE_OBJD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxBASE_OBJD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridBASE);
            this.groupBox2.Location = new System.Drawing.Point(10, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.groupBox2.Size = new System.Drawing.Size(593, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gridBASE
            // 
            this.gridBASE.AllowUserToAddRows = false;
            this.gridBASE.AllowUserToDeleteRows = false;
            this.gridBASE.AllowUserToResizeRows = false;
            this.gridBASE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBASE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParsed,
            this.colName,
            this.colType,
            this.colGroup,
            this.colInstance,
            this.colAttributes});
            this.gridBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBASE.Location = new System.Drawing.Point(10, 18);
            this.gridBASE.Name = "gridBASE";
            this.gridBASE.ReadOnly = true;
            this.gridBASE.RowHeadersVisible = false;
            this.gridBASE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBASE.Size = new System.Drawing.Size(573, 186);
            this.gridBASE.TabIndex = 0;
            // 
            // colParsed
            // 
            this.colParsed.HeaderText = "";
            this.colParsed.MinimumWidth = 25;
            this.colParsed.Name = "colParsed";
            this.colParsed.ReadOnly = true;
            this.colParsed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colParsed.Width = 25;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 60;
            // 
            // colGroup
            // 
            this.colGroup.HeaderText = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 80;
            // 
            // colInstance
            // 
            this.colInstance.HeaderText = "Instance";
            this.colInstance.Name = "colInstance";
            this.colInstance.ReadOnly = true;
            this.colInstance.Width = 110;
            // 
            // colAttributes
            // 
            this.colAttributes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAttributes.HeaderText = "Attributes";
            this.colAttributes.Name = "colAttributes";
            this.colAttributes.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabBASE);
            this.tabControl1.Controls.Add(this.tabEP01);
            this.tabControl1.Controls.Add(this.tabSP01);
            this.tabControl1.Controls.Add(this.tabEP02);
            this.tabControl1.Controls.Add(this.tabSP02);
            this.tabControl1.Controls.Add(this.tabEP03);
            this.tabControl1.Controls.Add(this.tabSP03);
            this.tabControl1.Controls.Add(this.tabEP04);
            this.tabControl1.Controls.Add(this.tabSP04);
            this.tabControl1.Controls.Add(this.tabEP05);
            this.tabControl1.Controls.Add(this.tabSP05);
            this.tabControl1.Controls.Add(this.tabEP06);
            this.tabControl1.ImageList = this.VersionImageList;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(7, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 386);
            this.tabControl1.TabIndex = 27;
            // 
            // tabBASE
            // 
            this.tabBASE.BackColor = System.Drawing.SystemColors.Control;
            this.tabBASE.Controls.Add(this.lblBASE_File);
            this.tabBASE.Controls.Add(this.lblBASE_Key);
            this.tabBASE.Controls.Add(this.lblBASE_ProcessingKey);
            this.tabBASE.Controls.Add(this.label1);
            this.tabBASE.Controls.Add(this.groupBox1);
            this.tabBASE.ImageIndex = 0;
            this.tabBASE.Location = new System.Drawing.Point(4, 30);
            this.tabBASE.Name = "tabBASE";
            this.tabBASE.Padding = new System.Windows.Forms.Padding(3);
            this.tabBASE.Size = new System.Drawing.Size(641, 352);
            this.tabBASE.TabIndex = 0;
            this.tabBASE.Text = "BASE";
            // 
            // lblBASE_File
            // 
            this.lblBASE_File.AutoSize = true;
            this.lblBASE_File.Location = new System.Drawing.Point(102, 15);
            this.lblBASE_File.Name = "lblBASE_File";
            this.lblBASE_File.Size = new System.Drawing.Size(40, 13);
            this.lblBASE_File.TabIndex = 2;
            this.lblBASE_File.Text = "<KEY>";
            // 
            // lblBASE_Key
            // 
            this.lblBASE_Key.AutoSize = true;
            this.lblBASE_Key.Location = new System.Drawing.Point(102, 38);
            this.lblBASE_Key.Name = "lblBASE_Key";
            this.lblBASE_Key.Size = new System.Drawing.Size(40, 13);
            this.lblBASE_Key.TabIndex = 0;
            this.lblBASE_Key.Text = "<KEY>";
            // 
            // lblBASE_ProcessingKey
            // 
            this.lblBASE_ProcessingKey.AutoSize = true;
            this.lblBASE_ProcessingKey.Location = new System.Drawing.Point(13, 37);
            this.lblBASE_ProcessingKey.Name = "lblBASE_ProcessingKey";
            this.lblBASE_ProcessingKey.Size = new System.Drawing.Size(83, 13);
            this.lblBASE_ProcessingKey.TabIndex = 0;
            this.lblBASE_ProcessingKey.Text = "Processing Key:";
            // 
            // tabEP01
            // 
            this.tabEP01.ImageIndex = 1;
            this.tabEP01.Location = new System.Drawing.Point(4, 30);
            this.tabEP01.Name = "tabEP01";
            this.tabEP01.Padding = new System.Windows.Forms.Padding(3);
            this.tabEP01.Size = new System.Drawing.Size(641, 352);
            this.tabEP01.TabIndex = 1;
            this.tabEP01.Text = "EP01";
            this.tabEP01.UseVisualStyleBackColor = true;
            // 
            // tabSP01
            // 
            this.tabSP01.ImageIndex = 2;
            this.tabSP01.Location = new System.Drawing.Point(4, 30);
            this.tabSP01.Name = "tabSP01";
            this.tabSP01.Padding = new System.Windows.Forms.Padding(3);
            this.tabSP01.Size = new System.Drawing.Size(641, 352);
            this.tabSP01.TabIndex = 2;
            this.tabSP01.Text = "SP01";
            this.tabSP01.UseVisualStyleBackColor = true;
            // 
            // tabEP02
            // 
            this.tabEP02.ImageIndex = 3;
            this.tabEP02.Location = new System.Drawing.Point(4, 30);
            this.tabEP02.Name = "tabEP02";
            this.tabEP02.Padding = new System.Windows.Forms.Padding(3);
            this.tabEP02.Size = new System.Drawing.Size(641, 352);
            this.tabEP02.TabIndex = 3;
            this.tabEP02.Text = "EP02";
            this.tabEP02.UseVisualStyleBackColor = true;
            // 
            // tabSP02
            // 
            this.tabSP02.ImageIndex = 4;
            this.tabSP02.Location = new System.Drawing.Point(4, 30);
            this.tabSP02.Name = "tabSP02";
            this.tabSP02.Padding = new System.Windows.Forms.Padding(3);
            this.tabSP02.Size = new System.Drawing.Size(641, 352);
            this.tabSP02.TabIndex = 4;
            this.tabSP02.Text = "SP02";
            this.tabSP02.UseVisualStyleBackColor = true;
            // 
            // tabEP03
            // 
            this.tabEP03.ImageIndex = 5;
            this.tabEP03.Location = new System.Drawing.Point(4, 30);
            this.tabEP03.Name = "tabEP03";
            this.tabEP03.Size = new System.Drawing.Size(641, 352);
            this.tabEP03.TabIndex = 5;
            this.tabEP03.Text = "EP03";
            this.tabEP03.UseVisualStyleBackColor = true;
            // 
            // tabSP04
            // 
            this.tabSP04.ImageIndex = 8;
            this.tabSP04.Location = new System.Drawing.Point(4, 30);
            this.tabSP04.Name = "tabSP04";
            this.tabSP04.Size = new System.Drawing.Size(641, 352);
            this.tabSP04.TabIndex = 6;
            this.tabSP04.Text = "SP04";
            this.tabSP04.UseVisualStyleBackColor = true;
            // 
            // tabEP05
            // 
            this.tabEP05.ImageIndex = 9;
            this.tabEP05.Location = new System.Drawing.Point(4, 30);
            this.tabEP05.Name = "tabEP05";
            this.tabEP05.Padding = new System.Windows.Forms.Padding(3);
            this.tabEP05.Size = new System.Drawing.Size(641, 352);
            this.tabEP05.TabIndex = 7;
            this.tabEP05.Text = "EP05";
            this.tabEP05.UseVisualStyleBackColor = true;
            // 
            // VersionImageList
            // 
            this.VersionImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.VersionImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.VersionImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 404);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(645, 38);
            this.progressBar1.TabIndex = 28;
            // 
            // tabSP05
            // 
            this.tabSP05.ImageIndex = 10;
            this.tabSP05.Location = new System.Drawing.Point(4, 30);
            this.tabSP05.Name = "tabSP05";
            this.tabSP05.Size = new System.Drawing.Size(641, 352);
            this.tabSP05.TabIndex = 8;
            this.tabSP05.Text = "SP05";
            this.tabSP05.UseVisualStyleBackColor = true;
            // 
            // tabEP06
            // 
            this.tabEP06.ImageIndex = 11;
            this.tabEP06.Location = new System.Drawing.Point(4, 30);
            this.tabEP06.Name = "tabEP06";
            this.tabEP06.Size = new System.Drawing.Size(641, 352);
            this.tabEP06.TabIndex = 9;
            this.tabEP06.Text = "EP06";
            this.tabEP06.UseVisualStyleBackColor = true;
            // 
            // tabSP03
            // 
            this.tabSP03.ImageIndex = 6;
            this.tabSP03.Location = new System.Drawing.Point(4, 30);
            this.tabSP03.Name = "tabSP03";
            this.tabSP03.Size = new System.Drawing.Size(641, 352);
            this.tabSP03.TabIndex = 10;
            this.tabSP03.Text = "SP03";
            this.tabSP03.UseVisualStyleBackColor = true;
            // 
            // tabEP04
            // 
            this.tabEP04.ImageIndex = 7;
            this.tabEP04.Location = new System.Drawing.Point(4, 30);
            this.tabEP04.Name = "tabEP04";
            this.tabEP04.Size = new System.Drawing.Size(641, 352);
            this.tabEP04.TabIndex = 11;
            this.tabEP04.Text = "EP04";
            this.tabEP04.UseVisualStyleBackColor = true;
            // 
            // frmScriptProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 457);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Icon = global::mktm.ts3tools.s3sr.Properties.Resources.s3sr_icon;
            this.Name = "frmScriptProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processing Script";
            this.Load += new System.EventHandler(this.frmScriptProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBASE)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBASE.ResumeLayout(false);
            this.tabBASE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker scriptWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridBASE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBASE;
        private System.Windows.Forms.TabPage tabEP01;
        private System.Windows.Forms.ImageList VersionImageList;
        private System.Windows.Forms.TabPage tabSP01;
        private System.Windows.Forms.TabPage tabEP02;
        private System.Windows.Forms.TabPage tabSP02;
        private System.Windows.Forms.TabPage tabEP03;
        private System.Windows.Forms.Label lblBASE_ProcessingKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colParsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttributes;
        private System.Windows.Forms.Label lblBASE_Key;
        private System.Windows.Forms.Label lblBASE_File;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabSP04;
        private System.Windows.Forms.CheckBox cbxBASE_CASP;
        private System.Windows.Forms.CheckBox cbxBASE_OBJK;
        private System.Windows.Forms.CheckBox cbxBASE_OBJD;
        private System.Windows.Forms.TabPage tabEP05;
        private System.Windows.Forms.TabPage tabSP03;
        private System.Windows.Forms.TabPage tabEP04;
        private System.Windows.Forms.TabPage tabSP05;
        private System.Windows.Forms.TabPage tabEP06;
    }
}