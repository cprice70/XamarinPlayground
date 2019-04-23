using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinPlayground
{
    public partial class CaptainAmericaPage : ContentPage
    {
        public CaptainAmericaPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (logo.Source == null)
            {
                logo.Source = "resource://XamarinPlayground.Assets.Captain_America_Shield.svg";
            }
        }
    }
}
