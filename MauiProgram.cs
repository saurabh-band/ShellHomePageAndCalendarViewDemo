using Microsoft.Extensions.Logging;
using Plugin.Maui.CalendarStore;
using Syncfusion.Maui.Core.Hosting;

namespace CascadePOCHomePage
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			builder.ConfigureSyncfusionCore();
			builder.Services.AddSingleton<ICalendarStore>(CalendarStore.Default);
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
