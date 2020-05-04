namespace Smi.Data
{
    /// <summary>
    /// Represents a data provider manager
    /// </summary>
    public partial interface IDataProviderManager
    {
        #region Properties

        /// <summary>
        /// Gets data provider
        /// </summary>
        ISmiDataProvider DataProvider { get; }

        #endregion
    }
}
