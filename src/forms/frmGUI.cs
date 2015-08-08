using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mktm.ts3tools.s3sr
{
    public partial class frmGUI : Form
    {
        private bool Loaded = false;
        private frmAbout About = null;
        public bool UpdateAvailable = false;
        private string CurrentVersionTag;

        public frmGUI()
        {
            InitializeComponent();
            Versionizer.Methods.CreateRadios(ref GamesPanel, new EventHandler(radGame_CheckedChanged), ref tipHelper);
            radBASE.CheckedChanged += new EventHandler(radGame_CheckedChanged);
            radStore.CheckedChanged += new EventHandler(radGame_CheckedChanged);
            radCustom.CheckedChanged += new EventHandler(radGame_CheckedChanged);
            cbxUseStoreAlternativePath.CheckedChanged += new EventHandler(Checkboxes_Click);
            cbxStoreAlternativeSubfiles.CheckedChanged += new EventHandler(Checkboxes_Click);
            cbxCustomSubfiles.CheckedChanged += new EventHandler(Checkboxes_Click);
            base.HelpButtonClicked += new CancelEventHandler(frmGUI_HelpRequested);
            base.FormClosing += new FormClosingEventHandler(this.frmGUI_FormClosing);
        }


        private void radGame_CheckedChanged(object sender, EventArgs e)
        {
            radGame_Change((sender as RadioButton).Tag.ToString());
        }

        private void frmGUI_HelpRequested(object sender, CancelEventArgs e)
        {
            About.ShowDialog();
            e.Cancel = true;
        }

        /// <summary>
        /// Change the settings for the current selected Radio
        /// </summary>
        /// <param name="tag">Version as TAG</param>
        private void radGame_Change(string tag)
        {
            grpGamePath.Size = new Size(459, 51);
            cbxCustomSubfiles.Visible = false;
            grpStoreAlternativePath.Location = new Point(173, 71);
            grpStoreAlternativePath.Visible = false;
            cbxUseStoreAlternativePath.Visible = false;
            cbxDecryptFiles.Visible = false;
            txtGamePath.Text = Versionizer.Methods.Path(tag);
            switch (tag.ToUpper())
            {
                case "STORE":
                    cbxUseStoreAlternativePath.Visible = true;
                    grpStoreAlternativePath.Visible = true;
                    txtStoreAlternativePath.Text = Versionizer.Methods.Path(tag + "_Alternative");
                    cbxDecryptFiles.Visible = true;
                    break;
                case "CUSTOM":
                    grpGamePath.Size = new Size(459, 74);
                    cbxCustomSubfiles.Visible = true;
                    break;
            }
            CurrentVersionTag = tag;
        }

        private void frmGUI_Load(object sender, EventArgs e)
        {
            #region Check for Updates
            if (Settings.CheckUpdates > 0)
                if ((UpdateAvailable = Updater.Check(Settings.UpdateURL)))
                    (new frmUpdate()).ShowDialog();
            #endregion

            frmAbout.updateAvailable = this.UpdateAvailable;
            About = new frmAbout();
            this.Loaded = false;
            cbxInfoAlert.Checked = Settings.AlertInfo;
            cbxCustomSubfiles.Checked = Settings.PathCustom_SearchSubFiles;
            cbxStoreAlternativeSubfiles.Checked = Settings.PathStore_SearchSubFiles;
            cbxUseStoreAlternativePath.Checked = Settings.PathStore_Alternative != "";
            grpStoreAlternativePath.Enabled = Settings.PathStore_Alternative != "";
            cbxDecryptFiles.Checked = Settings.DecryptStoreFiles;
            cbxUseStoreAlternativePath.Location = new Point(183, 70);
            //Versionizer.Methods.UpdateRadios(ref this.grpSettingsAll);
            radBASE.Checked = true;
            txtOutput.Text = Settings.PathOutput;
            cbxScriptDEP.Checked = Settings.ScriptTesting;
            cbxScriptDEP_DUPINST.Checked = Settings.VerifyDuplicatedInstances;
            this.Loaded = true;

            //txtGamePath.Text = "<Directory Path>";
            //txtOutput.Text = "<Output Path>";
        }

        private void frmGUI_FormClosing(object sender, EventArgs e)
        {
            Settings.FirstRun = false;
            Settings.AlertInfo = cbxInfoAlert.Checked;
            Settings.PathCustom_SearchSubFiles = cbxCustomSubfiles.Checked;
            Settings.PathStore_SearchSubFiles = cbxStoreAlternativeSubfiles.Checked;
            Settings.DecryptStoreFiles = cbxDecryptFiles.Checked;
            Settings.ScriptTesting = cbxScriptDEP.Checked;
            Settings.VerifyDuplicatedInstances = cbxScriptDEP_DUPINST.Checked;
            Settings.AdvancedStatistics = cbxAdvancedStatistics.Checked;
            Settings.Save();
        }

        private void cmdGamePath_Click(object sender, EventArgs e)
        {
            #region Switch Selected Version Tag for Description
            dlgFolderBrowser.Description = "Location of " + ((RadioButton)this.grpSettingsAll.Controls["rad" + CurrentVersionTag]).Text.Trim() + ".";
            dlgFolderBrowser.SelectedPath = Versionizer.Methods.Path(CurrentVersionTag);
            switch (CurrentVersionTag.ToUpper())
            {
                case "STORE":
                    dlgFolderBrowser.Description = "Location of Store folder.";
                    break;
                case "CUSTOM":
                    dlgFolderBrowser.Description = "Location of Custom folder (Mods).";
                    break;
            }
            #endregion

            dlgFolderBrowser.ShowDialog();

            if (!string.IsNullOrEmpty(dlgFolderBrowser.SelectedPath))
            {
                Versionizer.Methods.Path(CurrentVersionTag, dlgFolderBrowser.SelectedPath);
                txtGamePath.Text = dlgFolderBrowser.SelectedPath;
            }
        }

        private void cmdOutputPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.PathOutput))
                dlgFolderBrowser.SelectedPath = Settings.PathOutput;
            
            dlgFolderBrowser.Description = "Location of the Output Package";
            dlgFolderBrowser.ShowDialog();

            if (!string.IsNullOrEmpty(dlgFolderBrowser.SelectedPath))
            {
                Settings.PathOutput = dlgFolderBrowser.SelectedPath;
                txtOutput.Text = dlgFolderBrowser.SelectedPath;
            }
        }

        private void cbxUseStoreAlternativePath_CheckedChanged(object sender, EventArgs e)
        {
            grpStoreAlternativePath.Enabled = cbxUseStoreAlternativePath.Checked;
        }

        private void cmdStoreAlternativePath_Click(object sender, EventArgs e)
        {
            dlgFolderBrowser.Description = "Location of Alternative Store folder.";
            if (!string.IsNullOrEmpty(Settings.PathStore_Alternative))
                dlgFolderBrowser.SelectedPath = Settings.PathStore_Alternative;

            dlgFolderBrowser.ShowDialog();

            if (!string.IsNullOrEmpty(dlgFolderBrowser.SelectedPath))
            {
                Settings.PathStore_Alternative = dlgFolderBrowser.SelectedPath;
                txtStoreAlternativePath.Text = dlgFolderBrowser.SelectedPath;
            }
        }

        private void Checkboxes_Click(object sender, EventArgs e)
        {
            if (!this.Loaded) return;
            Settings.PathStore_SearchSubFiles = cbxStoreAlternativeSubfiles.Checked;
            Settings.PathCustom_SearchSubFiles = cbxCustomSubfiles.Checked;
        }

        private void cbxScriptDEP_CheckedChanged(object sender, EventArgs e)
        {
            panelScriptDEP.Enabled = cbxScriptDEP.Checked;
            Settings.ScriptTesting = cbxScriptDEP.Checked;
        }

        private void cbxAdvancedStatistics_CheckedChanged(object sender, EventArgs e)
        {
            Settings.AdvancedStatistics = cbxAdvancedStatistics.Checked;
        }

        private void GamesPanel_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height + 15);
            grpSettings.Refresh();
        }
    }
}