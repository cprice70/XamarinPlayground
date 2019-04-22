using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinPlayground
{
    public partial class ThorPage : ContentPage
    {
        public ThorPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("XamarinPlayground.Assets.thor512.png", typeof(ThorPage).GetTypeInfo().Assembly);

        }
    }
}
