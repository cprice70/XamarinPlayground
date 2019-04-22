using System;
using System.Reflection;
using FFImageLoading;
using FFImageLoading.Svg.Platform;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ImageService.Instance.LoadEmbeddedResource("Captain_America_Shield.svg", typeof(App).GetTypeInfo().Assembly)
            .WithCustomDataResolver(new SvgDataResolver(512, 512, true))
            .Preload();

            ImageService.Instance.LoadEmbeddedResource("XamarinPlayground.Assets.ironman-icon-png-8.png").Preload();
            ImageService.Instance.LoadEmbeddedResource("XamarinPlayground.Assets.thor512.png").Preload();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
