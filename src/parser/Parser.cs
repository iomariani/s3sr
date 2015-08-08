using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using s3pi.Settings;
using s3pi.Package;
using s3pi.Interfaces;
using s3pi.WrapperDealer;
using CASPartResource;
using CatalogResource;
using NameMapResource;
using System.Threading;

namespace mktm.ts3tools.s3sr
{
    /// <summary>
    /// Class that Handle the Script Reading and Compiling Process
    /// </summary>
    class Parser
    {
        #region Callback Events
        public static ScriptProcessor.ChangeVersion ChangeVersion;
        public static ScriptProcessor.ChangeFile ChangeFile;
        public static ScriptProcessor.ChangeKey ChangeKey;
        public static ScriptProcessor.ChangeInstruction ChangeInstruction;
        public static ScriptProcessor.AddInstruction AddInstruction;
        #endregion

        public static string ErrorMessage = "";
        

        /// <summary>
        /// Validate version parsed from Script
        /// </summary>
        /// <param name="version">Version in String Value</param>
        /// <returns>true if valid, false if not</returns>
        public static bool isVersionValid(string version)
        {
            return Versionizer.Attributes.Valids.IndexOf(version.ToUpper()) != -1;
        }

        /// <summary>
        /// Attempts to transform a string to it's respective Enum Type
        /// </summary>
        /// <typeparam name="T">Expected Enum</typeparam>
        /// <param name="name">Value as String from respective Enum</param>
        /// <returns>Enum value as it's own Type</returns>
        public static T StringToEnum<T>(string name)
        {
            return (T)Enum.Parse(typeof(T), name);
        }

