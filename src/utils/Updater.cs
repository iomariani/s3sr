using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace mktm.ts3tools.s3sr
{
    public static class Updater
    {
        public static string version = null;
        public static string url = null;

        /// <summary>
        /// Check Version reading a plain-text file on the web
        /// </summary>
        /// <param name="svn">URL</param>
        /// <returns>true, if new version available, otherwise, false.</returns>
        public static bool Check(string address)
        { 
            try
            {
                StreamReader stream = new StreamReader(new WebClient().OpenRead(address));
                version = stream.ReadLine();
                url = stream.ReadLine();
                stream.Close();

                return (version != null && version != Application.ProductVersion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception while Checking Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionReport.Create(ex, "Exception @ <Updater.Check>");
                return false;
            }
        }
    }
}
