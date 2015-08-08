using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace mktm.ts3tools.s3sr
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.Reload();
            List<string> cmd = new List<string>(args);

            bool ForceFirstRun = false;
            int index = -1;
            if ((index = cmd.IndexOf("/forcefirstrun")) != -1)
            {
                ForceFirstRun = true;
                cmd.RemoveAt(index);
            }
            if ((index = cmd.IndexOf("/cleanextensions")) != -1)
            {
                Settings.RemoveExtension();
                cmd.RemoveAt(index);
            }
            if ((index = cmd.IndexOf("/reset")) != -1)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Settings.RemoveExtension();
                cmd.RemoveAt(index);
            }

            Settings.SetDefaults(ForceFirstRun);
            Settings.CreateExtension();
            if (ForceFirstRun | cmd.Count == 0)
                Application.Run(new frmGUI());
            else
            {
                if (Settings.FirstRun)
                {
                    MessageBox.Show("Please, run the application to set your settings before running a script.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }

                if (Settings.AdvancedStatistics)
                {
                    frmScriptProcess.Scripts = cmd.ToArray();
                    Application.Run(new frmScriptProcess());
                }
                else
                    Parser.Start(cmd.ToArray());
            }
        }
    }
}