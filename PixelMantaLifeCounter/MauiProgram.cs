using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PixelMantaLifeCounter.ViewModels;
using PixelMantaLifeCounter.Views;

namespace PixelMantaLifeCounter;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("joystix monospace.otf", "Joystix");
			});

        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<LifeCounterViewModel>();
		builder.Services.AddSingleton<AppShell>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
