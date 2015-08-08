using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace mktm.ts3tools.s3sr
{
    /// <summary>
    /// Class that carries delegates to interact with Advanced Statistics form
    /// </summary>
    public class ScriptProcessor
    {
        public delegate void ChangeVersion(int i);
        public delegate void ChangeFile(string FileName);
        public delegate void ChangeKey(uint Type, uint Group, ulong Instance);
        public delegate void ChangeInstruction(int LineReference, bool Processed, string Error);
        public delegate void ChangeType(string TypeStr);
        public delegate void AddInstruction(InstructionOBJDEventArgs e);

        public class InstructionOBJDEventArgs : EventArgs
        {
            string InstructionName;
            uint Type;
            uint Group;
            ulong Instance;
            int LineReference;

            public InstructionOBJDEventArgs(string Name, uint Type, uint Group, ulong Instance, int LineReference)
            {
                this.InstructionName = Name;
                this.Type = Type;
                this.Group = Group;
                this.Instance = Instance;
                this.LineReference = LineReference;
            }
        }

        public static void Invoke(Control RefControl, Delegate Method, object[] Arguments)
        {
            if (RefControl.InvokeRequired)
                RefControl.Invoke(Method, Arguments);
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        public static void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            // TODO, Valid Properties
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                    if (p.Name.ToUpper() == propName.ToUpper())
                        p.SetValue(oControl, propValue, null);
            }
        }

        public delegate void ScriptProcessorDelegate(ScriptProcessorEventArgs e);
        public delegate void ScriptProcessorVersion(int i);

        public class ScriptProcessorEventArgs : EventArgs
        {
            //TODO
            private string ver;
            public string Version
            {
                get
                {
                    return ver;
                }
            }

            public ScriptProcessorEventArgs(string GameVersion)
            {
                ver = GameVersion;
            }
        }
    }
}