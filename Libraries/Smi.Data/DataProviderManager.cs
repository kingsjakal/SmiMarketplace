using Smi.Core;
using Smi.Core.Infrastructure;

namespace Smi.Data
{
    /// <summary>
    /// Represents the data provider manager
    /// </summary>
    public partial class DataProviderManager : IDataProviderManager
    {
        #region Methods

        /// <summary>
        /// Gets data provider by specific type
        /// </summary>
        /// <param name="dataProviderType">Data provider type</param>
        /// <returns></returns>
        public static ISmiDataProvider GetDataProvider(DataProviderType dataProviderType)
        {
            switch (dataProviderType)
            {
                case DataProviderType.SqlServer:
                    return new MsSqlSmiDataProvider();
                case DataProviderType.MySql:
                    return new MySqlSmiDataProvider();
                default:
                    throw new SmiException($"Not supported data provider name: '{dataProviderType}'");
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets data provider
        /// </summary>
        public ISmiDataProvider DataProvider
        {
            get
            {
                var dataProviderType = Singleton<DataSettings>.Instance.DataProvider;

                return GetDataProvider(dataProviderType);
            }
        }

        #endregion
    }
}
