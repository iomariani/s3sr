using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace mktm.ts3tools.s3sr
{
    public class Catalog
    {
        #region Attributes

        public bool Borked;
        public int LineReference;
        public string KeyName;
        public string ScriptReference;
        public uint ResourceType;
        public uint ResourceGroup;
        public ulong Instance;

        #region OBJD Attributes
        public bool isStealable;
        public bool isReposessable;
        public uint objectTypeFlags;
        public uint wallPlacementFlags;
        public uint movementFlags;
        public uint cutoutTilesPerLevel;
        public uint levels;
        public uint ambienceTypeHash;
        public uint roomCategoryFlags;
        public uint functionCategoryFlags;
        public ulong functionSubCategoryFlags;
        public ulong roomSubCategoryFlags;
        public uint buildCategoryFlags;
        public uint slotPlacementFlags;
        public uint moodletGiven;
        public int moodletScore;
        public float price;
        public uint FireType;
        public uint BuildBuyProductStatusFlags;
        public bool isScriptEnabled;
        public bool isVisibleInWorldBuilder;
        public List<Stencils.OBJD> OBJDStencils = new List<Stencils.OBJD>();
        public uint UISortPriority;
        #endregion

        #region OBJK Attributes
        public string ScriptClass;
        #endregion

        #region CASP Attributes
        public uint Clothing;
        public uint AgeGender;
        public uint ClothingCategory;
        public float SortingPriority;
        #endregion

        #region Change Booleans
        public bool wildcard_Instance = false;
        public bool wildcard_Group = false;
        public bool change_isStealable = false;
        public bool change_isReposessable = false;
        public bool change_objectTypeFlags = false;
        public bool change_wallPlacementFlags = false;
        public bool change_movementFlags = false;
        public bool change_cutoutTilesPerLevel = false;
        public bool change_levels = false;
        public bool change_ambienceTypeHash = false;
        public bool change_roomCategoryFlags = false;
        public bool change_functionCategoryFlags = false;
        public bool change_functionSubCategoryFlags = false;
        public bool change_roomSubCategoryFlags = false;
        public bool change_buildCategoryFlags = false;
        public bool change_slotPlacementFlags = false;
        public bool change_moodletGiven = false;
        public bool change_moodletScore = false;
        public bool change_price = false;
        public bool change_FireType = false;
        public bool change_BuildBuyProductStatusFlags = false;
        public bool change_isScriptEnabled = false;
        public bool change_isVisibleInWorldBuilder = false;
        public bool change_UISortPriority = false;

        public bool change_Clothing = false;
        public bool change_AgeGender = false;
        public bool change_ClothingCategory = false;
        public bool change_SortingPriority = false;

        public bool change_ScriptClass = false;
        #endregion

        #endregion
        
        #region Constructors
        /// <summary>
        /// Constructor to arrange attributes from the script.
        /// </summary>
        /// <param name="scriptString">Script, two indexes to generate keyName;
        /// [0] = keyName;
        /// [1] = script
        /// </param>
        /// <param name="lineRef">Script Line Reference</param>
        public Catalog(string[] scriptString, int lineRef)
        {
            this.LineReference = lineRef;
            if (scriptString.Length == 1)
            {
                this.KeyName = "";
                this.ScriptReference = scriptString[0];
            }
            else
            {
                this.KeyName = scriptString[0].Replace("{", string.Empty).Replace("}", string.Empty);
                this.ScriptReference = scriptString[1];
            }

            List<string> arrScript = new List<string>(this.ScriptReference.ToUpper().Replace(":0X", ":0x").Split(' '));

            if (arrScript[0] == "OBJD")
                this.ResourceType = (uint)Versionizer.Enums.ResourceType.OBJD;
            else if (arrScript[0] == "CASP")
                this.ResourceType = (uint)Versionizer.Enums.ResourceType.CASP;
            else if (arrScript[0] == "OBJK")
                this.ResourceType = (uint)Versionizer.Enums.ResourceType.OBJK;
            else
            {
                this.Borked = true;
                return;
            }

            try
            {
                int _Instance = arrScript.FindIndex(s => s.StartsWith("INSTANCE"));
                if (_Instance != -1)
                {
                    this.wildcard_Instance = (arrScript[_Instance].Split(':')[1] == "*");
                    if (!this.wildcard_Instance)
                    {
                        this.Instance = Convert.ToUInt64(arrScript[_Instance].Split(':')[1], 16);
                    }
                }
                else
                {
                    this.Borked = true;
                    return;
                }

                int _Group = arrScript.FindIndex(s => s.StartsWith("GROUP"));
                if (_Group != -1)
                    this.ResourceGroup = Convert.ToUInt32(arrScript[_Group].Split(':')[1], 16);
                else
                    this.ResourceGroup = 0x00000000;
            }
            catch
            {
                this.Borked = true;
                return;
            }

            switch (this.ResourceType)
            {
                #region Handle OBJD Attributes
                case 0x319E4F1D:
                    try
                    {
                        if (this.ScriptReference.ToUpper().Contains("isStealable:".ToUpper()))
                        {
                            int _isStealable = arrScript.FindIndex(s => s.StartsWith("isStealable:".ToUpper()));
                            if (_isStealable != -1)
                            {
                                this.change_isStealable = true;
                                this.isStealable = arrScript[_isStealable].Split(':')[1].Contains("1");
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("isReposessable:".ToUpper()))
                        {
                            int _isReposessable = arrScript.FindIndex(s => s.StartsWith("isReposessable:".ToUpper()));
                            if (_isReposessable != -1)
                            {
                                this.change_isReposessable = true;
                                this.isReposessable = arrScript[_isReposessable].Split(':')[1].Contains("1");
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("objectTypeFlags:".ToUpper()))
                        {
                            int _objectTypeFlags = arrScript.FindIndex(s => s.StartsWith("objectTypeFlags:".ToUpper()));
                            if (_objectTypeFlags != -1)
                            {
                                this.change_objectTypeFlags = true;
                                this.objectTypeFlags = Convert.ToUInt32(arrScript[_objectTypeFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("wallPlacementFlags:".ToUpper()))
                        {
                            int _wallPlacementFlags = arrScript.FindIndex(s => s.StartsWith("wallPlacementFlags:".ToUpper()));
                            if (_wallPlacementFlags != -1)
                            {
                                this.change_wallPlacementFlags = true;
                                this.wallPlacementFlags = Convert.ToUInt32(arrScript[_wallPlacementFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("movementFlags:".ToUpper()))
                        {
                            int _movementFlags = arrScript.FindIndex(s => s.StartsWith("movementFlags:".ToUpper()));
                            if (_movementFlags != -1)
                            {
                                this.change_movementFlags = true;
                                this.movementFlags = Convert.ToUInt32(arrScript[_movementFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("cutoutTilesPerLevel:".ToUpper()))
                        {
                            int _cutoutTilesPerLevel = arrScript.FindIndex(s => s.StartsWith("cutoutTilesPerLevel:".ToUpper()));
                            if (_cutoutTilesPerLevel != -1)
                            {
                                this.change_cutoutTilesPerLevel = true;
                                this.cutoutTilesPerLevel = Convert.ToUInt32(arrScript[_cutoutTilesPerLevel].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("levels:".ToUpper()))
                        {
                            int _levels = arrScript.FindIndex(s => s.StartsWith("levels:".ToUpper()));
                            if (_levels != -1)
                            {
                                this.change_levels = true;
                                this.levels = Convert.ToUInt32(arrScript[_levels].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("ambienceTypeHash:".ToUpper()))
                        {
                            int _ambienceTypeHash = arrScript.FindIndex(s => s.StartsWith("ambienceTypeHash:".ToUpper()));
                            if (_ambienceTypeHash != -1)
                            {
                                this.change_ambienceTypeHash = true;
                                this.ambienceTypeHash = Convert.ToUInt32(arrScript[_ambienceTypeHash].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("roomCategoryFlags:".ToUpper()))
                        {
                            int _roomCategoryFlags = arrScript.FindIndex(s => s.StartsWith("roomCategoryFlags:".ToUpper()));
                            if (_roomCategoryFlags != -1)
                            {
                                this.change_roomCategoryFlags = true;
                                this.roomCategoryFlags = Convert.ToUInt32(arrScript[_roomCategoryFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("functionCategoryFlags:".ToUpper()))
                        {
                            int _functionCategoryFlags = arrScript.FindIndex(s => s.StartsWith("functionCategoryFlags:".ToUpper()));
                            if (_functionCategoryFlags != -1)
                            {
                                this.change_functionCategoryFlags = true;
                                this.functionCategoryFlags = Convert.ToUInt32(arrScript[_functionCategoryFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("functionSubCategoryFlags:".ToUpper()))
                        {
                            int _functionSubCategoryFlags = arrScript.FindIndex(s => s.StartsWith("functionSubCategoryFlags:".ToUpper()));
                            if (_functionSubCategoryFlags != -1)
                            {
                                this.change_functionSubCategoryFlags = true;
                                this.functionSubCategoryFlags = Convert.ToUInt64(arrScript[_functionSubCategoryFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("roomSubCategoryFlags:".ToUpper()))
                        {
                            int _roomSubCategoryFlags = arrScript.FindIndex(s => s.StartsWith("roomSubCategoryFlags:".ToUpper()));
                            if (_roomSubCategoryFlags != -1)
                            {
                                this.change_roomSubCategoryFlags = true;
                                this.roomSubCategoryFlags = Convert.ToUInt64(arrScript[_roomSubCategoryFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("buildCategoryFlags:".ToUpper()))
                        {
                            int _buildCategoryFlags = arrScript.FindIndex(s => s.StartsWith("buildCategoryFlags:".ToUpper()));
                            if (_buildCategoryFlags != -1)
                            {
                                this.change_buildCategoryFlags = true;
                                this.buildCategoryFlags = Convert.ToUInt32(arrScript[_buildCategoryFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("slotPlacementFlags:".ToUpper()))
                        {
                            int _slotPlacementFlags = arrScript.FindIndex(s => s.StartsWith("slotPlacementFlags:".ToUpper()));
                            if (_slotPlacementFlags != -1)
                            {
                                this.change_slotPlacementFlags = true;
                                this.slotPlacementFlags = Convert.ToUInt32(arrScript[_slotPlacementFlags].Split(':')[1], 16);
                            }
                        }
                        
                        if (this.ScriptReference.ToUpper().Contains("moodletGiven:".ToUpper()))
                        {
                            int _moodletGiven = arrScript.FindIndex(s => s.StartsWith("moodletGiven:".ToUpper()));
                            if (_moodletGiven != -1)
                            {
                                this.change_moodletGiven = true;
                                this.moodletGiven = Convert.ToUInt32(arrScript[_moodletGiven].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("moodletScore:".ToUpper()))
                        {
                            int _moodletScore = arrScript.FindIndex(s => s.StartsWith("moodletScore:".ToUpper()));
                            if (_moodletScore != -1)
                            {
                                this.change_moodletScore = true;
                                this.moodletScore = Convert.ToInt32(arrScript[_moodletScore].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("price:".ToUpper()))
                        {
                            int _price = arrScript.FindIndex(s => s.StartsWith("price:".ToUpper()));
                            if (_price != -1)
                            {
                                this.change_price = true;
                                this.price = float.Parse(arrScript[_price].Split(':')[1]);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("FireType:".ToUpper()))
                        {
                            int _FireType = arrScript.FindIndex(s => s.StartsWith("FireType:".ToUpper()));
                            if (_FireType != -1)
                            {
                                this.change_FireType = true;
                                this.FireType = Convert.ToUInt32(arrScript[_FireType].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("BuildBuyProductStatusFlags:".ToUpper()))
                        {
                            int _BuildBuyProductStatusFlags = arrScript.FindIndex(s => s.StartsWith("BuildBuyProductStatusFlags:".ToUpper()));
                            if (_BuildBuyProductStatusFlags != -1)
                            {
                                this.change_BuildBuyProductStatusFlags = true;
                                this.BuildBuyProductStatusFlags = Convert.ToUInt32(arrScript[_BuildBuyProductStatusFlags].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("isScriptEnabled:".ToUpper()))
                        {
                            int _isScriptEnabled = arrScript.FindIndex(s => s.StartsWith("isScriptEnabled:".ToUpper()));
                            if (_isScriptEnabled != -1)
                            {
                                this.change_isScriptEnabled = true;
                                this.isScriptEnabled = arrScript[_isScriptEnabled].Split(':')[1].Contains("1");
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("isVisibleInWorldBuilder:".ToUpper()))
                        {
                            int _isVisibleInWorldBuilder = arrScript.FindIndex(s => s.StartsWith("isVisibleInWorldBuilder:".ToUpper()));
                            if (_isVisibleInWorldBuilder != -1)
                            {
                                this.change_isVisibleInWorldBuilder = true;
                                this.isVisibleInWorldBuilder = arrScript[_isVisibleInWorldBuilder].Split(':')[1].Contains("1");
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("AddStencils:".ToUpper()))
                        {
                            int _OBJDStencils = arrScript.FindIndex(s => s.StartsWith("AddStencils:".ToUpper()));
                            if (_OBJDStencils != -1)
                                this.OBJDStencils = new List<Stencils.OBJD>(Stencils.OBJD.Create(arrScript[_OBJDStencils].Split('|')));
                        }

                        if (this.ScriptReference.ToUpper().Contains("UISortPriority".ToUpper()))
                        {
                            int _UISortPriority = arrScript.FindIndex(s => s.StartsWith("UISortPriority:".ToUpper()));
                            if (_UISortPriority != -1)
                            {
                                this.change_UISortPriority = true;
                                this.UISortPriority = Convert.ToUInt32(arrScript[_UISortPriority].Split(':')[1], 16);
                            }
                        }
                    }
                    catch
                    {
                        this.Borked = true;
                        return;
                    }
                    break;
                #endregion

                #region Handle CASP Attributes
                case 0x034AEECB:
                    try
                    {
                        if (this.ScriptReference.ToUpper().Contains("Clothing:".ToUpper()))
                        {
                            int _Clothing = arrScript.FindIndex(s => s.StartsWith("Clothing:".ToUpper()));
                            if (_Clothing != -1)
                            {
                                this.change_Clothing = true;
                                this.Clothing = Convert.ToUInt32(arrScript[_Clothing].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("AgeGender:".ToUpper()))
                        {
                            int _AgeGender = arrScript.FindIndex(s => s.StartsWith("AgeGender:".ToUpper()));
                            if (_AgeGender != -1)
                            {
                                this.change_AgeGender = true;
                                this.AgeGender = Convert.ToUInt32(arrScript[_AgeGender].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("ClothingCategory:".ToUpper()))
                        {
                            int _ClothingCategory = arrScript.FindIndex(s => s.StartsWith("ClothingCategory:".ToUpper()));
                            if (_ClothingCategory != -1)
                            {
                                this.change_ClothingCategory = true;
                                this.ClothingCategory = Convert.ToUInt32(arrScript[_ClothingCategory].Split(':')[1], 16);
                            }
                        }

                        if (this.ScriptReference.ToUpper().Contains("SortingPriority:".ToUpper()))
                        {
                            int _SortingPriority = arrScript.FindIndex(s => s.StartsWith("SortingPriority:".ToUpper()));
                            if (_SortingPriority != -1)
                            {
                                this.change_SortingPriority = true;
                                this.SortingPriority = float.Parse(arrScript[_SortingPriority].Split(':')[1]);
                            }
                        }
                    }
                    catch
                    {
                        this.Borked = true;
                        return;
                    }
                    break;
                #endregion

                #region Handle OBJK Attributes
                case (uint)Versionizer.Enums.ResourceType.OBJK:
                    try
                    {
                        if (this.ScriptReference.ToUpper().Contains("ScriptClass:".ToUpper()))
                        {
                            int _ScriptClass = arrScript.FindIndex(s => s.StartsWith("ScriptClass:".ToUpper()));
                            if (_ScriptClass != -1)
                            {
                                this.change_ScriptClass = true;
                                this.ScriptClass = this.ScriptReference.Split(' ')[_ScriptClass].Split(':')[1];
                            }
                        }
                    }
                    catch
                    {
                        this.Borked = true;
                        return;
                    }
                    break;
                #endregion

                default:
                    this.Borked = true;
                    return;
            }
        }
        #endregion
    }
}