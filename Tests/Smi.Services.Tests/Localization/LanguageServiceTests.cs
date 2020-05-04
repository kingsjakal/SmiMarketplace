using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Moq;
using Smi.Data;
using Smi.Core.Domain.Localization;
using Smi.Services.Configuration;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Services.Stores;
using Smi.Tests;
using NUnit.Framework;

namespace Smi.Services.Tests.Localization
{
    [TestFixture]
    public class LanguageServiceTests : ServiceTest
    {
        private Mock<IRepository<Language>> _languageRepo;
        private Mock<IStoreMappingService> _storeMappingService;
        private ILanguageService _languageService;
        private Mock<ISettingService> _settingService;
        private Mock<IEventPublisher> _eventPublisher;
        private LocalizationSettings _localizationSettings;

        [SetUp]
        public new void SetUp()
        {
            _languageRepo = new Mock<IRepository<Language>>();
            var lang1 = new Language
            {
                Name = "English",
                LanguageCulture = "en-Us",
                FlagImageFileName = "us.png",
                Published = true,
                DisplayOrder = 1
            };
            var lang2 = new Language
            {
                Name = "Russian",
                LanguageCulture = "ru-Ru",
                FlagImageFileName = "ru.png",
                Published = true,
                DisplayOrder = 2
            };

            _languageRepo.Setup(x => x.Table).Returns(new List<Language> { lang1, lang2 }.AsQueryable());

            _storeMappingService = new Mock<IStoreMappingService>();

            _settingService = new Mock<ISettingService>();

            _eventPublisher = new Mock<IEventPublisher>();
            _eventPublisher.Setup(x => x.Publish(It.IsAny<object>()));

            _localizationSettings = new LocalizationSettings();
            _languageService = new LanguageService(new FakeCacheKeyService(), _eventPublisher.Object, _languageRepo.Object,_settingService.Object, new TestCacheManager(),  _storeMappingService.Object, _localizationSettings);
        }

        [Test]
        public void Can_get_all_languages()
        {
            RunWithTestServiceProvider(() =>
            {
                var languages = _languageService.GetAllLanguages();
                languages.Should().NotBeNull();
                languages.Any().Should().BeTrue();
            });
        }
    }
}
