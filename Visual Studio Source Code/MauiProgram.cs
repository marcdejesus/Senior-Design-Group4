using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
//using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;
namespace WellnessApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "AppDatabase.db");

            builder.Services.AddSingleton<DatabaseService>(_ => new DatabaseService(dbPath));

            builder.Services.AddTransient<MainPage>();
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
