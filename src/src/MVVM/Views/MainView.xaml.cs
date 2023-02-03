namespace src.MVVM.Views;

public partial class MainView : ContentPage
{
    public MainView()
    {
        InitializeComponent();
        this.BindingContext = new MVVM.ViewModels.WeatherViewModel();
    }
}
