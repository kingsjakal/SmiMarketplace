using Moq;
using Smi.Core;
using Smi.Data;

namespace Smi.Tests
{
    public static class FakePrepareExtensions
    {
        public static IRepository<T> FakeRepoNullPropagation<T>(this IRepository<T> repository) where T : BaseEntity
        {
            return repository ?? new Mock<IRepository<T>>().Object;
        }
    }
}
