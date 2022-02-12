namespace SportTimerMaui;

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
				fonts.AddFont("WorkSans-Regular.ttf", "WorkSansRegular");
				fonts.AddFont("4x7Matrix.ttf", "Numbers");
			});

		return builder.Build();
	}
}
