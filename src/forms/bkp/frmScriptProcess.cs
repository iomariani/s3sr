using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace s3sr
{
    public partial class frmScriptProcess : Form
    {
        public static string[] Scripts;
        
        

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
                    global::s3sr.Properties.Resources.Sims3_16,
                    global::s3sr.Properties.Resources.Sims3EP01_16,
                    global::s3sr.Properties.Resources.Sims3SP01_16,
                    global::s3sr.Properties.Resources.Sims3EP02_16,
                    global::s3sr.Properties.Resources.Sims3SP02_16,
                    global::s3sr.Properties.Resources.Sims3EP03_16
                }
            );

            dataGridView1.Rows.Add(new object[] { 1 , "OBJD", "0x120000", "0x0000000000" });
            scriptWorker.RunWorkerAsync(Scripts);
        }

        private void scriptWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //ParseScript.ChangeVersion = new ScriptProcessor.ChangeVersion(this.ChangeVersion);
            ParseScript.ChangeKey = new ScriptProcessor.ChangeKey(this.ChangeKey);
            ParseScript.Start(e.Argument as string[]);
        }

        public void ChangeVersion(int i)
        {
            // do something with i
        }

        public void ChangeKey(uint Type, uint Group, ulong Instance)
        {
            ScriptProcessor.Invoke(
                this.lblBASE_Key,
                new ScriptProcessor.ChangeKey(ChangeKey),
                new object[] { Type, Group, Instance }
                );

            lblBASE_Key.Text = "key:" +
                string.Format("0x{0:X8}:", Type) +
                string.Format("0x{0:X8}:", Group) +
                string.Format("0x{0:X16}", Instance);

            //ScriptProcessor.SetControlPropertyValue(lblBASE_ProcessingKey, "Text", "Processing Key: key:" + string.Format("0x{0:X}:0x{1:X}:0x{2:X}", Type, Group, Instance));
        }


    }
}
