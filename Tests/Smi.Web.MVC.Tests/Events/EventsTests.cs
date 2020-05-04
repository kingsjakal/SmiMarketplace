using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Moq;
using Smi.Core;
using Smi.Core.Events;
using Smi.Core.Infrastructure;
using Smi.Services.Events;
using Smi.Tests;
using NUnit.Framework;

namespace Smi.Web.MVC.Tests.Events
{
    [TestFixture]
    public class EventsTests
    {
        private IEventPublisher _eventPublisher;

        [OneTimeSetUp]
        public void SetUp()
        {
            var webHostEnvironment = new Mock<IWebHostEnvironment>();
            webHostEnvironment.Setup(x => x.ContentRootPath).Returns(System.Reflection.Assembly.GetExecutingAssembly().Location);
            webHostEnvironment.Setup(x => x.WebRootPath).Returns(System.IO.Directory.GetCurrentDirectory());
            CommonHelper.DefaultFileProvider = new SmiFileProvider(webHostEnvironment.Object);

            var SmiEngine = new Mock<SmiEngine>();
            var serviceProvider = new TestServiceProvider();
            SmiEngine.Setup(x => x.ServiceProvider).Returns(serviceProvider);
            SmiEngine.Setup(x => x.ResolveAll<IConsumer<DateTime>>()).Returns(new List<IConsumer<DateTime>> { new DateTimeConsumer() });
            EngineContext.Replace(SmiEngine.Object);
            _eventPublisher = new EventPublisher();
        }

        [Test]
        public void Can_publish_event()
        {
            var oldDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            DateTimeConsumer.DateTime = oldDateTime;

            var newDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(5));
            _eventPublisher.Publish(newDateTime);
            newDateTime.Should().Be(DateTimeConsumer.DateTime);
        }
    }
}