using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

/// Purpose: Simplify the update of the application for new Game Versions
namespace mktm.ts3tools.s3sr.Versionizer
{
    #region Attributes
    public static class Attributes
    {
        public static readonly List<string> Valids = new List<string>(Enum.GetNames(typeof(Versionizer.Enums.Valid)));
    }
    #endregion

    #region Enumerators
    public class Enums
    {
        /// <summary>
        /// The Sims 3 ResourceType uint
        /// </summary>
        public enum ResourceType : uint
        {
            OBJD = 0x319E4F1D,
            CASP = 0x034AEECB,
            OBJK = 0x02DC343F,
            _IMG = 0x00B2D882,
            _KEY = 0x0166038C
        }

        /// <summary>
        ///     <fnv64>s3sr_VersionHash_#</fnv64>
        /// </summary>
        public enum Hashes : ulong
        {
            BASE = 0xF694916A1F5F7977,
            EP01 = 0x0FEADB6A2D8A9B96,
            SP01 = 0x746CF569D59718F0,
            EP02 = 0x0FEADB6A2D8A9B95,
            SP02 = 0x746CF569D59718F3,
            EP03 = 0x0FEADB6A2D8A9B94,
            SP03 = 0x746CF569D59718F2,
            EP04 = 0x0FEADB6A2D8A9B93,
            SP04 = 0x746CF569D59718F5,
            EP05 = 0x0FEADB6A2D8A9B92,
            SP05 = 0x746CF569D59718F4,
            EP06 = 0x0FEADB6A2D8A9B91,
            SP06 = 0x746CF569D59718F7,
            EP07 = 0x0FEADB6A2D8A9B90,
            SP07 = 0x746CF569D59718F6,
            EP08 = 0x0FEADB6A2D8A9B9F,
            SP08 = 0x746CF569D59718F9,
            ALL = 0xBFFFE030F30EACD1 // s3sr
        }

        /// <summary>
        /// The current version to be readen by the script
        /// </summary>
        public enum Valid : int
        {
            BASE,
            EP01,
            SP01,
            EP02,
            SP02,
            EP03,
            SP03,
            EP04,
            SP04,
            EP05,
            SP05,
            EP06,
            STORE,
            CUSTOM
        }
    }
    #endregion

    #region Methods
    public static class Methods
    {
        /// <summary>
        /// Getter for a Game Path
        /// </summary>
        /// <param name="version">Game version</param>
        /// <returns>Path of the Game</returns>
        public static string Path(string version)
        {
            switch (version.ToUpper())
            {
                case "BASE": return Settings.PathBASE;
                case "EP01": return Settings.PathEP01;
                case "SP01": return Settings.PathSP01;
                case "EP02": return Settings.PathEP02;
                case "SP02": return Settings.PathSP02;
                case "EP03": return Settings.PathEP03;
                case "SP03": return Settings.PathSP03;
                case "EP04": return Settings.PathEP04;
                case "SP04": return Settings.PathSP04;
                case "EP05": return Settings.PathEP05;
                case "SP05": return Settings.PathSP05;
                case "EP06": return Settings.PathEP06;
                case "STORE": return Settings.PathStore;
                case "STORE_ALTERNATIVE": return Settings.PathStore_Alternative;
                case "CUSTOM": return Settings.PathCustom;
                default: return "";
            }
        }

        /// <summary>
        /// Setter for a Game Path
        /// </summary>
        /// <param name="version">Game version</param>
        /// <param name="path">Path for the Game</param>
        public static void Path(string version, string path)
        {
            switch (version.ToUpper())
            {
                case "BASE": Settings.PathBASE = path; break;
                case "EP01": Settings.PathEP01 = path; break;
                case "SP01": Settings.PathSP01 = path; break;
                case "EP02": Settings.PathEP02 = path; break;
                case "SP02": Settings.PathSP02 = path; break;
                case "EP03": Settings.PathEP03 = path; break;
                case "SP03": Settings.PathSP03 = path; break;
                case "EP04": Settings.PathEP04 = path; break;
                case "SP04": Settings.PathSP04 = path; break;
                case "EP05": Settings.PathEP05 = path; break;
                case "SP05": Settings.PathSP05 = path; break;
                case "EP06": Settings.PathEP06 = path; break;
                case "STORE": Settings.PathStore = path; break;
                case "CUSTOM": Settings.PathCustom = path; break;
            }
        }

