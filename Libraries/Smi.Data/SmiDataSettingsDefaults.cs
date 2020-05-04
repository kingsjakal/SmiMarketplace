namespace Smi.Data
{
    /// <summary>
    /// Represents default values related to data settings
    /// </summary>
    public static partial class SmiDataSettingsDefaults
    {
        /// <summary>
        /// Gets a path to the file that was used in old SmiMarketplace versions to contain data settings
        /// </summary>
        public static string ObsoleteFilePath => "~/App_Data/Settings.txt";

        /// <summary>
        /// Gets a path to the file that contains data settings
        /// </summary>
        public static string FilePath => "~/App_Data/dataSettings.json";
    }
}