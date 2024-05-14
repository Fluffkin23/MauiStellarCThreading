namespace MauiStellarCThreading.Views;

public partial class HoroscopePageView : ContentPage
{
	public HoroscopePageView()
	{
		InitializeComponent();

        // Initialize the ViewModel
        _viewModel = new HoroscopeViewModel();

        // Set the binding context of the page to the ViewModel
        this.BindingContext = _viewModel;
    }
}