        /// <summary>
        /// Begin the Script Reading and Compiling Process of the scripts passed to <paramref name="path_Scripts"/>.
        /// </summary>
        /// <param name="path_Scripts">Array containing the Scripts Paths to run</param>
        public static void Start(string[] path_Scripts)
        {
            #region Check for Updates
            if (Settings.CheckUpdates == Settings.CheckUpdateState.Always)
                if (Updater.Check(Settings.UpdateURL))
                {
                    (new frmUpdate()).ShowDialog();
                    if (MessageBox.Show("Since there was a update available would you like to abort processing this script?", "Abort Script", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Environment.Exit(0);
                }
            #endregion

            #region Validate Path Settings

            #region BASE
            if (string.IsNullOrEmpty(Settings.PathBASE.Trim()))
            {
                MessageBox.Show("Base Game path wasn't specified.\nOperation aborted.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            #endregion

            #region EP01
            if (Settings.HasEP01 & string.IsNullOrEmpty(Settings.PathEP01.Trim()))
            {
                switch (MessageBox.Show("You have EP01, but it's path wasn't specified correctly.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read EP01 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region SP01
            if (Settings.HasSP01 & string.IsNullOrEmpty(Settings.PathSP01.Trim()))
            {
                switch (MessageBox.Show("You have SP01, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read SP01 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region EP02
            if (Settings.HasEP02 & string.IsNullOrEmpty(Settings.PathEP02.Trim()))
            {
                switch (MessageBox.Show("You have EP02, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read EP02 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region SP02
            if (Settings.HasSP02 & string.IsNullOrEmpty(Settings.PathSP02.Trim()))
            {
                switch (MessageBox.Show("You have SP02, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read SP02 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region EP03
            if (Settings.HasEP03 & string.IsNullOrEmpty(Settings.PathEP03.Trim()))
            {
                switch (MessageBox.Show("You have EP03, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read EP03 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region SP03
            if (Settings.HasSP03 & string.IsNullOrEmpty(Settings.PathSP03.Trim()))
            {
                switch (MessageBox.Show("You have SP03, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read SP03 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region EP04
            if (Settings.HasEP04 & string.IsNullOrEmpty(Settings.PathEP04.Trim()))
            {
                switch (MessageBox.Show("You have EP04, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read EP04 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region SP04
            if (Settings.HasSP04 & string.IsNullOrEmpty(Settings.PathSP04.Trim()))
            {
                switch (MessageBox.Show("You have SP04, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read EP04 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region EP05
            if (Settings.HasEP05 & string.IsNullOrEmpty(Settings.PathEP05.Trim()))
            {
                switch (MessageBox.Show("You have EP05, but it's path wasn't specified.\nDo you want to abort the operation?\nIf you don't, the script shall continue but will not read EP04 operations, in case it exists.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region Output
            if (string.IsNullOrEmpty(Settings.PathOutput.Trim()))
            {
                MessageBox.Show("Output Package Path isn't specified.\nRun the main application again to do so.\n\nOperation aborted.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            #endregion
            
            #endregion

            string ScriptVersion = "BASE";
            NameMapResource.NameMapResource _KEYs = new NameMapResource.NameMapResource(0, null);
            List<string> _ScriptLines = new List<string>();
            List<Script> _Script = new List<Script>();
            List<List<string>> _paths = new List<List<string>>();

            try
            {
                #region Arrange Package Files from Folders
                foreach (string VersionValue in Versionizer.Attributes.Valids)
                {
                    _Script.Add(new Script(StringToEnum<Versionizer.Enums.Valid>(VersionValue)));
                    _paths.Add(new List<string>());
                }

                Versionizer.Methods.UpdatePackagePaths(ref _paths);
                #endregion

                #region Begin to Loop Scripts
                for (int i = 0; i < path_Scripts.Length; i++)
                {
                    _ScriptLines = new List<string>(File.ReadAllLines(path_Scripts[i]));
                    if ((new FileInfo(path_Scripts[i])).Length == 0)
                    {
                        MessageBox.Show(string.Format("Error while parsing script \"{0}\".\n\nScript is null.", path_Scripts[i])
                            , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    #region Begin Reading Script
                    try
                    { // #002
                        for (int x = 0; x < _ScriptLines.Count; x++)
                        {
                            #region Jump Blank/Comment lines
                            if (string.IsNullOrEmpty(_ScriptLines[x].Trim()) || _ScriptLines[x].Trim().StartsWith("::"))
                                continue;
                            #endregion

                            #region Verify Script Version
                            if (_ScriptLines[x].Trim().StartsWith("["))
                            {
                                ScriptVersion = _ScriptLines[x].Trim().ToUpper().Replace("[", string.Empty).Replace("]", string.Empty);
                                if (!isVersionValid(ScriptVersion))
                                {
                                    MessageBox.Show(string.Format("Error while parsing script.\nInvalid version found at line {0}:\n\"{1}\"\n\nOperation aborted.", new string[] { (x + 1).ToString(), ScriptVersion }), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                continue;
                            }
                            #endregion

                            #region Handle KeyName Reference & Script Line
                            string[] parsingScript;
                            if (_ScriptLines[x].Trim().StartsWith("{"))
                                parsingScript = new string[] { _ScriptLines[x], _ScriptLines[++x] };
                            else
                                parsingScript = new string[] { _ScriptLines[x] };

                            if (!(_Script[(int)StringToEnum<Versionizer.Enums.Valid>(ScriptVersion)].AddCommand(parsingScript, x)))
                                return;
                            
                            #endregion

                            Application.DoEvents();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Exception while Reading Script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ExceptionReport.Create(ex, "Exception @ <Parser.Start#ReadScript>");
                        return;
                    }
                    #endregion

                    #region Look for Duplicated Script Lines
                    try
                    {
                        if(Settings.ScriptTesting && Settings.VerifyDuplicatedInstances)
                            foreach (string currentVersion in Versionizer.Attributes.Valids)
                                for (int iDuplicate = 0; iDuplicate < _Script[(int)StringToEnum<Versionizer.Enums.Valid>(currentVersion)].Commands.Count; iDuplicate++)
                                {
                                    int[] duplicates = new int[0];
                                    if ((duplicates = _Script[(int)StringToEnum<Versionizer.Enums.Valid>(currentVersion)].FindDuplicates()).Length > 0)
                                    {
                                        MessageBox.Show(string.Format("Found Duplicated Lines on the [{0}] Script Section.\nReference: Lines({1}, {2})\n\nOperation aborted.", new string[] { StringToEnum<Versionizer.Enums.Valid>(currentVersion).ToString(), (duplicates[0] + 1).ToString(), (duplicates[1] + 1).ToString() }), "Error");
                                        return;
                                    }
                                }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Exception while Looking for Duplicated Script Lines", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ExceptionReport.Create(ex, "Exception @ <Parser.Start#FindDuplicated>");
                        return;
                    }
                    #endregion
                    
                    FileInfo _ScriptInfo = new FileInfo(path_Scripts[i]);

                    #region Begin Script Rules on the Packages
                    int PackageCount = _paths[(int)Versionizer.Enums.Valid.BASE].Count;
                    IPackage srcPackage = null; ;
                    IPackage outPackage = Package.NewPackage(0);
                    IList<IResourceIndexEntry> lResources = null;
                    int ResourceCount = 0;

                    for (int iVersion = 0; iVersion < Versionizer.Attributes.Valids.Count; iVersion++)
                    {
                        if (Settings.ScriptTesting && Settings.AdvancedStatistics) // Call delegate frmScriptProcess
                            ChangeVersion(iVersion);

                        #region Verify if User have the Current Game Version
                        switch (iVersion)
                        {
                            case (int)Versionizer.Enums.Valid.EP01:
                                if (!Settings.HasEP01)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.SP01:
                                if (!Settings.HasSP01)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.EP02:
                                if (!Settings.HasEP02)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.SP02:
                                if (!Settings.HasSP02)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.EP03:
                                if (!Settings.HasEP03)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.SP03:
                                if (!Settings.HasSP03)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.EP04:
                                if (!Settings.HasEP04)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.SP04:
                                if (!Settings.HasSP04)
                                    continue;
                                break;
                            case (int)Versionizer.Enums.Valid.EP05:
                                if (!Settings.HasEP05)
                                    continue;
                                break;
                        }
                        #endregion

                        PackageCount = _paths[iVersion].Count;

                        #region Verify if the Current Game Version contains packages/commands
                        if (PackageCount == 0 || _Script[iVersion].Commands.Count == 0)
                            continue;
                        #endregion

                        for (int iPackage = 0; iPackage < PackageCount; iPackage++)
                        {
                            if (Settings.ScriptTesting && Settings.AdvancedStatistics)
                                ChangeFile(_paths[iVersion][iPackage]);

                            #region Verify if the Reading Package really exists
                            if (!File.Exists(_paths[iVersion][iPackage]))
                            {
                                MessageBox.Show(string.Format("File \"{0}\" does not exist.\nMake sure the path setting for \"{1}\" section is at the right location.",
                                    new string[] { _paths[iVersion][iPackage], ((Versionizer.Enums.Valid)iVersion).ToString() }),
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            #endregion

                            List<Catalog> iRemove = new List<Catalog>();

                            FileInfo CurrentPackage = new FileInfo(_paths[iVersion][iPackage]);

                            #region Decrypt Store DBPP Package
                            if (iVersion == Versionizer.Attributes.Valids.Count - 2)
                            {
                                bool AttemptDecrypt = false;
                            Label_AttemptOpenPackage:

                                if (AttemptDecrypt)
                                {
                                    MessageBox.Show(string.Format(
                                            "Seems like the file \"{0}\" is still encrypted.\nApplication will avoid this file, whatever lurks inside it is still a mistery.", CurrentPackage.ToString())
                            , "Encrypted File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    continue;
                                }

                                try
                                {
                                    srcPackage = Package.OpenPackage(0, CurrentPackage.ToString());
                                }
                                catch (InvalidDataException ex)
                                {
                                    if (ex.Message.Contains("DBPP"))
                                    {
                                        if (!Settings.DecryptStoreFiles)
                                            continue;

                                        if (MessageBox.Show(
                                            string.Format(
                                            "File \"{0}\" is encrypted.\nDo you want to decrypt it?\n\nThe application will not be able to read it unless you do.", CurrentPackage.ToString())
                            , "Encrypted File", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                            == DialogResult.Yes)
                                        {
                                        Label_AttemptDecrypt:
                                            string s3rcPath = Application.StartupPath + @"\s3rc.EXE";
                                            if (!File.Exists(s3rcPath))
                                            {
                                                switch (MessageBox.Show(string.Format(
                                                    "Couldn't find s3rc on the application folder:\n{0}",
                                                    s3rcPath), "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error))
                                                {
                                                    case DialogResult.Abort:
                                                        Environment.Exit(0);
                                                        break;
                                                    case DialogResult.Retry:
                                                        goto Label_AttemptDecrypt;
                                                    case DialogResult.Ignore:
                                                        continue;
                                                }
                                            }

                                            try
                                            {
                                                string tmpPackage = System.IO.Path.GetTempPath() + CurrentPackage.Name;
                                                File.Copy(CurrentPackage.ToString(), tmpPackage, true);
                                                Process s3rcProcess = new Process();
                                                s3rcProcess.StartInfo.FileName = s3rcPath;
                                                s3rcProcess.StartInfo.Arguments = "-f \"" + tmpPackage + "\"";
                                                s3rcProcess.StartInfo.CreateNoWindow = true;
                                                s3rcProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                                s3rcProcess.Start();
                                                s3rcProcess.WaitForExit();
                                                Thread.Sleep(1000);
                                                Application.DoEvents();
                                            }
                                            catch (Exception s3rcException)
                                            {
                                                MessageBox.Show(s3rcException.ToString(), "Exception while running s3rc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                ExceptionReport.Create(s3rcException, "Exception @ <Parser.Start#s3rc>");
                                                return;
                                            }

                                            AttemptDecrypt = true;

                                            goto Label_AttemptOpenPackage;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(ex.ToString(), "Exception trying to Open Package", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        ExceptionReport.Create(ex, "Exception @ <Parser.Start#OpenPackage!DBPP>");
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Exception trying to Open Package", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ExceptionReport.Create(ex, "Exception @<Parser.Start#OpenPackage>");
                                }
                            }
                            else
                            #endregion

                            srcPackage = Package.OpenPackage(0, CurrentPackage.ToString());

                            for (int iScript = 0; iScript < _Script[iVersion].Commands.Count; iScript++)
                            {
                                if (iScript > _Script[iVersion].Commands.Count)
                                    continue;

                                #region Begin to look inside the Packages
                                lResources = srcPackage.FindAll(x =>
                                {
                                    #region Validate Key Reference Information
                                    if (x.ResourceType == _Script[iVersion].Commands[iScript].ResourceType
                                        //& x.ResourceGroup == _Script[iVersion].Commands[iScript].ResourceGroup
                                        // (Not necessary, seems like it's hard to match duplicated instances at this point)
                                        //& x.Instance == _Script[iVersion].Commands[iScript].Instance
                                        )
                                    {
                                        if (_Script[iVersion].Commands[iScript].wildcard_Instance == false && x.Instance == _Script[iVersion].Commands[iScript].Instance)
                                        {
                                    #endregion

                                            #region Add Resource Key if Specified
                                            if (!string.IsNullOrEmpty(_Script[iVersion].Commands[iScript].KeyName))
                                                if (!_KEYs.ContainsKey(x.Instance))
                                                    _KEYs.Add(x.Instance, _Script[iVersion].Commands[iScript].KeyName);
                                            #endregion

                                            try
                                            {
                                                #region Handle OBJK
                                                if (x.ResourceType == (uint)Versionizer.Enums.ResourceType.OBJK)
                                                {
                                                    ObjKeyResource.ObjKeyResource objk = new ObjKeyResource.ObjKeyResource(0, WrapperDealer.GetResource(0, srcPackage, x).Stream);
                                                    if (objk == null)
                                                    {
                                                        ErrorMessage = "Invalid OBJK Reference while reading package.\nLine: " + _Script[iVersion].Commands[iScript].LineReference;
                                                        return false;
                                                    }

                                                    if (!HandleOBJKScriptRule(ref objk, _Script[iVersion].Commands[iScript]))
                                                        return false;

                                                    iRemove.Add(_Script[iVersion].Commands[iScript]);

                                                    outPackage.AddResource(x, objk.Stream, true);

                                                    ResourceCount++;
                                                    Application.DoEvents();
                                                    return true;
                                                }
                                                #endregion

                                                #region Handle OBJD
                                                if (x.ResourceType == (uint)Versionizer.Enums.ResourceType.OBJD)
                                                {
                                                    ObjectCatalogResource objd = (ObjectCatalogResource)WrapperDealer.GetResource(0, srcPackage, x);
                                                    if (objd == null)
                                                    {
                                                        ErrorMessage = "Invalid OBJD Reference while reading package.\nLine: " + _Script[iVersion].Commands[iScript].LineReference;
                                                        return false;
                                                    }

                                                    if (!HandleOBJDScriptRule(ref objd, _Script[iVersion].Commands[iScript]))
                                                        return false;

                                                    iRemove.Add(_Script[iVersion].Commands[iScript]);

                                                    outPackage.AddResource(x, objd.Stream, true);
                                                    ResourceCount++;
                                                    Application.DoEvents();
                                                    return true;
                                                }
                                                #endregion

                                                #region Handle CASP
                                                else if (x.ResourceType == (uint)Versionizer.Enums.ResourceType.CASP)
                                                {
                                                    CASPartResource.CASPartResource casp = (CASPartResource.CASPartResource)WrapperDealer.GetResource(0, srcPackage, x);
                                                    if (casp == null)
                                                    {
                                                        MessageBox.Show("Invalid CASP Reference while reading package.\nLine: " + _Script[iVersion].Commands[iScript].LineReference, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        return false;
                                                    }

                                                    if (!HandleCASPScriptRule(ref casp, _Script[iVersion].Commands[iScript]))
                                                        return false;

                                                    iRemove.Add(_Script[iVersion].Commands[iScript]);

                                                    outPackage.AddResource(x, casp.Stream, true);

                                                    ResourceCount++;
                                                    Application.DoEvents();
                                                    return true;
                                                }
                                                #endregion
                                            }
                                            catch (Exception ex)
                                            {
                                                #region Resource Handling Exception
                                                Application.DoEvents();
                                                MessageBox.Show(ex.ToString(), "Exception while Handling Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                ExceptionReport.Create(ex, "Exception @ <Parser.Start#ReadPackage>\n\n" +
                                                    string.Format("key:{0}:{1}:{2}",
                                                    new string[] {
                                                    x.ResourceType.ToString(),
                                                    x.ResourceGroup.ToString(),
                                                    x.Instance.ToString()
                                                }));
                                                return false;
                                                #endregion
                                            }
                                        }
                                        
                                    }

                                    return false;
                                });

                                Application.DoEvents();
                                #endregion
                            }

                            #region Remove Readen Script Line(s)
                            _Script[iVersion].Commands.RemoveAll(x => iRemove.Contains(x));
                            #endregion

                            Application.DoEvents();
                        }
                    }

                    if (ResourceCount > 0)
                    {
                        string outputPackagePath = string.Format(@"{0}\{1}.package",
                            Settings.PathOutput,
                            _ScriptInfo.Name.Replace(_ScriptInfo.Extension, "")
                            );

                        #region Get rid of any older Output Package
                        if (File.Exists(outputPackagePath))
                            File.Delete(outputPackagePath);
                        #endregion

                        #region Create _KEY Resource
                        outPackage.AddResource(
                            (new TGIBlock(0, null, (uint)Versionizer.Enums.ResourceType._KEY, 0x0D45C751, (ulong)Versionizer.Enums.Hashes.ALL))
                            , _KEYs.Stream, false);
                        #endregion

                        #region Save Output Package
                        outPackage.SaveAs(outputPackagePath);
                        #endregion

                        #region Finished Processing Message
                        if (Settings.AlertInfo)
                        {
                            MessageBox.Show(
                                string.Format(
                                "Script \"{0}\" processed successfully.",
                                path_Scripts[i]),
                                "Script Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        #endregion

                        Application.DoEvents();
                    }
                    else
                    {
                        switch(MessageBox.Show("Nothing was processed.\nNo resources match found on the script.", "Attention", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
                        {
                            case DialogResult.Retry:
                                Start(path_Scripts);
                                break;
                        }
                    }
                    #endregion
                }
                #endregion
            }
            catch (Exception exceptionScript)
            {
                MessageBox.Show(exceptionScript.ToString(), "Exception while Parsing Script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionReport.Create(exceptionScript, "Exception @ <Parser.Start#UncaughtException>");
                return;
            }
        }

        #region Specific Resource Handlers for Catalog

        /// <summary>
        /// Handle the <paramref name="objd"/> according to the Catalog <paramref name="_script"/>.
        /// </summary>
        /// <param name="objd">[ref] ObjectCatalogResource</param>
        /// <param name="_script">[ref] Catalog that handled a Script Line</param>
        /// <returns>true if changes on the <paramref name="objd"/> were accepted, false it they were not</returns>
        private static bool HandleOBJDScriptRule(ref ObjectCatalogResource objd, Catalog _script)
        {
            try
            { // #008 OBJD-Parser
                if (_script.change_isStealable)
                    objd.CommonBlock.IsStealable = _script.isStealable;
                if (_script.change_isReposessable)
                    objd.CommonBlock.IsReposessable = _script.isReposessable;
                if (_script.change_objectTypeFlags)
                    objd.ObjectTypeFlags = (ObjectCatalogResource.ObjectType) _script.objectTypeFlags;
                if (_script.change_wallPlacementFlags)
                    objd.WallPlacementFlags = (ObjectCatalogResource.WallPlacement) _script.wallPlacementFlags;
                if (_script.change_movementFlags)
                    objd.MovementFlags = (ObjectCatalogResource.Movement) _script.movementFlags;
                if (_script.change_cutoutTilesPerLevel)
                    objd.CutoutTilesPerLevel = _script.cutoutTilesPerLevel;
                if (_script.change_levels)
                    objd.Levels = _script.levels;
                if (_script.change_ambienceTypeHash)
                    objd.AmbienceTypeHash = _script.ambienceTypeHash;
                if (_script.change_roomCategoryFlags)
                    objd.RoomCategoryFlags = (ObjectCatalogResource.RoomCategory) _script.roomCategoryFlags;
                if (_script.change_functionCategoryFlags)
                    objd.FunctionCategoryFlags = (ObjectCatalogResource.FunctionCategory) _script.functionCategoryFlags;
                if (_script.change_functionSubCategoryFlags)
                    objd.FunctionSubCategoryFlags = (ObjectCatalogResource.FunctionSubCategory) _script.functionSubCategoryFlags;
                if (_script.change_roomSubCategoryFlags)
                    objd.RoomSubCategoryFlags = (ObjectCatalogResource.RoomSubCategory) _script.roomSubCategoryFlags;
                if (_script.change_buildCategoryFlags)
                    objd.BuildCategoryFlags = (ObjectCatalogResource.BuildCategory) _script.buildCategoryFlags;
                if (_script.change_slotPlacementFlags)
                    objd.SlotPlacementFlags = (ObjectCatalogResource.SlotPlacement) _script.slotPlacementFlags;
                if (_script.change_moodletGiven)
                    objd.MoodletGiven = (ObjectCatalogResource.Moodlet) _script.moodletGiven;
                if (_script.change_moodletScore)
                    objd.MoodletScore = _script.moodletScore;
                if (_script.change_price)
                    objd.CommonBlock.Price = _script.price;
                if(_script.change_FireType)
                    objd.CommonBlock.FireType = (CatalogResource.CatalogResource.Common.Fire) _script.FireType;
                if (_script.change_BuildBuyProductStatusFlags)
                    objd.CommonBlock.BuildBuyProductStatusFlags = (CatalogResource.CatalogResource.Common.BuildBuyProductStatus)_script.BuildBuyProductStatusFlags;
                if (_script.change_isVisibleInWorldBuilder)
                    objd.CommonBlock.IsVisibleInWorldBuilder = _script.isVisibleInWorldBuilder;
                if(_script.change_UISortPriority)
                    objd.CommonBlock.UISortPriority = _script.UISortPriority;

                if(_script.OBJDStencils.Count > 0)
                {
                    for(int i = 0; i < _script.OBJDStencils.Count; i++)
                    {
                        objd.Materials.Add();
                        int x = 0; // Hold the Array Positions

                        #region Find Matching Material
                        int MaterialMatchID = -1;
                        for (x = 0; x < objd.Materials.Count; x++)
                        {
                            if (MaterialMatchID != -1) break;

                            for (int x1 = 0; x1 < objd.Materials[x].TGIBlocks.Count; x1++)
                            {
                                if (objd.Materials[x].TGIBlocks[x1].ResourceType == (int)Versionizer.Enums.ResourceType._IMG)
                                    if (objd.Materials[x].TGIBlocks[x1].Instance == _script.OBJDStencils[i].IMG_ReplaceInstance)
                                    {
                                        MaterialMatchID = x;
                                        break;
                                    }
                            }
                        }
                        #endregion

                        objd.Materials[(objd.Materials.Count - 1)] = new CatalogResource.CatalogResource.Material(0, null, objd.Materials[MaterialMatchID]);
                        for (x = 0; x < objd.Materials[(objd.Materials.Count - 1)].TGIBlocks.Count; x++)
                        {
                            if (objd.Materials[(objd.Materials.Count - 1)].TGIBlocks[x].ResourceType == (int)Versionizer.Enums.ResourceType._IMG)
                                if (objd.Materials[(objd.Materials.Count - 1)].TGIBlocks[x].Instance == _script.OBJDStencils[i].IMG_ReplaceInstance)
                                {
                                    objd.Materials[(objd.Materials.Count - 1)].TGIBlocks[x].Instance = _script.OBJDStencils[i].IMG_Instance;
                                    break;
                                }
                        }
                        objd.Materials[(objd.Materials.Count - 1)].Unknown3 = _script.OBJDStencils[i].StencilID;
                    }
                }
            }
            catch(Exception ex)
            {
                ExceptionReport.Create(ex, "Exception @ <Parser.HandleOBJDScriptRule>");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handle the <paramref name="casp"/> according to the Catalog <paramref name="_script"/>.
        /// </summary>
        /// <param name="casp">[ref] CASPartResource</param>
        /// <param name="_script">[ref] Catalog that handled a Script Line</param>
        /// <returns>true if changes on the <paramref name="casp"/>  were accepted, false it they were not</returns>
        private static bool HandleCASPScriptRule(ref CASPartResource.CASPartResource casp, Catalog _script)
        {
            try
            { // #009 CASP-Parser
                if (_script.change_Clothing)
                    casp.Clothing = (ClothingType)_script.Clothing;
                if (_script.change_AgeGender)
                    casp.AgeGender = (AgeGenderFlags)_script.AgeGender;
                if (_script.change_ClothingCategory)
                    casp.ClothingCategory = (ClothingCategoryFlags)_script.ClothingCategory;
                if (_script.change_SortingPriority)
                    casp.SortPriority = _script.SortingPriority;
            }
            catch(Exception ex)
            {
                ExceptionReport.Create(ex, "Exception @ <Parser.HandleCASPScriptRule>");
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Handle the <paramref name="objk"/> according to the Catalog <paramref name="_script"/>.
        /// </summary>
        /// <param name="casp">[ref] ObjectKeyResource</param>
        /// <param name="_script">[ref] Catalog that handled a Script Line</param>
        /// <returns>true if changes on the <paramref name="objk"/>  were accepted, false it they were not</returns>
        private static bool HandleOBJKScriptRule(ref ObjKeyResource.ObjKeyResource objk, Catalog _script)
        {
            try
            { // #009 OBJK-Parser
                if (_script.change_ScriptClass)
                    objk.ComponentData["scriptClass"] = new ObjKeyResource.ObjKeyResource.CDTString(0, null, "scriptClass", 0, _script.ScriptClass);
            }
            catch(Exception ex)
            {
                ExceptionReport.Create(ex, "Exception @ <Parser.HandleOBJKScriptRule>");
                return false;
            }
            return true;
        }
        #endregion
    }
}