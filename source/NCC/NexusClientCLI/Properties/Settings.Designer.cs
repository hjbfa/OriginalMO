﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nexus.Client.CLI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SettingsUpgraded {
            get {
                return ((bool)(this["SettingsUpgraded"]));
            }
            set {
                this["SettingsUpgraded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Nexus.Client.Settings.SettingsList InstalledGames {
            get {
                return ((global::Nexus.Client.Settings.SettingsList)(this["InstalledGames"]));
            }
            set {
                this["InstalledGames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool InstalledGamesDetected {
            get {
                return ((bool)(this["InstalledGamesDetected"]));
            }
            set {
                this["InstalledGamesDetected"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RememberedGameMode {
            get {
                return ((string)(this["RememberedGameMode"]));
            }
            set {
                this["RememberedGameMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ultra")]
        public global::SevenZip.CompressionLevel ModCompressionLevel {
            get {
                return ((global::SevenZip.CompressionLevel)(this["ModCompressionLevel"]));
            }
            set {
                this["ModCompressionLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SevenZip")]
        public global::SevenZip.OutArchiveFormat ModCompressionFormat {
            get {
                return ((global::SevenZip.OutArchiveFormat)(this["ModCompressionFormat"]));
            }
            set {
                this["ModCompressionFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SelectedAddModCommandIndex {
            get {
                return ((int)(this["SelectedAddModCommandIndex"]));
            }
            set {
                this["SelectedAddModCommandIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckForNewModVersions {
            get {
                return ((bool)(this["CheckForNewModVersions"]));
            }
            set {
                this["CheckForNewModVersions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddMissingInfoToMods {
            get {
                return ((bool)(this["AddMissingInfoToMods"]));
            }
            set {
                this["AddMissingInfoToMods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CloseModManagerAfterGameLaunch {
            get {
                return ((bool)(this["CloseModManagerAfterGameLaunch"]));
            }
            set {
                this["CloseModManagerAfterGameLaunch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CloseModManagerAfterGameLaunchIsRemembered {
            get {
                return ((bool)(this["CloseModManagerAfterGameLaunchIsRemembered"]));
            }
            set {
                this["CloseModManagerAfterGameLaunchIsRemembered"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RememberGameMode {
            get {
                return ((bool)(this["RememberGameMode"]));
            }
            set {
                this["RememberGameMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ScanSubfoldersForMods {
            get {
                return ((bool)(this["ScanSubfoldersForMods"]));
            }
            set {
                this["ScanSubfoldersForMods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n\t\t\t\t<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n\t\t\t\t<KeyedSettingsOfKeyedSettingsO" +
            "fString />\r\n\t\t\t")]
        public global::Nexus.Client.Settings.KeyedSettings<Nexus.Client.Settings.KeyedSettings<string>> RepositoryAuthenticationTokens {
            get {
                return ((global::Nexus.Client.Settings.KeyedSettings<Nexus.Client.Settings.KeyedSettings<string>>)(this["RepositoryAuthenticationTokens"]));
            }
            set {
                this["RepositoryAuthenticationTokens"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n\t\t\t\t<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n\t\t\t\t<PerGameModeSettingsOfKeyedSet" +
            "tingsOfAddModDescriptor />\r\n\t\t\t")]
        public global::Nexus.Client.Settings.PerGameModeSettings<Nexus.Client.Settings.KeyedSettings<Nexus.Client.ModManagement.AddModDescriptor>> QueuedModsToAdd {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<Nexus.Client.Settings.KeyedSettings<Nexus.Client.ModManagement.AddModDescriptor>>)(this["QueuedModsToAdd"]));
            }
            set {
                this["QueuedModsToAdd"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://skyrim.nexusmods.com/downloads/file.php?id=1334")]
        public string ModManagerUrl {
            get {
                return ((string)(this["ModManagerUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForUpdatesOnStartup {
            get {
                return ((bool)(this["CheckForUpdatesOnStartup"]));
            }
            set {
                this["CheckForUpdatesOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int NumberOfConnections {
            get {
                return ((int)(this["NumberOfConnections"]));
            }
            set {
                this["NumberOfConnections"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserLocation {
            get {
                return ((string)(this["UserLocation"]));
            }
            set {
                this["UserLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PremiumOnly {
            get {
                return ((bool)(this["PremiumOnly"]));
            }
            set {
                this["PremiumOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int UpdateCheckInterval {
            get {
                return ((int)(this["UpdateCheckInterval"]));
            }
            set {
                this["UpdateCheckInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string LastUpdateCheckDate {
            get {
                return ((string)(this["LastUpdateCheckDate"]));
            }
            set {
                this["LastUpdateCheckDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ModVersionsCheckInterval {
            get {
                return ((int)(this["ModVersionsCheckInterval"]));
            }
            set {
                this["ModVersionsCheckInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string LastModVersionsCheckDate {
            get {
                return ((string)(this["LastModVersionsCheckDate"]));
            }
            set {
                this["LastModVersionsCheckDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TempPathFolder {
            get {
                return ((string)(this["TempPathFolder"]));
            }
            set {
                this["TempPathFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TraceLogFolder {
            get {
                return ((string)(this["TraceLogFolder"]));
            }
            set {
                this["TraceLogFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowExpandedCategories {
            get {
                return ((bool)(this["ShowExpandedCategories"]));
            }
            set {
                this["ShowExpandedCategories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowEmptyCategory {
            get {
                return ((bool)(this["ShowEmptyCategory"]));
            }
            set {
                this["ShowEmptyCategory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideModUpdateWarningIcon {
            get {
                return ((bool)(this["HideModUpdateWarningIcon"]));
            }
            set {
                this["HideModUpdateWarningIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SkipReadmeFiles {
            get {
                return ((bool)(this["SkipReadmeFiles"]));
            }
            set {
                this["SkipReadmeFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowSidePanel {
            get {
                return ((bool)(this["ShowSidePanel"]));
            }
            set {
                this["ShowSidePanel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CategoryViewDefaultSortOrder {
            get {
                return ((int)(this["CategoryViewDefaultSortOrder"]));
            }
            set {
                this["CategoryViewDefaultSortOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CategoryViewDefaultSortColumn {
            get {
                return ((int)(this["CategoryViewDefaultSortColumn"]));
            }
            set {
                this["CategoryViewDefaultSortColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseCategoryView {
            get {
                return ((bool)(this["UseCategoryView"]));
            }
            set {
                this["UseCategoryView"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OfflineMode {
            get {
                return ((bool)(this["OfflineMode"]));
            }
            set {
                this["OfflineMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SupportOfflineMode {
            get {
                return ((bool)(this["SupportOfflineMode"]));
            }
            set {
                this["SupportOfflineMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseMultithreadedDownloads {
            get {
                return ((bool)(this["UseMultithreadedDownloads"]));
            }
            set {
                this["UseMultithreadedDownloads"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<KeyedSettingsOfString />")]
        public global::Nexus.Client.Settings.KeyedSettings<string> HelpLinks {
            get {
                return ((global::Nexus.Client.Settings.KeyedSettings<string>)(this["HelpLinks"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> InstallationPaths {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["InstallationPaths"]));
            }
            set {
                this["InstallationPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> ExecutablePaths {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["ExecutablePaths"]));
            }
            set {
                this["ExecutablePaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfBoolean />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<bool> CompletedSetup {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<bool>)(this["CompletedSetup"]));
            }
            set {
                this["CompletedSetup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> ModFolder {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["ModFolder"]));
            }
            set {
                this["ModFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfPerGameModeSetting" +
            "sOfObject />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<Nexus.Client.Settings.PerGameModeSettings<object>> CustomGameModeSettings {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<Nexus.Client.Settings.PerGameModeSettings<object>>)(this["CustomGameModeSettings"]));
            }
            set {
                this["CustomGameModeSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> InstallInfoFolder {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["InstallInfoFolder"]));
            }
            set {
                this["InstallInfoFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<WindowPositions />")]
        public global::Nexus.Client.Settings.WindowPositions WindowPositions {
            get {
                return ((global::Nexus.Client.Settings.WindowPositions)(this["WindowPositions"]));
            }
            set {
                this["WindowPositions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<KeyedSettingsOfString />")]
        public global::Nexus.Client.Settings.KeyedSettings<string> DockPanelLayouts {
            get {
                return ((global::Nexus.Client.Settings.KeyedSettings<string>)(this["DockPanelLayouts"]));
            }
            set {
                this["DockPanelLayouts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ColumnWidths />")]
        public global::Nexus.Client.Settings.ColumnWidths ColumnWidths {
            get {
                return ((global::Nexus.Client.Settings.ColumnWidths)(this["ColumnWidths"]));
            }
            set {
                this["ColumnWidths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<SplitterSizes />")]
        public global::Nexus.Client.Settings.SplitterSizes SplitterSizes {
            get {
                return ((global::Nexus.Client.Settings.SplitterSizes)(this["SplitterSizes"]));
            }
            set {
                this["SplitterSizes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> CustomLaunchCommands {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["CustomLaunchCommands"]));
            }
            set {
                this["CustomLaunchCommands"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> CustomLaunchCommandArguments {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["CustomLaunchCommandArguments"]));
            }
            set {
                this["CustomLaunchCommandArguments"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> SelectedLaunchCommands {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["SelectedLaunchCommands"]));
            }
            set {
                this["SelectedLaunchCommands"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<KeyedSettingsOfString />")]
        public global::Nexus.Client.Settings.KeyedSettings<string> RepositoryUsernames {
            get {
                return ((global::Nexus.Client.Settings.KeyedSettings<string>)(this["RepositoryUsernames"]));
            }
            set {
                this["RepositoryUsernames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfKeyedSettingsOfStr" +
            "ing />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<Nexus.Client.Settings.KeyedSettings<string>> DelayedSettings {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<Nexus.Client.Settings.KeyedSettings<string>>)(this["DelayedSettings"]));
            }
            set {
                this["DelayedSettings"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PerGameModeSettingsOfString />")]
        public global::Nexus.Client.Settings.PerGameModeSettings<string> ToolFolder {
            get {
                return ((global::Nexus.Client.Settings.PerGameModeSettings<string>)(this["ToolFolder"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowStartupMessage {
            get {
                return ((bool)(this["ShowStartupMessage"]));
            }
            set {
                this["ShowStartupMessage"] = value;
            }
        }
    }
}
