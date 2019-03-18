using FFImageLoading;
using NUnit.Framework;
using System;
using Xamarin.Forms;

namespace FFImageLoadingMockTest.Test
{
    [TestFixture]
    public class Test
    {
        [SetUp]
        public void SetUp()
        {
            ImageService.EnableMockImageService = true;
            Xamarin.Forms.Mocks.MockForms.Init(Device.Android);
            Application.Current = new App();
        }

        [Test]
        public void TestMainPage()
        {
            var page = new MainPage();
            Assert.IsNotNull(page);
        }

        [Test]
        public void TestCaptainPage()
        {
            var page = new CaptainAmericaPage();
            Assert.IsNotNull(page);
        }

        [Test]
        public void TestIronManPage()
        {
            var page = new IronManPage();
            Assert.IsNotNull(page);
        }

        [Test]
        public void TestThorPage()
        {
            var page = new ThorPage();
            Assert.IsNotNull(page);
        }

        [TearDown]
        public void TearDown()
        {
            Application.Current = null;
        }
    }
}
