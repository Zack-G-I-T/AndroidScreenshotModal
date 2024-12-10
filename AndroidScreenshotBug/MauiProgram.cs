using Microsoft.Extensions.Logging;

namespace AndroidScreenshotBug
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
                });

            Routing.RegisterRoute("SecondPage", typeof(SecondPage));
            builder.Services.AddTransient<SecondPage>();
            Routing.RegisterRoute("ThirdPage", typeof(ThirdPage));
            builder.Services.AddTransient<ThirdPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
