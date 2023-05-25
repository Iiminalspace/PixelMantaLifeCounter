using PixelMantaLifeCounter.ViewModels;

namespace PixelMantaLifeCounter;

public partial class AppShell : Shell
{
	public AppShell(LifeCounterViewModel lifeCounterViewModel)
	{
		InitializeComponent();

		BindingContext = lifeCounterViewModel;
	}

    public LifeCounterViewModel LifeCounterViewModel => BindingContext as LifeCounterViewModel;

    private void OnButtonClicked(object sender, EventArgs e)
    {
		LifeCounterViewModel.Reset();
    }
}
