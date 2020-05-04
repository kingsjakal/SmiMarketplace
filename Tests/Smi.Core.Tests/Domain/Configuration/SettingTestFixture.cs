using FluentAssertions;
using Smi.Core.Domain.Configuration;
using NUnit.Framework;

namespace Smi.Core.Tests.Domain.Configuration
{
    [TestFixture]
    public class SettingTestFixture
    {
        [Test]
        public void Can_create_setting()
        {
            var setting = new Setting("Setting1", "Value1");
            setting.Name.Should().Be("Setting1");
            setting.Value.Should().Be("Value1");
        }
    }
}
