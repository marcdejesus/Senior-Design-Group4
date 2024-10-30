using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using WellnessApp.Services;
using WellnessApp.Repositories;

namespace WellnessApp
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

            // Register DatabaseService with dependency injection
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "AppDatabase.db");
            builder.Services.AddSingleton<DatabaseService>(_ => new DatabaseService(dbPath));

            builder.Services.AddSingleton<ThemeRepository>();
            builder.Services.AddTransient<MainPage>();    

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
