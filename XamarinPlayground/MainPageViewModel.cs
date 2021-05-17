using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace XamarinPlayground
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
        }

        public List<Hero> Heroes { get; } = new List<Hero>() {
            new Hero("Captain America", "Assets.Captain_America_Shield.svg"),
            new Hero("IronMan", "Assets.ironman-icon.svg"),
            new Hero("Thor", "Assets.thor512.svg"),
            new Hero("Captain Marvel", "Assets.captain_marvel.svg")
        };

        public ICommand ItemCommand { get; } = new Command<object>( (item) =>
        {
            if (item is Hero selectedHero)
            {
                Debug.WriteLine("Selected");
            }
        });
    }
}
