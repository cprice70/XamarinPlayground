using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPlayground
{
    public partial class MainPage
    { 
        private async Task Handle_Clicked(Hero hero)
        {
            var page = new HeroPage(hero);
            await Navigation.PushAsync(page);
            listView.SelectedItem = null;
        }

        public MainPage()
        {
            InitializeComponent();

            listView.SelectionMode = SelectionMode.Single;

            BindingContext = new MainPageViewModel();

            listView.SelectionChanged += ListViewOnSelectionChanged;
            //listView. += ListView_ItemTapped;
        }

        private async void ListViewOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0 && e.CurrentSelection[0] is Hero hero)
            {
                await Handle_Clicked(hero);
            }
        }
    }
}