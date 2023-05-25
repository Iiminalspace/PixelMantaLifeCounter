using PixelMantaLifeCounter.ViewModels;

namespace PixelMantaLifeCounter.Views;

public partial class LifeCounterView : ContentView
{
	public LifeCounterView(LifeCounterViewModel lifeCounterViewModel)
	{
		InitializeComponent();
		BindingContext = lifeCounterViewModel;
	}

	public LifeCounterViewModel LifeCounterViewModel => BindingContext as LifeCounterViewModel;

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {

    }
}