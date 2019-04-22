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
        void Handle_Captain_Clicked(object sender, System.EventArgs e)
        {
            var page = new CaptainAmericaPage();
            Navigation.PushAsync (page);
            listView.SelectedItem = null;
        }

        void Handle_IronMan_Clicked(object sender, System.EventArgs e)
        {
            var page = new IronManPage();
            Navigation.PushAsync (page);
            listView.SelectedItem = null;
        }

        void Handle_Thor_Clicked(object sender, System.EventArgs e)
        {
            var page = new ThorPage();
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
                switch (hero.Name)
                {
                    case "Captain America":
                        Handle_Captain_Clicked(sender, e);
                        break;

                    case "IronMan":
                        Handle_IronMan_Clicked(sender, e);
                        break;

                    case "Thor":
                        Handle_Thor_Clicked(sender, e);
                        break;
                }
            }
        }

    }
}
