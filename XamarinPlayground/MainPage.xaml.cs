using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPlayground
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(Hero hero)
        {
            var page = new HeroPage(hero);
            Navigation.PushAsync(page);
            listView.SelectedItem = null;
        }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();

            listView.ItemTapped += ListView_ItemTapped;
        }

        void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Hero hero)
            {
                Handle_Clicked(hero);
            }
        }

    }
}
