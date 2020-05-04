using FluentAssertions;
using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Seo;
using Smi.Data;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Services.Seo;
using Smi.Tests;
using NUnit.Framework;

namespace Smi.Services.Tests.Seo
{
    [TestFixture]
    public class SeoExtensionsTests
    {
        private Mock<IEventPublisher> _eventPublisher;
        private Mock<ILanguageService> _languageService;
        private Mock<IRepository<UrlRecord>> _urlRecordRepository;
        private Mock<IStaticCacheManager> _staticCacheManager;
        private Mock<IWorkContext> _workContext;
        private LocalizationSettings _localizationSettings;
        private SeoSettings _seoSettings;
        private IUrlRecordService _urlRecordService;

        [SetUp]
        public void SetUp()
        {
            _eventPublisher = new Mock<IEventPublisher>();
            _languageService = new Mock<ILanguageService>();
            _urlRecordRepository = new Mock<IRepository<UrlRecord>>();
            _staticCacheManager = new Mock<IStaticCacheManager>();
            _workContext = new Mock<IWorkContext>();
            _localizationSettings = new LocalizationSettings();
            _seoSettings = new SeoSettings();

            _urlRecordService = new UrlRecordService(new FakeCacheKeyService(), _eventPublisher.Object, _languageService.Object, _urlRecordRepository.Object,
                _staticCacheManager.Object, _workContext.Object, _localizationSettings, _seoSettings);
        }

        [Test]
        public void Should_return_lowercase()
        {
            _urlRecordService.GetSeName("tEsT", false, false).Should().Be("test");
        }

        [Test]
        public void Should_allow_all_latin_chars()
        {
            _urlRecordService.GetSeName("abcdefghijklmSmiqrstuvwxyz1234567890", false, false).Should()
                .Be("abcdefghijklmSmiqrstuvwxyz1234567890");
        }

        [Test]
        public void Should_remove_illegal_chars()
        {
            _urlRecordService.GetSeName("test!@#$%^&*()+<>?/", false, false).Should().Be("test");
        }

        [Test]
        public void Should_replace_space_with_dash()
        {
            _urlRecordService.GetSeName("test test", false, false).Should().Be("test-test");
            _urlRecordService.GetSeName("test     test", false, false).Should().Be("test-test");
        }

        [Test]
        public void Can_convert_non_western_chars()
        {
            //German letters with diacritics
            _urlRecordService.GetSeName("testäöü", true, false).Should().Be("testaou");
            _urlRecordService.GetSeName("testäöü", false, false).Should().Be("test");
        }

        [Test]
        public void Can_allow_unicode_chars()
        {
            //Russian letters
            _urlRecordService.GetSeName("testтест", false, true).Should().Be("testтест");
            _urlRecordService.GetSeName("testтест", false, false).Should().Be("test");
        }
    }
}