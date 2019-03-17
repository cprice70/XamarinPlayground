using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FFImageLoadingMockTest
{
    public partial class MainPage : ContentPage
    {
        void Handle_Captain_Clicked(object sender, System.EventArgs e)
        {
            var page = new CaptainAmericaPage();
            Navigation.PushAsync (page);
        }

        void Handle_IronMan_Clicked(object sender, System.EventArgs e)
        {
            var page = new IronManPage();
            Navigation.PushAsync (page);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
