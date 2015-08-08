namespace s3sr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBASE = new System.Windows.Forms.TabPage();
            this.tabEP01 = new System.Windows.Forms.TabPage();
            this.VersionImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabSP01 = new System.Windows.Forms.TabPage();
            this.tabEP02 = new System.Windows.Forms.TabPage();
            this.tabSP02 = new System.Windows.Forms.TabPage();
            this.tabEP03 = new System.Windows.Forms.TabPage();
            this.lblBASE_ProcessingKey = new System.Windows.Forms.Label();
            this.colParsed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBASE_Key = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBASE.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParsed,
            this.colName,
            this.colType,
            this.colGroup,
            this.colInstance,
            this.colAttributes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(566, 95);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabBASE);
            this.tabControl1.Controls.Add(this.tabEP01);
            this.tabControl1.Controls.Add(this.tabSP01);
            this.tabControl1.Controls.Add(this.tabEP02);
            this.tabControl1.Controls.Add(this.tabSP02);
            this.tabControl1.Controls.Add(this.tabEP03);
            this.tabControl1.ImageList = this.VersionImageList;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(7, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 437);
            this.tabControl1.TabIndex = 27;
            // 
            // tabBASE
            // 
            this.tabBASE.BackColor = System.Drawing.SystemColors.Control;
            this.tabBASE.Controls.Add(this.lblBASE_Key);
            this.tabBASE.Controls.Add(this.lblBASE_ProcessingKey);
            this.tabBASE.Controls.Add(this.label1);
            this.tabBASE.Controls.Add(this.groupBox1);
            this.tabBASE.ImageIndex = 0;
            this.tabBASE.Location = new System.Drawing.Point(4, 30);
            this.tabBASE.Name = "tabBASE";
            this.tabBASE.Padding = new System.Windows.Forms.Padding(3);
            this.tabBASE.Size = new System.Drawing.Size(645, 403);
            this.tabBASE.TabIndex = 0;
            this.tabBASE.Text = "BASE";
            // 
            // tabEP01
            // 
            this.tabEP01.ImageIndex = 1;
            this.tabEP01.Location = new System.Drawing.Point(4, 30);
            this.tabEP01.Name = "tabEP01";
            this.tabEP01.Padding = new System.Windows.Forms.Padding(3);
            this.tabEP01.Size = new System.Drawing.Size(645, 403);
            this.tabEP01.TabIndex = 1;
            this.tabEP01.Text = "EP01";
            this.tabEP01.UseVisualStyleBackColor = true;
            // 
            // VersionImageList
            // 
            this.VersionImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.VersionImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.VersionImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabSP01
            // 
            this.tabSP01.ImageIndex = 2;
            this.tabSP01.Location = new System.Drawing.Point(4, 30);
            this.tabSP01.Name = "tabSP01";
            this.tabSP01.Padding = new System.Windows.Forms.Padding(3);
            this.tabSP01.Size = new System.Drawing.Size(645, 403);
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
            this.tabEP02.Size = new System.Drawing.Size(645, 403);
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
            this.tabSP02.Size = new System.Drawing.Size(645, 403);
            this.tabSP02.TabIndex = 4;
            this.tabSP02.Text = "SP02";
            this.tabSP02.UseVisualStyleBackColor = true;
            // 
            // tabEP03
            // 
            this.tabEP03.ImageIndex = 5;
            this.tabEP03.Location = new System.Drawing.Point(4, 30);
            this.tabEP03.Name = "tabEP03";
            this.tabEP03.Size = new System.Drawing.Size(645, 403);
            this.tabEP03.TabIndex = 5;
            this.tabEP03.Text = "EP03";
            this.tabEP03.UseVisualStyleBackColor = true;
            // 
            // lblBASE_ProcessingKey
            // 
            this.lblBASE_ProcessingKey.AutoSize = true;
            this.lblBASE_ProcessingKey.Location = new System.Drawing.Point(10, 34);
            this.lblBASE_ProcessingKey.Name = "lblBASE_ProcessingKey";
            this.lblBASE_ProcessingKey.Size = new System.Drawing.Size(83, 13);
            this.lblBASE_ProcessingKey.TabIndex = 0;
            this.lblBASE_ProcessingKey.Text = "Processing Key:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OBJD";
            // 
            // lblBASE_Key
            // 
            this.lblBASE_Key.AutoSize = true;
            this.lblBASE_Key.Location = new System.Drawing.Point(99, 35);
            this.lblBASE_Key.Name = "lblBASE_Key";
            this.lblBASE_Key.Size = new System.Drawing.Size(40, 13);
            this.lblBASE_Key.TabIndex = 0;
            this.lblBASE_Key.Text = "<KEY>";
            // 
            // frmScriptProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 476);
            this.Controls.Add(this.tabControl1);
            this.Icon = global::s3sr.Properties.Resources.s3sr_icon;
            this.Name = "frmScriptProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processing Script";
            this.Load += new System.EventHandler(this.frmScriptProcess_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBASE.ResumeLayout(false);
            this.tabBASE.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker scriptWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}