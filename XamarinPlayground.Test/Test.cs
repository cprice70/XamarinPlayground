using FFImageLoading;
using NUnit.Framework;
using Xamarin.Forms;

namespace XamarinPlayground.Test
{
    [TestFixture]
    public class Test
    {
        [SetUp]
        public void SetUp()
        {
            ImageService.EnableMockImageService = true;
            Xamarin.Forms.Mocks.MockForms.Init();
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
            var viewModel = new MainPageViewModel();
            var page = new HeroPage(viewModel.Heroes[0]);
            Assert.IsNotNull(page);
        }

        [Test]
        public void TestIronManPage()
        {
            var viewModel = new MainPageViewModel();
            var page = new HeroPage(viewModel.Heroes[1]);
            Assert.IsNotNull(page);
        }

        [Test]
        public void TestThorPage()
        {
            var viewModel = new MainPageViewModel();
            var page = new HeroPage(viewModel.Heroes[2]);
            Assert.IsNotNull(page);
        }

        [Test]
        public void TestMarvelPage()
        {
            var viewModel = new MainPageViewModel();
            var page = new HeroPage(viewModel.Heroes[3]);
            Assert.IsNotNull(page);
        }

        [TearDown]
        public void TearDown()
        {
            Application.Current = null;
        }
    }
}
