using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace mktm.ts3tools.s3sr
{
    /// <summary>
    /// Class that handles Exception Reports
    /// </summary>
    public static class ExceptionReport
    {
        #region Methods
        /// <summary>
        /// Attempt to create an Error Log on the application directory
        /// </summary>
        /// <param name="ex">Exception</param>
        /// <param name="exTitle">Main Information of the Exception</param>
        public static void Create(Exception ex, string title)
        {
            try
            {
                string path = string.Format(@"{0}\s3sr-error[{1}].log",
                    new string[] {
                        new FileInfo(Application.ExecutablePath).Directory.ToString(),
                        DateTime.Now.ToUniversalTime().ToString().Replace("/", "-").Replace(":", "-").Replace(" ", "_")
                    });

                if (!File.Exists(path))
                    (File.Create(path)).Close();

                List<string> Report = new List<string>(new string[] { title, Environment.NewLine });
                Report.AddRange(ex.ToString().Split('\n'));
                File.WriteAllText(path, string.Join(Environment.NewLine, Report.ToArray()), Encoding.Unicode);
            }
            catch (Exception exError)
            {
                // Fell here.... Serisouly?
                MessageBox.Show(exError.ToString(), "Exception while Creating Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionReport.Create(exError, "Exception @ <ExceptionReport.Create>");
                return;
            }
        }
        #endregion
    }
}