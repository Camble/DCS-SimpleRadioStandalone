﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Installer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Installer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create Start menu shortcut.
        /// </summary>
        internal static string CreateStartMenuShortcut {
            get {
                return ResourceManager.GetString("CreateStartMenuShortcut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locate.
        /// </summary>
        internal static string dcsPathButton {
            get {
                return ResourceManager.GetString("dcsPathButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install / Update DCS-SRS.
        /// </summary>
        internal static string InstallButton {
            get {
                return ResourceManager.GetString("InstallButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing....
        /// </summary>
        internal static string InstallingButton {
            get {
                return ResourceManager.GetString("InstallingButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install DCS Client Scripts - Only required for SRS Client NOT Server Only Installs.
        /// </summary>
        internal static string InstallScriptsCheckbox {
            get {
                return ResourceManager.GetString("InstallScriptsCheckbox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SimpleRadio Standalone Installer -.
        /// </summary>
        internal static string intro {
            get {
                return ResourceManager.GetString("intro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change Installer Settings?.
        /// </summary>
        internal static string MsgBoxChange {
            get {
                return ResourceManager.GetString("MsgBoxChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to make changes? 
        ///
        ///Yes - Pause install and make changes
        ///
        ///No - Run with previous install path and install scripts as default. 
        ///
        ///If unsure - hit Yes!.
        /// </summary>
        internal static string MsgBoxChangeText {
            get {
                return ResourceManager.GetString("MsgBoxChangeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Close DCS.
        /// </summary>
        internal static string MsgBoxDCS {
            get {
                return ResourceManager.GetString("MsgBoxDCS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DCS must now be closed before continuing the install or uninstall!
        ///
        ///Close DCS and please try again..
        /// </summary>
        internal static string MsgBoxDCSText {
            get {
                return ResourceManager.GetString("MsgBoxDCSText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Extract Installation zip.
        /// </summary>
        internal static string MsgBoxExtracted {
            get {
                return ResourceManager.GetString("MsgBoxExtracted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Unzipped.
        /// </summary>
        internal static string MsgBoxExtracted2 {
            get {
                return ResourceManager.GetString("MsgBoxExtracted2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please extract the entire installation zip into a folder and then run the installer from the extracted folder.
        ///
        ///Do not run the installer from the zip as it wont work!.
        /// </summary>
        internal static string MsgBoxExtractedText {
            get {
                return ResourceManager.GetString("MsgBoxExtractedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install files not found - Unable to install! 
        ///
        ///Make sure you extract all the files in the zip then run the Installer.
        /// </summary>
        internal static string MsgBoxExtractedText2 {
            get {
                return ResourceManager.GetString("MsgBoxExtractedText2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SR Standalone Installer.
        /// </summary>
        internal static string MsgBoxFolder {
            get {
                return ResourceManager.GetString("MsgBoxFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find DCS Folder in Saved Games!
        ///
        ///Please check the path to the &quot;Saved Games&quot; folder
        ///
        ///Make sure you are selecting the &quot;Saved Games&quot; folder - NOT the DCS folder inside &quot;Saved Games&quot; and NOT the DCS installation directory.
        /// </summary>
        internal static string MsgBoxFolderText {
            get {
                return ResourceManager.GetString("MsgBoxFolderText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation Error.
        /// </summary>
        internal static string MsgBoxInstallError {
            get {
                return ResourceManager.GetString("MsgBoxInstallError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error with installation - please post your installer-log.txt on the SRS Discord for Support.
        /// </summary>
        internal static string MsgBoxInstallErrorText {
            get {
                return ResourceManager.GetString("MsgBoxInstallErrorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation / Update Completed Successfully!
        ///Installed DCS Scripts to:
        ///.
        /// </summary>
        internal static string MsgBoxInstallSuccessText {
            get {
                return ResourceManager.GetString("MsgBoxInstallSuccessText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation / Update Completed Successfully!.
        /// </summary>
        internal static string MsgBoxInstallSuccessText2 {
            get {
                return ResourceManager.GetString("MsgBoxInstallSuccessText2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SR Standalone Installer.
        /// </summary>
        internal static string MsgBoxInstallTitle {
            get {
                return ResourceManager.GetString("MsgBoxInstallTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SR Standalone Removed Successfully!
        ///
        ///Containing folder left just in case you want favourites or frequencies.
        /// </summary>
        internal static string MsgBoxRemovedText {
            get {
                return ResourceManager.GetString("MsgBoxRemovedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed SRS Successfully!.
        /// </summary>
        internal static string MsgBoxRemovedText2 {
            get {
                return ResourceManager.GetString("MsgBoxRemovedText2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error with Uninstaller.
        /// </summary>
        internal static string MsgBoxUninstallError {
            get {
                return ResourceManager.GetString("MsgBoxUninstallError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error with uninstaller - please post your installer-log.txt on the SRS Discord for Support.
        /// </summary>
        internal static string MsgBoxUninstallErrorText {
            get {
                return ResourceManager.GetString("MsgBoxUninstallErrorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalling SRS.
        /// </summary>
        internal static string MsgBoxUninstalling {
            get {
                return ResourceManager.GetString("MsgBoxUninstalling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove DCS-SRS.
        /// </summary>
        internal static string RemoveButton {
            get {
                return ResourceManager.GetString("RemoveButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Note: Server installs will need to manually install the DCS-SRS-AutoConnectGameGUI.lua - found in the SRS Install Location in the Scripts folder. Installation instructions are in the file..
        /// </summary>
        internal static string ServerNote {
            get {
                return ResourceManager.GetString("ServerNote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locate.
        /// </summary>
        internal static string srPathButton {
            get {
                return ResourceManager.GetString("srPathButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Step 1: Pick Install Location.
        /// </summary>
        internal static string step2 {
            get {
                return ResourceManager.GetString("step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Step 2: Locate Saved Games Folder - Not DCS.
        /// </summary>
        internal static string step3 {
            get {
                return ResourceManager.GetString("step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Step 3: Install Or Remove DCS-SRS.
        /// </summary>
        internal static string step4 {
            get {
                return ResourceManager.GetString("step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DCS-SRS Installer.
        /// </summary>
        internal static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}
