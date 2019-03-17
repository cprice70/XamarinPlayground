using NUnit.Framework;
using System;
namespace FFImageLoadingMockTest.Test
{
    [TestFixture]
    public class Test
    {
        [SetUp]
        public void SetUp()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
        }

        [Test]
        public void TestCase()
        {
            var page = new MainPage();
            Assert.IsNotNull(page);
        }
    }
}
