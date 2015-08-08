namespace mktm.ts3tools.s3sr
{
    partial class frmGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.grpOutputPath = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdOutputPath = new System.Windows.Forms.Button();
            this.cbxInfoAlert = new System.Windows.Forms.CheckBox();
            this.grpSettingsAll = new System.Windows.Forms.GroupBox();
            this.GamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.radStore = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.radBASE = new System.Windows.Forms.RadioButton();
            this.cbxDecryptFiles = new System.Windows.Forms.CheckBox();
            this.cbxUseStoreAlternativePath = new System.Windows.Forms.CheckBox();
            this.grpStoreAlternativePath = new System.Windows.Forms.GroupBox();
            this.txtStoreAlternativePath = new System.Windows.Forms.TextBox();
            this.cbxStoreAlternativeSubfiles = new System.Windows.Forms.CheckBox();
            this.cmdStoreAlternativePath = new System.Windows.Forms.Button();
            this.grpGamePath = new System.Windows.Forms.GroupBox();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.cbxCustomSubfiles = new System.Windows.Forms.CheckBox();
            this.cmdGamePath = new System.Windows.Forms.Button();
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.cbxScriptDEP_EX = new System.Windows.Forms.CheckBox();
            this.cbxScriptDEP_DUPINST = new System.Windows.Forms.CheckBox();
            this.cbxScriptDEP = new System.Windows.Forms.CheckBox();
            this.cbxAdvancedStatistics = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.grpDepuration = new System.Windows.Forms.GroupBox();
            this.panelScriptDEP = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpSettings.SuspendLayout();
            this.grpOutputPath.SuspendLayout();
            this.grpSettingsAll.SuspendLayout();
            this.GamesPanel.SuspendLayout();
            this.grpStoreAlternativePath.SuspendLayout();
            this.grpGamePath.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.grpDepuration.SuspendLayout();
            this.panelScriptDEP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSettings.Controls.Add(this.grpOutputPath);
            this.grpSettings.Controls.Add(this.cbxInfoAlert);
            this.grpSettings.Controls.Add(this.grpSettingsAll);
            this.grpSettings.Location = new System.Drawing.Point(6, 6);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(658, 313);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = " Settings ";
            // 
            // grpOutputPath
            // 
            this.grpOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpOutputPath.Controls.Add(this.txtOutput);
            this.grpOutputPath.Controls.Add(this.cmdOutputPath);
            this.grpOutputPath.Location = new System.Drawing.Point(10, 249);
            this.grpOutputPath.Name = "grpOutputPath";
            this.grpOutputPath.Size = new System.Drawing.Size(642, 51);
            this.grpOutputPath.TabIndex = 11;
            this.grpOutputPath.TabStop = false;
            this.grpOutputPath.Text = " Output Package Path";
            this.tipHelper.SetToolTip(this.grpOutputPath, "The Location where the Output Package will be saved to");
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(15, 20);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(586, 22);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.Text = "<PATH>";
            // 
            // cmdOutputPath
            // 
            this.cmdOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOutputPath.Location = new System.Drawing.Point(607, 18);
            this.cmdOutputPath.Name = "cmdOutputPath";
            this.cmdOutputPath.Size = new System.Drawing.Size(25, 23);
            this.cmdOutputPath.TabIndex = 11;
            this.cmdOutputPath.Text = "...";
            this.tipHelper.SetToolTip(this.cmdOutputPath, "Set the location of where the Output Package will be saved");
            this.cmdOutputPath.UseVisualStyleBackColor = true;
            this.cmdOutputPath.Click += new System.EventHandler(this.cmdOutputPath_Click);
            // 
            // cbxInfoAlert
            // 
            this.cbxInfoAlert.AutoSize = true;
            this.cbxInfoAlert.Location = new System.Drawing.Point(20, 24);
            this.cbxInfoAlert.Name = "cbxInfoAlert";
            this.cbxInfoAlert.Size = new System.Drawing.Size(173, 17);
            this.cbxInfoAlert.TabIndex = 6;
            this.cbxInfoAlert.Text = "Always Show Information Alerts";
            this.tipHelper.SetToolTip(this.cbxInfoAlert, "Shows information after script runs.\r\nExample: Script Processed");
            this.cbxInfoAlert.UseVisualStyleBackColor = true;
            // 
            // grpSettingsAll
            // 
            this.grpSettingsAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSettingsAll.Controls.Add(this.GamesPanel);
            this.grpSettingsAll.Controls.Add(this.cbxDecryptFiles);
            this.grpSettingsAll.Controls.Add(this.cbxUseStoreAlternativePath);
            this.grpSettingsAll.Controls.Add(this.grpStoreAlternativePath);
            this.grpSettingsAll.Controls.Add(this.grpGamePath);
            this.grpSettingsAll.Location = new System.Drawing.Point(10, 47);
            this.grpSettingsAll.Name = "grpSettingsAll";
            this.grpSettingsAll.Size = new System.Drawing.Size(642, 195);
            this.grpSettingsAll.TabIndex = 5;
            this.grpSettingsAll.TabStop = false;
            // 
            // GamesPanel
            // 
            this.GamesPanel.AutoSize = true;
            this.GamesPanel.Controls.Add(this.radStore);
            this.GamesPanel.Controls.Add(this.radCustom);
            this.GamesPanel.Controls.Add(this.radBASE);
            this.GamesPanel.Location = new System.Drawing.Point(6, 14);
            this.GamesPanel.MaximumSize = new System.Drawing.Size(161, 999);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(161, 76);
            this.GamesPanel.TabIndex = 16;
            this.GamesPanel.SizeChanged += new System.EventHandler(this.GamesPanel_SizeChanged);
            // 
            // radStore
            // 
            this.radStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radStore.Image = global::mktm.ts3tools.s3sr.Properties.Resources.store_icon_16;
            this.radStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radStore.Location = new System.Drawing.Point(3, 3);
            this.radStore.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.radStore.Name = "radStore";
            this.radStore.Size = new System.Drawing.Size(155, 24);
            this.radStore.TabIndex = 4;
            this.radStore.Tag = "STORE";
            this.radStore.Text = "      Store";
            this.tipHelper.SetToolTip(this.radStore, "Store Content Settings");
            this.radStore.UseVisualStyleBackColor = true;
            // 
            // radCustom
            // 
            this.radCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radCustom.Image = global::mktm.ts3tools.s3sr.Properties.Resources.plumbob_16;
            this.radCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCustom.Location = new System.Drawing.Point(3, 27);
            this.radCustom.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(155, 24);
            this.radCustom.TabIndex = 4;
            this.radCustom.Tag = "CUSTOM";
            this.radCustom.Text = "      Custom";
            this.tipHelper.SetToolTip(this.radCustom, "Custom Content Settings");
            this.radCustom.UseVisualStyleBackColor = true;
            // 
            // radBASE
            // 
            this.radBASE.Image = global::mktm.ts3tools.s3sr.Properties.Resources.Sims3_16;
            this.radBASE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radBASE.Location = new System.Drawing.Point(3, 51);
            this.radBASE.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBASE.Name = "radBASE";
            this.radBASE.Size = new System.Drawing.Size(155, 24);
            this.radBASE.TabIndex = 3;
            this.radBASE.Tag = "BASE";
            this.radBASE.Text = "      Base Game";
            this.tipHelper.SetToolTip(this.radBASE, "Base Game Path Settings");
            this.radBASE.UseVisualStyleBackColor = true;
            // 
            // cbxDecryptFiles
            // 
            this.cbxDecryptFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxDecryptFiles.AutoSize = true;
            this.cbxDecryptFiles.Location = new System.Drawing.Point(168, 172);
            this.cbxDecryptFiles.Name = "cbxDecryptFiles";
            this.cbxDecryptFiles.Size = new System.Drawing.Size(121, 17);
            this.cbxDecryptFiles.TabIndex = 2;
            this.cbxDecryptFiles.Text = "Decrypt Store Files";
            this.tipHelper.SetToolTip(this.cbxDecryptFiles, "If checked, the application will attempt to decrypt encrypted Store content (DBPP" +
        ");\r\nOnly check in case you have paid content from the Store.");
            this.cbxDecryptFiles.UseVisualStyleBackColor = true;
            this.cbxDecryptFiles.Visible = false;
            // 
            // cbxUseStoreAlternativePath
            // 
            this.cbxUseStoreAlternativePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUseStoreAlternativePath.AutoSize = true;
            this.cbxUseStoreAlternativePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUseStoreAlternativePath.Location = new System.Drawing.Point(185, 92);
            this.cbxUseStoreAlternativePath.Name = "cbxUseStoreAlternativePath";
            this.cbxUseStoreAlternativePath.Size = new System.Drawing.Size(160, 17);
            this.cbxUseStoreAlternativePath.TabIndex = 12;
            this.cbxUseStoreAlternativePath.Text = "Alternative Directory Path";
            this.tipHelper.SetToolTip(this.cbxUseStoreAlternativePath, "Alternative Path of Store Content");
            this.cbxUseStoreAlternativePath.UseVisualStyleBackColor = true;
            this.cbxUseStoreAlternativePath.Visible = false;
            this.cbxUseStoreAlternativePath.CheckedChanged += new System.EventHandler(this.cbxUseStoreAlternativePath_CheckedChanged);
            // 
            // grpStoreAlternativePath
            // 
            this.grpStoreAlternativePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStoreAlternativePath.Controls.Add(this.txtStoreAlternativePath);
            this.grpStoreAlternativePath.Controls.Add(this.cbxStoreAlternativeSubfiles);
            this.grpStoreAlternativePath.Controls.Add(this.cmdStoreAlternativePath);
            this.grpStoreAlternativePath.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grpStoreAlternativePath.Location = new System.Drawing.Point(173, 93);
            this.grpStoreAlternativePath.Name = "grpStoreAlternativePath";
            this.grpStoreAlternativePath.Size = new System.Drawing.Size(459, 74);
            this.grpStoreAlternativePath.TabIndex = 12;
            this.grpStoreAlternativePath.TabStop = false;
            this.grpStoreAlternativePath.Text = "  StoreAlternative";
            this.tipHelper.SetToolTip(this.grpStoreAlternativePath, "Alternative Path of Store Content");
            this.grpStoreAlternativePath.Visible = false;
            // 
            // txtStoreAlternativePath
            // 
            this.txtStoreAlternativePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreAlternativePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreAlternativePath.Location = new System.Drawing.Point(15, 20);
            this.txtStoreAlternativePath.Name = "txtStoreAlternativePath";
            this.txtStoreAlternativePath.ReadOnly = true;
            this.txtStoreAlternativePath.Size = new System.Drawing.Size(403, 20);
            this.txtStoreAlternativePath.TabIndex = 6;
            this.txtStoreAlternativePath.Text = "<PATH>";
            // 
            // cbxStoreAlternativeSubfiles
            // 
            this.cbxStoreAlternativeSubfiles.AutoSize = true;
            this.cbxStoreAlternativeSubfiles.Location = new System.Drawing.Point(15, 47);
            this.cbxStoreAlternativeSubfiles.Name = "cbxStoreAlternativeSubfiles";
            this.cbxStoreAlternativeSubfiles.Size = new System.Drawing.Size(142, 17);
            this.cbxStoreAlternativeSubfiles.TabIndex = 6;
            this.cbxStoreAlternativeSubfiles.Text = "Include Subfolder files";
            this.tipHelper.SetToolTip(this.cbxStoreAlternativeSubfiles, "Check this if you want the Script to browse all files in all directories within t" +
        "he directory selected above.");
            this.cbxStoreAlternativeSubfiles.UseVisualStyleBackColor = true;
            // 
            // cmdStoreAlternativePath
            // 
            this.cmdStoreAlternativePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStoreAlternativePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStoreAlternativePath.Location = new System.Drawing.Point(424, 18);
            this.cmdStoreAlternativePath.Name = "cmdStoreAlternativePath";
            this.cmdStoreAlternativePath.Size = new System.Drawing.Size(25, 23);
            this.cmdStoreAlternativePath.TabIndex = 11;
            this.cmdStoreAlternativePath.Text = "...";
            this.tipHelper.SetToolTip(this.cmdStoreAlternativePath, "Set the location of the Alternative Store Path");
            this.cmdStoreAlternativePath.UseVisualStyleBackColor = true;
            this.cmdStoreAlternativePath.Click += new System.EventHandler(this.cmdStoreAlternativePath_Click);
            // 
            // grpGamePath
            // 
            this.grpGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGamePath.Controls.Add(this.txtGamePath);
            this.grpGamePath.Controls.Add(this.cbxCustomSubfiles);
            this.grpGamePath.Controls.Add(this.cmdGamePath);
            this.grpGamePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGamePath.Location = new System.Drawing.Point(173, 14);
            this.grpGamePath.Name = "grpGamePath";
            this.grpGamePath.Size = new System.Drawing.Size(459, 74);
            this.grpGamePath.TabIndex = 11;
            this.grpGamePath.TabStop = false;
            this.grpGamePath.Text = " Directory Path ";
            this.tipHelper.SetToolTip(this.grpGamePath, "Path of Current Game");
            // 
            // txtGamePath
            // 
            this.txtGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamePath.Location = new System.Drawing.Point(15, 20);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.ReadOnly = true;
            this.txtGamePath.Size = new System.Drawing.Size(403, 20);
            this.txtGamePath.TabIndex = 6;
            this.txtGamePath.Text = "<PATH>";
            // 
            // cbxCustomSubfiles
            // 
            this.cbxCustomSubfiles.AutoSize = true;
            this.cbxCustomSubfiles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbxCustomSubfiles.Location = new System.Drawing.Point(15, 47);
            this.cbxCustomSubfiles.Name = "cbxCustomSubfiles";
            this.cbxCustomSubfiles.Size = new System.Drawing.Size(142, 17);
            this.cbxCustomSubfiles.TabIndex = 6;
            this.cbxCustomSubfiles.Text = "Include Subfolder files";
            this.tipHelper.SetToolTip(this.cbxCustomSubfiles, "Check this if you want the Script to browse all files in all directories within t" +
        "he directory selected above.");
            this.cbxCustomSubfiles.UseVisualStyleBackColor = true;
            // 
            // cmdGamePath
            // 
            this.cmdGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGamePath.Location = new System.Drawing.Point(424, 18);
            this.cmdGamePath.Name = "cmdGamePath";
            this.cmdGamePath.Size = new System.Drawing.Size(25, 23);
            this.cmdGamePath.TabIndex = 11;
            this.cmdGamePath.Text = "...";
            this.tipHelper.SetToolTip(this.cmdGamePath, "Set the location of the current selected Game Setting");
            this.cmdGamePath.UseVisualStyleBackColor = true;
            this.cmdGamePath.Click += new System.EventHandler(this.cmdGamePath_Click);
            // 
            // tipHelper
            // 
            this.tipHelper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipHelper.ToolTipTitle = "Information";
            // 
            // cbxScriptDEP_EX
            // 
            this.cbxScriptDEP_EX.AutoSize = true;
            this.cbxScriptDEP_EX.Checked = true;
            this.cbxScriptDEP_EX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxScriptDEP_EX.Enabled = false;
            this.cbxScriptDEP_EX.Location = new System.Drawing.Point(18, 21);
            this.cbxScriptDEP_EX.Name = "cbxScriptDEP_EX";
            this.cbxScriptDEP_EX.Size = new System.Drawing.Size(126, 17);
            this.cbxScriptDEP_EX.TabIndex = 0;
            this.cbxScriptDEP_EX.Text = "Validate EXACT lines";
            this.tipHelper.SetToolTip(this.cbxScriptDEP_EX, "Always enabled.\r\nCheck for lines in the current section that are EXACTLY the same" +
        ".\r\nAll characters in the line;");
            this.cbxScriptDEP_EX.UseVisualStyleBackColor = true;
            // 
            // cbxScriptDEP_DUPINST
            // 
            this.cbxScriptDEP_DUPINST.AutoSize = true;
            this.cbxScriptDEP_DUPINST.Location = new System.Drawing.Point(18, 44);
            this.cbxScriptDEP_DUPINST.Name = "cbxScriptDEP_DUPINST";
            this.cbxScriptDEP_DUPINST.Size = new System.Drawing.Size(167, 17);
            this.cbxScriptDEP_DUPINST.TabIndex = 15;
            this.cbxScriptDEP_DUPINST.Text = "Validate Duplicated Instances";
            this.tipHelper.SetToolTip(this.cbxScriptDEP_DUPINST, resources.GetString("cbxScriptDEP_DUPINST.ToolTip"));
            this.cbxScriptDEP_DUPINST.UseVisualStyleBackColor = true;
            // 
            // cbxScriptDEP
            // 
            this.cbxScriptDEP.AutoSize = true;
            this.cbxScriptDEP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxScriptDEP.Checked = true;
            this.cbxScriptDEP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxScriptDEP.Location = new System.Drawing.Point(10, 0);
            this.cbxScriptDEP.Name = "cbxScriptDEP";
            this.cbxScriptDEP.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cbxScriptDEP.Size = new System.Drawing.Size(129, 17);
            this.cbxScriptDEP.TabIndex = 15;
            this.cbxScriptDEP.Text = "Enable Script Debug";
            this.tipHelper.SetToolTip(this.cbxScriptDEP, "Used for script testing purposes.\r\nWhen activated it will validate a script befor" +
        "e it is parsed to the builder.\r\nThis section will contains settings and helpers " +
        "to fix/analyse a script file.\r\n*WIP*");
            this.cbxScriptDEP.UseVisualStyleBackColor = false;
            this.cbxScriptDEP.CheckedChanged += new System.EventHandler(this.cbxScriptDEP_CheckedChanged);
            // 
            // cbxAdvancedStatistics
            // 
            this.cbxAdvancedStatistics.AutoSize = true;
            this.cbxAdvancedStatistics.Enabled = false;
            this.cbxAdvancedStatistics.Location = new System.Drawing.Point(18, 21);
            this.cbxAdvancedStatistics.Name = "cbxAdvancedStatistics";
            this.cbxAdvancedStatistics.Size = new System.Drawing.Size(176, 17);
            this.cbxAdvancedStatistics.TabIndex = 17;
            this.cbxAdvancedStatistics.Text = "Show Advanced Statistics Form";
            this.tipHelper.SetToolTip(this.cbxAdvancedStatistics, "Shows an Advanced Form containing information on Processed Script Statistics.");
            this.cbxAdvancedStatistics.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabDebug);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 356);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.grpSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(670, 330);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "General";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add(this.grpDepuration);
            this.tabDebug.Location = new System.Drawing.Point(4, 22);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebug.Size = new System.Drawing.Size(670, 330);
            this.tabDebug.TabIndex = 1;
            this.tabDebug.Text = "Script Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            // 
            // grpDepuration
            // 
            this.grpDepuration.Controls.Add(this.panelScriptDEP);
            this.grpDepuration.Controls.Add(this.cbxScriptDEP);
            this.grpDepuration.Location = new System.Drawing.Point(6, 6);
            this.grpDepuration.Name = "grpDepuration";
            this.grpDepuration.Size = new System.Drawing.Size(658, 182);
            this.grpDepuration.TabIndex = 13;
            this.grpDepuration.TabStop = false;
            // 
            // panelScriptDEP
            // 
            this.panelScriptDEP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScriptDEP.Controls.Add(this.groupBox2);
            this.panelScriptDEP.Controls.Add(this.groupBox1);
            this.panelScriptDEP.Location = new System.Drawing.Point(6, 19);
            this.panelScriptDEP.Name = "panelScriptDEP";
            this.panelScriptDEP.Size = new System.Drawing.Size(646, 154);
            this.panelScriptDEP.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxAdvancedStatistics);
            this.groupBox2.Location = new System.Drawing.Point(13, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 51);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxScriptDEP_DUPINST);
            this.groupBox1.Controls.Add(this.cbxScriptDEP_EX);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duplicated Script Lines";
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 371);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = global::mktm.ts3tools.s3sr.Properties.Resources.s3sr_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s3sr (The Sims 3: Scripter) Settings";
            this.Load += new System.EventHandler(this.frmGUI_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpOutputPath.ResumeLayout(false);
            this.grpOutputPath.PerformLayout();
            this.grpSettingsAll.ResumeLayout(false);
            this.grpSettingsAll.PerformLayout();
            this.GamesPanel.ResumeLayout(false);
            this.grpStoreAlternativePath.ResumeLayout(false);
            this.grpStoreAlternativePath.PerformLayout();
            this.grpGamePath.ResumeLayout(false);
            this.grpGamePath.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabDebug.ResumeLayout(false);
            this.grpDepuration.ResumeLayout(false);
            this.grpDepuration.PerformLayout();
            this.panelScriptDEP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpSettingsAll;
        private System.Windows.Forms.RadioButton radBASE;
        private System.Windows.Forms.GroupBox grpOutputPath;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdOutputPath;
        private System.Windows.Forms.GroupBox grpGamePath;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.Button cmdGamePath;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.RadioButton radStore;
        private System.Windows.Forms.CheckBox cbxInfoAlert;
        private System.Windows.Forms.ToolTip tipHelper;
        private System.Windows.Forms.GroupBox grpStoreAlternativePath;
        private System.Windows.Forms.TextBox txtStoreAlternativePath;
        private System.Windows.Forms.CheckBox cbxStoreAlternativeSubfiles;
        private System.Windows.Forms.Button cmdStoreAlternativePath;
        private System.Windows.Forms.CheckBox cbxCustomSubfiles;
        private System.Windows.Forms.CheckBox cbxUseStoreAlternativePath;
        private System.Windows.Forms.CheckBox cbxDecryptFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabDebug;
        private System.Windows.Forms.GroupBox grpDepuration;
        private System.Windows.Forms.Panel panelScriptDEP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxScriptDEP_DUPINST;
        private System.Windows.Forms.CheckBox cbxScriptDEP_EX;
        private System.Windows.Forms.CheckBox cbxScriptDEP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxAdvancedStatistics;
        private System.Windows.Forms.FlowLayoutPanel GamesPanel;
    }
}