        /// <summary>
        /// Retrieve the DBPF Packages related to a Game
        /// </summary>
        /// <param name="version">Game version</param>
        /// <returns>DBPF Packages Paths</returns>
        public static string[] GetPackages(string version)
        {
            switch (version.ToUpper())
            {
                case "BASE": return new string[] { Settings.PathBASE + @"\GameData\Shared\Packages\DeltaBuild0.package", Settings.PathBASE + @"\GameData\Shared\Packages\FullBuild0.package" };
                case "EP01": return new string[] { Settings.PathEP01 + @"\GameData\Shared\Packages\FullBuildep1.package" };
                case "SP01": return new string[] { Settings.PathSP01 + @"\GameData\Shared\Packages\FullBuild_p03.package" };
                case "EP02": return new string[] { Settings.PathEP02 + @"\GameData\Shared\Packages\FullBuild_p04.package" };
                case "SP02": return new string[] { Settings.PathSP02 + @"\GameData\Shared\Packages\FullBuild_p05.package" };
                case "EP03": return new string[] { Settings.PathEP03 + @"\GameData\Shared\Packages\FullBuild_p06.package" };
                case "SP03": return new string[] { Settings.PathSP03 + @"\GameData\Shared\Packages\FullBuild_p07.package" };
                case "EP04": return new string[] { Settings.PathEP04 + @"\GameData\Shared\Packages\FullBuild_p08.package" };
                case "SP04": return new string[] { Settings.PathSP04 + @"\GameData\Shared\Packages\FullBuild_p09.package" };
                case "EP05": return new string[] { Settings.PathEP05 + @"\GameData\Shared\Packages\FullBuild0_p10.package", Settings.PathEP05 + @"\GameData\Shared\Packages\FullBuild1_p10.package" };
                case "SP05": return new string[] { Settings.PathSP05 + @"\GameData\Shared\Packages\FullBuild_p11.package" };
                case "EP06": return new string[] { Settings.PathEP06 + @"\GameData\Shared\Packages\FullBuild_p12.package" };
                case "STORE": return Directory.GetFiles(Settings.PathStore);
                case "STORE_ALTERNATIVE": return Settings.PathStore_SearchSubFiles ? Directory.GetFiles(Settings.PathStore_Alternative, "*.*", SearchOption.AllDirectories) : Directory.GetFiles(Settings.PathStore_Alternative);
                case "CUSTOM": return Settings.PathCustom_SearchSubFiles ? Directory.GetFiles(Settings.PathCustom, "*.*", SearchOption.AllDirectories) : Directory.GetFiles(Settings.PathCustom);
                default: return new string[] { };
            }
        }

        /// <summary>
        /// Set the referenced <paramref name="variable"/> array to their respective index DBPF Packages
        /// </summary>
        /// <param name="variable">The string List of the Game variables</param>
        public static void UpdatePackagePaths(ref List<List<string>> variable)
        {
            if (!string.IsNullOrEmpty(Settings.PathBASE.Trim()))
                variable[(int)Versionizer.Enums.Valid.BASE].AddRange(Versionizer.Methods.GetPackages("BASE"));

            if (!string.IsNullOrEmpty(Settings.PathEP01))
                variable[(int)Versionizer.Enums.Valid.EP01].AddRange(Versionizer.Methods.GetPackages("EP01"));

            if (!string.IsNullOrEmpty(Settings.PathSP01))
                variable[(int)Versionizer.Enums.Valid.SP01].AddRange(Versionizer.Methods.GetPackages("SP01"));

            if (!string.IsNullOrEmpty(Settings.PathEP02))
                variable[(int)Versionizer.Enums.Valid.EP02].AddRange(Versionizer.Methods.GetPackages("EP02"));

            if (!string.IsNullOrEmpty(Settings.PathSP02))
                variable[(int)Versionizer.Enums.Valid.SP02].AddRange(Versionizer.Methods.GetPackages("SP02"));

            if (!string.IsNullOrEmpty(Settings.PathEP03))
                variable[(int)Versionizer.Enums.Valid.EP03].AddRange(Versionizer.Methods.GetPackages("EP03"));

            if (!string.IsNullOrEmpty(Settings.PathSP03))
                variable[(int)Versionizer.Enums.Valid.SP03].AddRange(Versionizer.Methods.GetPackages("SP03"));

            if (!string.IsNullOrEmpty(Settings.PathEP04))
                variable[(int)Versionizer.Enums.Valid.EP04].AddRange(Versionizer.Methods.GetPackages("EP04"));

            if (!string.IsNullOrEmpty(Settings.PathSP04))
                variable[(int)Versionizer.Enums.Valid.SP04].AddRange(Versionizer.Methods.GetPackages("SP04"));

            if (!string.IsNullOrEmpty(Settings.PathEP05.Trim()))
                variable[(int)Versionizer.Enums.Valid.EP05].AddRange(Versionizer.Methods.GetPackages("EP05"));

            if (!string.IsNullOrEmpty(Settings.PathSP05.Trim()))
                variable[(int)Versionizer.Enums.Valid.SP05].AddRange(Versionizer.Methods.GetPackages("SP05"));

            if (!string.IsNullOrEmpty(Settings.PathEP06.Trim()))
                variable[(int)Versionizer.Enums.Valid.EP06].AddRange(Versionizer.Methods.GetPackages("EP06"));

            if (!string.IsNullOrEmpty(Settings.PathStore))
                variable[(int)Versionizer.Enums.Valid.STORE].AddRange(Versionizer.Methods.GetPackages("STORE"));

            if (!string.IsNullOrEmpty(Settings.PathStore_Alternative))
                variable[(int)Versionizer.Enums.Valid.STORE].AddRange(Versionizer.Methods.GetPackages("STORE_ALTERNATIVE"));

            if (!string.IsNullOrEmpty(Settings.PathCustom))
                variable[(int)Versionizer.Enums.Valid.CUSTOM].AddRange(Versionizer.Methods.GetPackages("CUSTOM"));

            if (variable[(int)Versionizer.Enums.Valid.STORE].Count > 0)
                variable[(int)Versionizer.Enums.Valid.STORE].RemoveAll(
                    delegate(string s)
                    {
                        return !((s.ToLower().EndsWith(".package")) | (s.ToLower().EndsWith(".dbc")) | (s.ToLower().EndsWith(".ebc")) | (s.ToLower().EndsWith(".nhd")));
                    });

            if (!string.IsNullOrEmpty(Settings.PathCustom))
                variable[(int)Versionizer.Enums.Valid.CUSTOM].RemoveAll(
                    delegate(string s)
                    {
                        return !((s.ToLower().EndsWith(".package")) | (s.ToLower().EndsWith(".dbc")) | (s.ToLower().EndsWith(".ebc")) | (s.ToLower().EndsWith(".nhd")));
                    });
        }

