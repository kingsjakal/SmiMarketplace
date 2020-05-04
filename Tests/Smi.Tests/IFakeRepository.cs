using Smi.Core;
using Smi.Data;

namespace Smi.Tests
{
    public interface IFakeRepository<T>: IFakeStoreRepositoryContainer where T : BaseEntity
    {
        IRepository<T> GetRepository();
    }
}
