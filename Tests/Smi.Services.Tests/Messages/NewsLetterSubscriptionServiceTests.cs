using Moq;
using Smi.Data;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Messages;
using Smi.Core.Events;
using Smi.Services.Customers;
using Smi.Services.Events;
using Smi.Services.Messages;
using NUnit.Framework;

namespace Smi.Services.Tests.Messages 
{
    [TestFixture]
    public class NewsLetterSubscriptionServiceTests : ServiceTest
    {
        private Mock<IEventPublisher> _eventPublisher;
        private Mock<ISmiDataProvider> _dataProvider;
        private Mock<IRepository<NewsLetterSubscription>> _newsLetterSubscriptionRepository;
        private Mock<IRepository<Customer>> _customerRepository;
        private Mock<IRepository<CustomerCustomerRoleMapping>> _customerCustomerRoleMappingRepository;
        private Mock<ICustomerService> _customerService;

        [SetUp]
        public new void SetUp()
        {
            _dataProvider=new Mock<ISmiDataProvider>();
            _eventPublisher = new Mock<IEventPublisher>();
            _newsLetterSubscriptionRepository = new Mock<IRepository<NewsLetterSubscription>>();
            _customerRepository = new Mock<IRepository<Customer>>();
            _customerCustomerRoleMappingRepository = new Mock<IRepository<CustomerCustomerRoleMapping>>();
            _customerService = new Mock<ICustomerService>();
        }

        /// <summary>
        /// Verifies the active insert triggers subscribe event.
        /// </summary>
        [Test]
        public void VerifyActiveInsertTriggersSubscribeEvent()
        {
            var service = new NewsLetterSubscriptionService(_customerService.Object, _eventPublisher.Object,
                _customerRepository.Object, _customerCustomerRoleMappingRepository.Object, _newsLetterSubscriptionRepository.Object);

            var subscription = new NewsLetterSubscription { Active = true, Email = "test@test.com" };
            service.InsertNewsLetterSubscription(subscription);

            _eventPublisher.Verify(x => x.Publish(new EmailSubscribedEvent(subscription)));
        }

        /// <summary>
        /// Verifies the delete triggers unsubscribe event.
        /// </summary>
        [Test]
        public void VerifyDeleteTriggersUnsubscribeEvent()
        {
            var service = new NewsLetterSubscriptionService(_customerService.Object, _eventPublisher.Object,
                _customerRepository.Object, _customerCustomerRoleMappingRepository.Object, _newsLetterSubscriptionRepository.Object);

            var subscription = new NewsLetterSubscription { Active = true, Email = "test@test.com" };
            service.DeleteNewsLetterSubscription(subscription);

            _eventPublisher.Verify(x => x.Publish(new EmailUnsubscribedEvent(subscription)));
        }
        
        /// <summary>
        /// Verifies the insert event is fired.
        /// </summary>
        [Test]
        public void VerifyInsertEventIsFired()
        {
            var service = new NewsLetterSubscriptionService(_customerService.Object, _eventPublisher.Object,
                _customerRepository.Object, _customerCustomerRoleMappingRepository.Object, _newsLetterSubscriptionRepository.Object);

            var subscription = new NewsLetterSubscription {Email = "test@test.com"};

            service.InsertNewsLetterSubscription(subscription);

            _eventPublisher.Verify(x => x.Publish(It.IsAny<EntityInsertedEvent<NewsLetterSubscription>>()));
        }
    }
}