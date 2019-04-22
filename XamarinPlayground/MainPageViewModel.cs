using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XamarinPlayground
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
        }

        public List<Hero> Heroes { get; } = new List<Hero>() {
            new Hero("Captain America", "resource://XamarinPlayground.Assets.Captain_America_Shield.svg"),
            new Hero("IronMan", "resource://XamarinPlayground.Assets.ironman-icon-png-8.png"),
            new Hero("Thor", "resource://XamarinPlayground.Assets.thor512.png") };

    }
}
