using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinPlayground
{
    public partial class HeroPage : ContentPage
    {
        public HeroPage()
        {
            InitializeComponent();
        }

        public HeroPage(Hero hero)
        {
            InitializeComponent();

            BindingContext = hero;
        }
    }
}
