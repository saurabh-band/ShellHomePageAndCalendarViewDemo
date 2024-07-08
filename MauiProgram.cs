using Microsoft.Extensions.Logging;

namespace CascadePOCHomePage
{
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
                    fonts.AddFont(filename:"font-awesome-5-free-solid.otf", alias:"FontAwesomeSolid");
                    fonts.AddFont(filename:"font-awesome-5-free-regular.otf", alias:"FontAwesomeRegular");
					fonts.AddFont(filename:"FontAwesome.ttf", alias:"FontAwesome");
					fonts.AddFont(filename: "fontawesome-webfont.ttf", alias:"FontAwesomeWebFont");
					fonts.AddFont("museo_slab_300-webfont.ttf", "museoslb300webfont");
					fonts.AddFont("museo_slab_500-webfont.ttf", "museoslb500webfont");
					fonts.AddFont("proximanova-webfont.ttf", "proximanovawebfont");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
