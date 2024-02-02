namespace MauiApp1.Views;

public partial class PinPage : ContentPage
{
    public PinPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainLandingPage());
    }
}