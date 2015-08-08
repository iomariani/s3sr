using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace mktm.ts3tools.s3sr
{
    /// <summary>
    /// Shell Extension Classes (Author: mktm http://www.mktm.co.uk)
    /// Methods & Classes which help to create/maintain extensions to the Windows Shell
    /// </summary>
    /// <TODO>
    ///     — Implement Extension.Read method
    ///     — DO TODO
    /// </TODO>
    public class Extension
    {
        #region Attributes
        private string ProgID;
        private string ShellExtension;
        private string DefaultIcon;
        private string Descritption;
        private ExtensionShell shell;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for Extension class
        /// </summary>
        /// <param name="_progID">Programmatic Identifier of the Extension</param>
        /// <param name="_ext">Extension (*.x)</param>
        /// <param name="_description">(Optional) Description of the Extension</param>
        /// <param name="_defaultIcon">(Optional) Default Icon of the Extension used by Windows Shell</param>
        public Extension(string _progID, string _ext, string _description = "", string _defaultIcon = "")
        {
            this.ProgID = _progID;
            this.ShellExtension = _ext.Replace(".", " ");
            if(string.IsNullOrEmpty(_description.Trim()))
              this.Descritption = this.ShellExtension.ToUpper() + " File";
            else
              this.Descritption = _description;
            this.DefaultIcon = _defaultIcon;
            this.shell = new ExtensionShell();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Attempt to Read a Extension and its Shell Commands
        /// </summary>
        /// <param name="ext">Extension (*.x)</param>
        /// <returns>The readen Extension</returns>
        public static Extension Read(string ext)
        {
            return null;
        }

        /// <summary>
        /// Attempt to Create a new Extension
        /// </summary>
        /// <returns>true if success, false if not</returns>
        public bool CreateExtension()
        {
            if (this.shell == null)
                return false;

            RegistryKey key = null;
            try
            {
                key = Registry.ClassesRoot.OpenSubKey("." + this.ShellExtension, true);

                if (key == null)
                    Registry.ClassesRoot.CreateSubKey("." + this.ShellExtension).SetValue("", this.ProgID);

                key = Registry.ClassesRoot.OpenSubKey(this.ProgID, true);

                if (key == null)
                {
                    key = Registry.ClassesRoot.CreateSubKey(this.ProgID);
                    if (!string.IsNullOrEmpty(this.Descritption))
                        key.SetValue("", this.Descritption);
                    else
                        key.SetValue("", this.ShellExtension + " File");
                    if (!string.IsNullOrEmpty(this.DefaultIcon))
                        key.CreateSubKey("DefaultIcon").SetValue("", this.DefaultIcon);
                    key.CreateSubKey("Shell");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception while Creating Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionReport.Create(ex, "Exception @ <Extension.CreateExtension>");
                return false;
            }
            finally
            {
                key.Close();
            }
            return true;
        }

        /// <summary>
        /// Create all registered Shell Commands
        /// </summary>
        public bool CreateCommands()
        {
            if (this.shell == null || this.shell.Count == 0)
                return false;

            RegistryKey key = null;
            foreach (ExtensionCommand Command in shell)
            {
                try
                {
                    key = Registry.ClassesRoot.OpenSubKey(this.ProgID, true);

                    if (key == null)
                        return false;
                    else
                    {
                        key = key.OpenSubKey("Shell", true);
                        if (Command.ShortName.StartsWith("*"))
                        {
                            Command.ShortName = Command.ShortName.Replace("*", "");
                            key.SetValue("", Command.ShortName);
                        }

                        if (key.OpenSubKey(Command.ShortName, true) == null)
                          key = key.CreateSubKey(Command.ShortName);
                        else
                          key = key.OpenSubKey(Command.ShortName, true);

                        if (!string.IsNullOrEmpty(Command.Description))
                            key.SetValue("", Command.Description);

                        if (!string.IsNullOrEmpty(Command.Icon))
                            key.SetValue("icon", Command.Icon);
                        key = key.CreateSubKey("Command");
                        key.SetValue("", Command.ShellCommand.Build());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Exception while Creating Extension Commands", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExceptionReport.Create(ex, "Exception @ <Extension.CreateCommands>");
                    return false;
                }
                finally
                {
                    if(key != null)
                        key.Close();
                }
            }
            return true;
        }

        /// <summary>
        /// Add Command as ExtensionCommand to Current Shell
        /// </summary>
        /// <param name="Command"></param>
        public void AddCommand(ExtensionCommand Command)
        {
            this.shell.Add(Command);
        }
        #endregion
    }
    
    public class ExtensionShell : IEnumerable<ExtensionCommand>
    {
        #region Attributes
        List<ExtensionCommand> Commands;
        #endregion

        #region Properties
        public int Count
        {
            get
            {
                return this.Commands.Count;
            }
        }
        #endregion

        #region Constructor
        public ExtensionShell()
        {
            this.Commands = new List<ExtensionCommand>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the Command to the List
        /// </summary>
        /// <param name="Command">Command as new ExtensionCommand</param>
        public void Add(ExtensionCommand Command)
        {
            this.Commands.Add(Command);
        }
        #endregion

        #region Enumerators
        public IEnumerator<ExtensionCommand> GetEnumerator()
        {
            foreach (ExtensionCommand Command in Commands)
                yield return Command;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }

    public class ExtensionCommand
    {
        #region Attributes
        public string ShortName;
        public string Description;
        public string Icon;
        public ExtensionShellCommand ShellCommand;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for new Extension Command
        /// </summary>
        /// <param name="ShortName">Short Name of the Command (Just for Identify Purpose)</param>
        /// <param name="Description">Description of the Command (Appears in Shell)</param>
        /// <param name="Command">Command as ShellCommand { ExecutablePath, Arguments[] }</param>
        /// <param name="Icon">(Optional) Icon to use on Shell Menu</param>
        public ExtensionCommand(string ShortName, string Description, ExtensionShellCommand Command, string Icon = "")
        {
            this.ShortName = ShortName;
            this.Description = Description;
            this.ShellCommand = Command;
            this.Icon = Icon;
        }
        #endregion
    }

    public class ExtensionShellCommand
    {
        #region Attributes
        public string ExecutablePath;
        public string[] Arguments;
        #endregion

        #region Constructor
        /// <param name="ExecutablePath">Path of the Executable to Run in Command</param>
        /// <param name="Arguments">Arguments/Parameters</param>
        /// <param name="WrapArguments">(Optional) Wrap Arguments in Quotes</param>
        public ExtensionShellCommand(string ExecutablePath, string[] Arguments, bool WrapArguments = true)
        {
            this.ExecutablePath = ExecutablePath;
            if (!WrapArguments)
                this.Arguments = Arguments;
            else
            {
                string[] wrapedArguments = new string[Arguments.Length];
                foreach (string arg in Arguments)
                    wrapedArguments[wrapedArguments.Length - 1] = "\"" + arg + "\"";
                this.Arguments = wrapedArguments;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Build the Command as a Literal string
        /// </summary>
        /// <returns>Command Literal</returns>
        public string Build()
        {
            return "\"" + this.ExecutablePath + "\" " + String.Join(" ", this.Arguments);
        }
        #endregion
    }
}