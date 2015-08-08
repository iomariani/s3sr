using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mktm.ts3tools.s3sr
{
    public partial class frmScriptProcess : Form
    {
        public static string[] Scripts;
        private int currV = 0;
        private int currentVersion
        {
            get
            {
                return currV;
            }
            set
            {
                currV = value;
                this.tabControl1.SelectedIndex = value;
            }
        }

        public frmScriptProcess()
        {
            InitializeComponent();
        }

        private void frmScriptProcess_Load(object sender, EventArgs e)
        {
            VersionImageList.Images.Clear();
            VersionImageList.Images.AddRange(
                new Image[] 
                {
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3EP01_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3SP01_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3EP02_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3SP02_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3EP03_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3SP03_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3EP04_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3SP04_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3EP05_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3SP05_16,
                    global::mktm.ts3tools.s3sr.Properties.Resources.Sims3EP06_16
                }
            );

            //gridBASE.Rows.Add(new object[] { 1, "OBJD", "0x120000", "0x0000000000" });
            scriptWorker.RunWorkerAsync(Scripts);
        }

        private void scriptWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Parser.ChangeVersion = new ScriptProcessor.ChangeVersion(this.ChangeVersion);
            Parser.ChangeKey = new ScriptProcessor.ChangeKey(this.ChangeKey);
            Parser.ChangeInstruction = new ScriptProcessor.ChangeInstruction(this.ChangeInstruction);
            Parser.ChangeFile = new ScriptProcessor.ChangeFile(this.ChangeFile);
            Parser.AddInstruction = new ScriptProcessor.AddInstruction(this.AddInstruction);
            Parser.Start(e.Argument as string[]);
        }

        public void ChangeVersion(int i)
        {
            this.currentVersion = i;
        }

        public void ChangeKey(uint Type, uint Group, ulong Instance)
        {
            ScriptProcessor.Invoke(
                this.lblBASE_Key,
                new ScriptProcessor.ChangeKey(ChangeKey),
                new object[] { Type, Group, Instance }
                );

            string val = "key:" + string.Format("0x{0:X8}:", Type) + string.Format("0x{0:X8}:", Group) + string.Format("0x{0:X16}", Instance);
            switch (this.currentVersion)
            {
                case 0:
                    //BASE
                    lblBASE_Key.Text = val;
                    break;
                case 1:
                    //EP01
                    break;
            }
        }

        public void ChangeFile(string Filename)
        {

        }

        public void ChangeInstruction(int LineReference, bool Processed, string Error)
        {

        }

        public void AddInstruction(ScriptProcessor.InstructionOBJDEventArgs e)
        {

        }
    }
}