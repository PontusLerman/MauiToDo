using MauiToDo.Services;
using MauiToDo.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiToDo
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

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<DetailsPage>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddTransient<DetailsViewModel>();
            builder.Services.AddSingleton<JsonServices>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
