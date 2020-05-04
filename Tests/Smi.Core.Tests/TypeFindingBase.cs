using System;
using Smi.Core.Infrastructure;
using Smi.Tests;
using NUnit.Framework;

namespace Smi.Core.Tests
{
    public abstract class TypeFindingBase : TestsBase
    {
        protected ITypeFinder typeFinder;

        protected abstract Type[] GetTypes();

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            typeFinder = new Fakes.FakeTypeFinder(typeof(TypeFindingBase).Assembly, GetTypes());
        }
    }
}
