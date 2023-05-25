using PixelMantaLifeCounter.ViewModels;

namespace PixelMantaLifeCounter;

public partial class MainPage : ContentPage
{
	public MainPage(LifeCounterViewModel lifeCounterViewModel)
	{
		InitializeComponent();
        BindingContext = lifeCounterViewModel;
    }

    public LifeCounterViewModel LifeCounterViewModel => BindingContext as LifeCounterViewModel;
}

