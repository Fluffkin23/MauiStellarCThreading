using MauiStellarCThreading.ViewModel;

namespace MauiStellarCThreading.Views;

public partial class StartPageView : ContentPage
{
	public StartPageView()
	{
		InitializeComponent();
        BindingContext = new StartPageViewModel();

    }
}