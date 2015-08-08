using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace mktm.ts3tools.s3sr
{
    class Script
    {
        private Versionizer.Enums.Valid Version;
        public List<Catalog> Commands;

        /// <summary>
        /// Script Constructor
        /// </summary>
        /// <param name="Version">Versionizer.Enums.Valid</param>
        public Script(Versionizer.Enums.Valid Version)
        {
            this.Version = Version;
            this.Commands = new List<Catalog>();
        }

        public bool AddCommand(string[] ParsingScriptLine, int ParsingLine)
        {
            Catalog _Catalog = new Catalog(ParsingScriptLine, ParsingLine);

            if (_Catalog.Borked)
            {
                MessageBox.Show(string.Format("Error while parsing a line on the script.\n\nLine: {0}\nScript: \"{1}\"\n\nOperation aborted.",
                    new string[] { ParsingLine.ToString(), _Catalog.ScriptReference }),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            this.Commands.Add(new Catalog(ParsingScriptLine, ParsingLine));
            return true;
        }

        public int[] FindDuplicates()
        {
            for (int i = 0; i < this.Commands.Count; i++)
            {
                int duplicatedIndex = this.Commands.FindIndex((i + 1), 
                    s => (
                        (this.Commands[i].ScriptReference == s.ScriptReference)
                        ||
                        (this.Commands[i].ResourceType == s.ResourceType ? (this.Commands[i].Instance == s.Instance) : false) 
                        ));
                if (duplicatedIndex > -1)
                    return new int[] { this.Commands[i].LineReference, this.Commands[duplicatedIndex].LineReference };
            }

            return new int[] { };
        }
    }
}