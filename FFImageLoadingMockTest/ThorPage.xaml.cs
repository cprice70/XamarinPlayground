using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace FFImageLoadingMockTest
{
    public partial class ThorPage : ContentPage
    {
        public ThorPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("FFImageLoadingMockTest.Assets.thor512.png", typeof(ThorPage).GetTypeInfo().Assembly);

        }
    }
}
