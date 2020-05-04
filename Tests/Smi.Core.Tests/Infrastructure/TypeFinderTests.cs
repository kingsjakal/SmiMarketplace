using System.Linq;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Moq;
using Smi.Core.Infrastructure;
using NUnit.Framework;

namespace Smi.Core.Tests.Infrastructure
{
    [TestFixture]
    public class TypeFinderTests
    {
        [Test]
        public void TypeFinder_Benchmark_Findings()
        {
            var webHostEnvironment = new Mock<IWebHostEnvironment>();
            webHostEnvironment.Setup(x => x.ContentRootPath).Returns(System.Reflection.Assembly.GetExecutingAssembly().Location);
            webHostEnvironment.Setup(x => x.WebRootPath).Returns(System.IO.Directory.GetCurrentDirectory());
            CommonHelper.DefaultFileProvider = new SmiFileProvider(webHostEnvironment.Object);
            var finder = new AppDomainTypeFinder();
            var type = finder.FindClassesOfType<ISomeInterface>().ToList();
            type.Count.Should().Be(1);
            typeof(ISomeInterface).IsAssignableFrom(type.FirstOrDefault()).Should().BeTrue();
        }

        public interface ISomeInterface
        {
        }

        public class SomeClass : ISomeInterface
        {
        }
    }
}