        internal class Game
        {
            public string version;
            public string name;
            public System.Drawing.Bitmap icon;

            public Game(string version, string name, System.Drawing.Bitmap icon = null)
            {
                this.version = version;
                this.name = name;
                this.icon = icon;
            }
        }

        public static void CreateRadios(ref FlowLayoutPanel container, EventHandler checkedchanged, ref ToolTip tooltip)
        {
            List<Game> Games = new List<Game> {
                new Game("EP01", "World Adventures", mktm.ts3tools.s3sr.Properties.Resources.Sims3EP01_16),
                new Game("SP01", "High-End Loft Stuff", mktm.ts3tools.s3sr.Properties.Resources.Sims3SP01_16),
                new Game("EP02", "Ambitions", mktm.ts3tools.s3sr.Properties.Resources.Sims3EP02_16),
                new Game("SP02", "Fast Lane Stuff", mktm.ts3tools.s3sr.Properties.Resources.Sims3SP02_16),
                new Game("EP03", "Late Night", mktm.ts3tools.s3sr.Properties.Resources.Sims3EP03_16),
                new Game("SP03", "Outdoor Living Stuff", mktm.ts3tools.s3sr.Properties.Resources.Sims3SP03_16),
                new Game("EP04", "Generations", mktm.ts3tools.s3sr.Properties.Resources.Sims3EP04_16),
                new Game("SP04", "Town Life Stuff", mktm.ts3tools.s3sr.Properties.Resources.Sims3SP04_16),
                new Game("EP05", "Pets", mktm.ts3tools.s3sr.Properties.Resources.Sims3EP05_16),
                new Game("SP05", "Master Suite Stuff", mktm.ts3tools.s3sr.Properties.Resources.Sims3SP05_16),
                new Game("EP06", "Showtime", mktm.ts3tools.s3sr.Properties.Resources.Sims3EP06_16)
            };

            int i = 0;
            foreach (string version in Versionizer.Attributes.Valids)
            {
                if (!version.StartsWith("EP") && !version.StartsWith("SP")) continue;
                RadioButton radio = new RadioButton();
                radio.Name = "rad" + Games[i].version;
                radio.Text = "      " + Games[i].name;
                radio.Tag = Games[i].version;
                radio.Size = new System.Drawing.Size(155, 24);
                radio.Location = new System.Drawing.Point(3, 24 * (i + 1) + 2);
                radio.Image = Games[i].icon;
                radio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                radio.Margin = new Padding(3, 0, 0, 0);
                radio.CheckedChanged += checkedchanged;
                tooltip.SetToolTip(radio, Games[i].name + "  Path Settings");

                switch (version.ToUpper())
                {
                    case "BASE": radio.Enabled = true; break;
                    case "EP01": radio.Enabled = Settings.HasEP01; break;
                    case "SP01": radio.Enabled = Settings.HasSP01; break;
                    case "EP02": radio.Enabled = Settings.HasEP02; break;
                    case "SP02": radio.Enabled = Settings.HasSP02; break;
                    case "EP03": radio.Enabled = Settings.HasEP03; break;
                    case "SP03": radio.Enabled = Settings.HasSP03; break;
                    case "EP04": radio.Enabled = Settings.HasEP04; break;
                    case "SP04": radio.Enabled = Settings.HasSP04; break;
                    case "EP05": radio.Enabled = Settings.HasEP05; break;
                    case "SP05": radio.Enabled = Settings.HasSP05; break;
                    case "EP06": radio.Enabled = Settings.HasEP06; break;
                }

                container.Controls.Add(radio);
                i++;
            }
        }
    }
    #endregion
}