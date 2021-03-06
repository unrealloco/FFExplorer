﻿using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace FFExplorer
{
    [DataContract]
    class AppOptions
    {
        [DataMember]
        public int width;
        [DataMember]
        public int height;
        [DataMember]
        public string lastFolder;
        [DataMember]
        public bool rememberLastFolder;
        [DataMember]
        public bool saveTemporary;
        [DataMember]
        public bool showLog;
        [DataMember]
        public int logFilesDaysLimit;
        [DataMember]
        public string[] locStringsPrefixes;

        public AppOptions()
        {
            Reset();
        }

        public void Reset()
        {
            width = 1000;
            height = 600;
            lastFolder = "";
            rememberLastFolder = true;
            saveTemporary = false;
            showLog = true;
            logFilesDaysLimit = 7;
            locStringsPrefixes = new string[0];
        }
    }

    /// <summary>
    /// A handler to simplify work with JSON de-\serialization and accessing saved preferences.
    /// </summary>
    public class OptionsHandler
    {
        static string PreferencesDirName = "prefs";
        static string PreferencesDir = Application.StartupPath + "\\" + PreferencesDirName;
        static string ConfigFileName = "config.json";
        static string ConfigFilePath = PreferencesDir + "\\" + ConfigFileName;

        /// <summary>
        /// Constructor.
        /// </summary>
        public OptionsHandler()
        {
            opt = new AppOptions();
            json = new DataContractJsonSerializer(typeof(AppOptions));
            LoadOptions();
        }

        /// <summary>
        /// Destructor.
        /// </summary>
        ~OptionsHandler()
        {
            SaveOptions();
        }

        /// <summary>
        /// Resets all preferences to its default states.
        /// </summary>
        public void Reset()
        {
            opt.Reset();
        }

        /// <summary>
        /// Gets or sets width of application window.
        /// </summary>
        public int Width
        {
            get
            {
                return opt.width;
            }
            set
            {
                opt.width = value;
            }
        }

        /// <summary>
        /// Gets or sets height of application window.
        /// </summary>
        public int Height
        {
            get
            {
                return opt.height;
            }
            set
            {
                opt.height = value;
            }
        }

        /// <summary>
        /// Gets or sets last folder used by various dialogs.
        /// </summary>
        public string LastFolder
        {
            get
            {
                return opt.lastFolder;
            }
            set
            {
                opt.lastFolder = value;
            }
        }

        /// <summary>
        /// Gets or sets whether to remember last used folder.
        /// </summary>
        public bool RememberLastFolder
        {
            get
            {
                return opt.rememberLastFolder;
            }
            set
            {
                opt.rememberLastFolder = value;
            }
        }

        /// <summary>
        /// Gets or sets whether to delete temporary files such as decompressed zone.
        /// </summary>
        public bool SaveTemporaryFiles
        {
            get
            {
                return opt.saveTemporary;
            }
            set
            {
                opt.saveTemporary = value;
            }
        }

        /// <summary>
        /// Gets or sets whether to show log panel.
        /// </summary>
        public bool ShowLog
        {
            get
            {
                return opt.showLog;
            }
            set
            {
                opt.showLog = value;
            }
        }

        /// <summary>
        /// Gets or sets how long keep logfiles.
        /// </summary>
        public int LogFilesDaysLimit
        {
            get
            {
                return opt.logFilesDaysLimit;
            }
            set
            {
                opt.logFilesDaysLimit = value;
            }
        }

        /// <summary>
        /// Gets or sets array of localizedstring prefixes to search inside fastfiles.
        /// </summary>
        public string[] LocalizedStringPrefixes
        {
            get
            {
                return opt.locStringsPrefixes;
            }
            set
            {
                opt.locStringsPrefixes = value;
            }
        }

        private void LoadOptions()
        {
            if (!Directory.Exists(PreferencesDir))
            {
                Directory.CreateDirectory(PreferencesDir);
                return;
            }
            
            if (!File.Exists(ConfigFilePath))
                return;

            using (FileStream config = new FileStream(ConfigFilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                opt = json.ReadObject(config) as AppOptions;            
        }

        private void SaveOptions()
        {
            using (FileStream config = new FileStream(ConfigFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                json.WriteObject(config, opt);
        }

        AppOptions opt;
        DataContractJsonSerializer json;
    }
}
