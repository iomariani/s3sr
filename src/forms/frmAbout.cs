using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace mktm.ts3tools.s3sr
{
    public partial class frmAbout : Form
    {
        public static bool updateAvailable = false;

        public frmAbout()
        {
            InitializeComponent();
            radUpdateAlways.Click += new EventHandler(radUpdate_Click);
            radUpdateGUI.Click += new EventHandler(radUpdate_Click);
            base.FormClosing += new FormClosingEventHandler(this.frmAbout_FormClosing);
        }

        private void frmAbout_FormClosing(object sender, EventArgs e)
        {
            Settings.CheckUpdateState updateState = Settings.CheckUpdateState.Off;
            if (cbxUpdate.Checked)
            {
                if (radUpdateAlways.Checked)
                    updateState = Settings.CheckUpdateState.Always;
                else
                    updateState = Settings.CheckUpdateState.GUI;
            }
            Settings.CheckUpdates = updateState;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Application.ProductVersion;
            radUpdateAlways.Checked = (Settings.CheckUpdates == Settings.CheckUpdateState.Always);
            radUpdateGUI.Checked = (Settings.CheckUpdates == Settings.CheckUpdateState.GUI);
            cbxUpdate.Checked = (Settings.CheckUpdates > 0);
            if (radUpdateGUI.Checked & cbxUpdate.Checked)
                cbxUpdate.CheckState = CheckState.Indeterminate;
            radUpdateAlways.Enabled = cbxUpdate.Checked;
            if (Settings.CheckUpdates == Settings.CheckUpdateState.Off)
                radUpdateAlways.Checked = true;
            radUpdateGUI.Enabled = cbxUpdate.Checked;
            lblUpdateFalse.Visible = false;
            if (Settings.CheckUpdates == Settings.CheckUpdateState.Off)
                btnUpdate.Visible = true;
            else
                if (updateAvailable)
                {
                    btnUpdate.Visible = false;
                }
                else
                {
                    btnUpdate.Visible = false;
                    lblUpdateFalse.Visible = true;
                }
        }

        private void linkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://mktm.co.uk/development/ts3tools/s3sr/");
        }

        private void linkLabelBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.linkBlog.Text);
        }

        private void linkPeter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://dino.drealm.info/den/denforum/index.php?action=profile;u=6");
        }

        private void linkAnach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.moreawesomethanyou.com/smf/index.php?action=profile;u=51694");
        }

        private void linkGNU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.fsf.org/licensing/licenses/gpl.html");
        }

        private void cbxUpdate_Click(object sender, EventArgs e)
        {
            radUpdateAlways.Enabled = (cbxUpdate.CheckState == CheckState.Indeterminate | cbxUpdate.CheckState == CheckState.Checked);
            radUpdateGUI.Enabled = (cbxUpdate.CheckState == CheckState.Indeterminate | cbxUpdate.CheckState == CheckState.Checked);
            if (cbxUpdate.CheckState == CheckState.Indeterminate)
                cbxUpdate.CheckState = CheckState.Unchecked;
            if (cbxUpdate.CheckState == CheckState.Unchecked)
                return;

            if (radUpdateGUI.Checked)
                cbxUpdate.CheckState = CheckState.Indeterminate;
        }

        private void radUpdate_Click(object sender, EventArgs e)
        {
            radUpdate();
        }

        private void radUpdate()
        {
            if (radUpdateAlways.Checked)
                cbxUpdate.CheckState = CheckState.Checked;
            else
            {
                if (cbxUpdate.CheckState == CheckState.Indeterminate | cbxUpdate.CheckState == CheckState.Checked)
                    cbxUpdate.CheckState = CheckState.Indeterminate;
                else
                    cbxUpdate.CheckState = CheckState.Unchecked;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Updater.Check(Settings.UpdateURL))
            {
                //MessageBox.Show("Your software is up to date at the moment.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate.Visible = false;
                lblUpdateFalse.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
                lblUpdateFalse.Visible = false;
                (new frmUpdate()).ShowDialog();
            }
        }
    }
}