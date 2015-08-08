using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace mktm.ts3tools.s3sr.Properties
{
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings
    {
        public Settings()
        {
            mktm.ts3tools.s3sr.Settings.UpdateURL = this.UpdateURL;
            mktm.ts3tools.s3sr.Settings.Steam = this.Steam;
            mktm.ts3tools.s3sr.Settings.FirstRun = this.FirstRun;
            mktm.ts3tools.s3sr.Settings.AlertInfo = this.AlertInfo;
            mktm.ts3tools.s3sr.Settings.CheckUpdates = (mktm.ts3tools.s3sr.Settings.CheckUpdateState)this.CheckUpdates;
            mktm.ts3tools.s3sr.Settings.ScriptTesting = this.ScriptTesting;
            mktm.ts3tools.s3sr.Settings.VerifyDuplicatedInstances = this.VerifyDuplicatedInstances;
            mktm.ts3tools.s3sr.Settings.AdvancedStatistics = this.AdvancedStatistics;
            mktm.ts3tools.s3sr.Settings.PathStore = this.PathStore;
            mktm.ts3tools.s3sr.Settings.PathStore_SearchSubFiles = this.PathCustom_SearchSubFiles;
            mktm.ts3tools.s3sr.Settings.PathStore_Alternative = this.PathStore_Alternative;
            mktm.ts3tools.s3sr.Settings.DecryptStoreFiles = this.DecryptStoreFiles;
            mktm.ts3tools.s3sr.Settings.PathCustom = this.PathCustom;
            mktm.ts3tools.s3sr.Settings.PathCustom_SearchSubFiles = this.PathCustom_SearchSubFiles;
            mktm.ts3tools.s3sr.Settings.PathOutput = this.PathOutput;
            mktm.ts3tools.s3sr.Settings.PathBASE = this.PathBASE;
            mktm.ts3tools.s3sr.Settings.PathEP01 = this.PathEP01;
            mktm.ts3tools.s3sr.Settings.PathSP01 = this.PathSP01;
            mktm.ts3tools.s3sr.Settings.PathEP02 = this.PathEP02;
            mktm.ts3tools.s3sr.Settings.PathSP02 = this.PathSP02;
            mktm.ts3tools.s3sr.Settings.PathEP03 = this.PathEP03;
            mktm.ts3tools.s3sr.Settings.PathSP03 = this.PathSP03;
            mktm.ts3tools.s3sr.Settings.PathEP04 = this.PathEP04;
            mktm.ts3tools.s3sr.Settings.PathSP04 = this.PathSP04;
            mktm.ts3tools.s3sr.Settings.PathEP05 = this.PathEP05;
            mktm.ts3tools.s3sr.Settings.PathSP05 = this.PathSP05;
            mktm.ts3tools.s3sr.Settings.PathEP06 = this.PathEP06;
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // Properties.Settings.Default.SettingChanging += this.SettingChangingEventHandler;
            //
            // Properties.Settings.Default.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            // Add code to handle the SettingChangingEvent event here.
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Add code to handle the SettingsSaving event here.
        }
    }
}

namespace mktm.ts3tools.s3sr
{
    public static class Settings
    {
        #region Registry Settings
        public static string UpdateURL;
        public static bool Steam;
        public static bool FirstRun;
        public static bool AlertInfo;
        public static CheckUpdateState CheckUpdates = CheckUpdateState.GUI;
        public enum CheckUpdateState : int { Off = 0, Always = 1, GUI = 2 }
        public static bool ScriptTesting;
        public static bool VerifyDuplicatedInstances;
        public static bool AdvancedStatistics;

        #region Path Settings
        public static string PathStore;
        public static bool PathStore_SearchSubFiles;
        public static string PathStore_Alternative;
        public static bool DecryptStoreFiles;
        public static string PathCustom;
        public static bool PathCustom_SearchSubFiles;
        public static string PathOutput;

        private static string PathGameBASE = "";
        public static string PathBASE;

        public static bool HasEP01 = false;
        private static string PathGameEP01 = "";
        public static string PathEP01;

        public static bool HasSP01 = false;
        private static string PathGameSP01 = "";
        public static string PathSP01;

        public static bool HasEP02 = false;
        private static string PathGameEP02 = "";
        public static string PathEP02;

        public static bool HasSP02 = false;
        private static string PathGameSP02 = "";
        public static string PathSP02;

        public static bool HasEP03 = false;
        private static string PathGameEP03 = "";
        public static string PathEP03;

        public static bool HasSP03 = false;
        private static string PathGameSP03 = "";
        public static string PathSP03;

        public static bool HasEP04 = false;
        private static string PathGameEP04 = "";
        public static string PathEP04;

        public static bool HasSP04 = false;
        private static string PathGameSP04 = "";
        public static string PathSP04;

        public static bool HasEP05 = false;
        private static string PathGameEP05 = "";
        public static string PathEP05;

