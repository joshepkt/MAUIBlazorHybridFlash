using MauiApp1.ViewModels;

namespace MauiApp1
{
    public partial class MainLandingPage : ContentPage
    {
        public MainLandingPage()
        {
            InitializeComponent();
            HomePageComponent.Parameters = new Dictionary<string, object> { ["ViewModel"] = new HomePageViewModel() };
        }
    }
}
