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
            ListView.SelectedItem = null; ;
        }

        public MainPage()
        {
            InitializeComponent();

            ListView.SelectionMode = SelectionMode.Single;

            BindingContext = new MainPageViewModel();

            ListView.SelectionChanged += ListViewOnSelectionChanged;
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