        public static bool HasSP05 = false;
        private static string PathGameSP05 = "";
        public static string PathSP05;

        public static bool HasEP06 = false;
        private static string PathGameEP06 = "";
        public static string PathEP06;
        #endregion
        #endregion

        #region Methods

        /// <summary>
        /// Read current registry settings
        /// </summary>
        /// <param name="ForceFirstRun">(Optional) Set all Game Paths to their respective defaults on the registry</param>
        public static void SetDefaults(bool ForceFirstRun = false)
        {
            RegistryKey key;
            string SIMS_ROOT = @"Software\Sims";
            
            #region Check Steam
            bool GotSteam = false;
            if(Steam)
            {
                GotSteam = true;
                SIMS_ROOT = @"Software\Sims(Steam)";
            }

            if (!GotSteam)
            {
                try
                {
                    key = Registry.LocalMachine.OpenSubKey(@"Software\Sims(Steam)", false);
                    if (key != null)
                    {
                        switch (MessageBox.Show("It seems you have The Sims 3, Steam version.\nCan you confirm that?", "Steam Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                Steam = true;
                                SIMS_ROOT = @"Software\Sims(Steam)";
                                break;
                            case DialogResult.No:
                                Steam = false; // Doesn't make any sense...
                                break;
                        }
                        key.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Exception while Verifying Steam Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExceptionReport.Create(ex, "Exception @ <Settings.SetDefaults#VerifySteam>");
                }
            }
            #endregion

            #region Read Game Default Paths
            try
            {
                #region BASE
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3", false);
                if (key == null)
                {
                    MessageBox.Show("Could not read Base Game settings from registry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                else
                    PathGameBASE = key.GetValue("Install Dir").ToString();
                key.Close();
                #endregion
                #region EP01
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 World Adventures", false);
                if (key == null)
                    HasEP01 = false;
                else
                {
                    HasEP01 = true;
                    PathGameEP01 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region SP01
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + (Steam ? @"\The Sims 3 High End Loft Stuff" : @"\The Sims 3 High-End Loft Stuff"), false);
                if (key == null)
                    HasSP01 = false;
                else
                {
                    HasSP01 = true;
                    PathGameSP01 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region EP02
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Ambitions", false);
                if (key == null)
                    HasEP02 = false;
                else
                {
                    HasEP02 = true;
                    PathGameEP02 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region SP02
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Fast Lane Stuff", false);
                if (key == null)
                    HasSP02 = false;
                else
                {
                    HasSP02 = true;
                    PathGameSP02 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region EP03
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Late Night", false);
                if (key == null)
                    HasEP03 = false;
                else
                {
                    HasEP03 = true;
                    PathGameEP03 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region SP03
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Outdoor Living Stuff", false);
                if (key == null)
                    HasSP03 = false;
                else
                {
                    HasSP03 = true;
                    PathGameSP03 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region EP04
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Generations", false);
                if (key == null)
                    HasEP04 = false;
                else
                {
                    HasEP04 = true;
                    PathGameEP04 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region SP04
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Town Life Stuff", false);
                if (key == null)
                    HasSP04 = false;
                else
                {
                    HasSP04 = true;
                    PathGameSP04 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region EP05
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Pets", false);
                if (key == null)
                    HasEP05 = false;
                else
                {
                    HasEP05 = true;
                    PathGameEP05 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region SP05
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Master Suite Stuff", false);
                if (key == null)
                    HasSP05 = false;
                else
                {
                    HasSP05 = true;
                    PathGameSP05 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
                #region EP06
                key = Registry.LocalMachine.OpenSubKey(SIMS_ROOT + @"\The Sims 3 Showtime", false);
                if (key == null)
                    HasEP06 = false;
                else
                {
                    HasEP06 = true;
                    PathGameEP06 = key.GetValue("Install Dir").ToString();
                    key.Close();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception while Reading Game Default Paths", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionReport.Create(ex, "Exception @ <Settings.SetDefaults#GamePaths>");
            }
            #endregion

            #region Reset Game Default Paths
            if (string.IsNullOrEmpty(PathBASE)) PathBASE = PathGameBASE;
            if (string.IsNullOrEmpty(PathEP01)) PathEP01 = PathGameEP01;
            if (string.IsNullOrEmpty(PathSP01)) PathSP01 = PathGameSP01;
            if (string.IsNullOrEmpty(PathEP02)) PathEP02 = PathGameEP02;
            if (string.IsNullOrEmpty(PathSP02)) PathSP02 = PathGameSP02;
            if (string.IsNullOrEmpty(PathEP03)) PathEP03 = PathGameEP03;
            if (string.IsNullOrEmpty(PathSP03)) PathSP03 = PathGameSP03;
            if (string.IsNullOrEmpty(PathEP04)) PathEP04 = PathGameEP04;
            if (string.IsNullOrEmpty(PathSP04)) PathSP04 = PathGameSP04;
            if (string.IsNullOrEmpty(PathEP05)) PathEP05 = PathGameEP05;
            if (string.IsNullOrEmpty(PathSP05)) PathSP05 = PathGameSP05;
            if (string.IsNullOrEmpty(PathEP06)) PathEP06 = PathGameEP06;
            if (string.IsNullOrEmpty(PathStore))
            {
                PathStore = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Electronic Arts\";
                #region Switch OS Language
                switch (System.Globalization.CultureInfo.CurrentUICulture.Name)
                {
                    case "fr-FR": PathStore += @"Les Sims 3\DCCache"; break;
                    case "de-DE": PathStore += @"Die Sims 3\DCCache"; break;
                    case "nl-NL": PathStore += @"De Sims 3\DCCache"; break;
                    case "pt-PT": PathStore += @"Os Sims 3\DCCache"; break;
                    case "es-ES": case "es-MX": PathStore += @"Los Sims 3\DCCache"; break;
                    default: PathStore += @"The Sims 3\DCCache"; break;
                }
                #endregion
            }
            #endregion

            #region First Run
            if (ForceFirstRun || FirstRun)
            {
                PathBASE = PathGameBASE;
                PathEP01 = PathGameEP01;
                PathSP01 = PathGameSP01;
                PathEP02 = PathGameEP02;
                PathSP02 = PathGameSP02;
                PathEP03 = PathGameEP03;
                PathSP03 = PathGameSP03;
                PathEP04 = PathGameEP04;
                PathSP04 = PathGameSP04;
                PathEP05 = PathGameEP05;
                PathSP05 = PathGameSP05;
                PathEP06 = PathGameEP06;
                Settings.CreateExtension();
            }
            #endregion
        }

        /// <summary>
        /// Save current settings to application registry
        /// </summary>
        public static void Save()
        {
            Properties.Settings.Default.Steam = Steam;
            Properties.Settings.Default.AlertInfo = AlertInfo;
            Properties.Settings.Default.FirstRun = FirstRun;
            Properties.Settings.Default.CheckUpdates = (int) CheckUpdates;
            Properties.Settings.Default.ScriptTesting = ScriptTesting;
            Properties.Settings.Default.VerifyDuplicatedInstances = VerifyDuplicatedInstances;
            Properties.Settings.Default.PathStore = PathStore;
            Properties.Settings.Default.PathStore_Alternative = PathStore_Alternative;
            Properties.Settings.Default.PathStore_SearchSubFiles = PathStore_SearchSubFiles;
            Properties.Settings.Default.DecryptStoreFiles = DecryptStoreFiles;
            Properties.Settings.Default.PathCustom = PathCustom;
            Properties.Settings.Default.PathCustom_SearchSubFiles = PathCustom_SearchSubFiles;
            Properties.Settings.Default.PathOutput = PathOutput;
            Properties.Settings.Default.PathBASE = PathBASE;
            Properties.Settings.Default.PathEP01 = PathEP01;
            Properties.Settings.Default.PathSP01 = PathSP01;
            Properties.Settings.Default.PathEP02 = PathEP02;
            Properties.Settings.Default.PathSP02 = PathSP02;
            Properties.Settings.Default.PathEP03 = PathEP03;
            Properties.Settings.Default.PathSP03 = PathSP03;
            Properties.Settings.Default.PathEP04 = PathEP04;
            Properties.Settings.Default.PathSP04 = PathSP04;
            Properties.Settings.Default.PathEP05 = PathEP05;
            Properties.Settings.Default.PathSP05 = PathSP05;
            Properties.Settings.Default.PathEP06 = PathEP06;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Attempt to create a Windows Shell extension for *.s3sr
        /// </summary>
        public static void CreateExtension()
        {
            Settings.RemoveExtension();
            try
            {
                Extension ext = new Extension("mktm.ts3tools.s3sr", "s3sr", "s3sr-script", Application.ExecutablePath + ",0");
                if (ext.CreateExtension())
                {
                    ext.AddCommand(new ExtensionCommand(
                        "*Run", "&Run script",
                        new ExtensionShellCommand(Application.ExecutablePath, new string[] { "%1" }),
                        Application.ExecutablePath + ",0")
                    );
                    ext.AddCommand(new ExtensionCommand(
                         "Configure", "&Configure s3sr",
                         new ExtensionShellCommand(Application.ExecutablePath, new string[] {}),
                         Application.ExecutablePath + ",0")
                     );
                    ext.CreateCommands();
                }
                ext = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception while Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionReport.Create(ex, "Exception @ <Settings.CreateExtension>");
                return;
            }
        }

        public static bool RemoveExtension()
        {
            try
            {
                Registry.ClassesRoot.DeleteSubKey(".s3sr", false);
                Registry.ClassesRoot.DeleteSubKeyTree("mktm.ts3tools.s3sr");
            } finally { }
            return true;
        }
        #endregion
    }
}