using Microsoft.Extensions.Logging;
//using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;
using Syncfusion.Maui.Core.Hosting;

namespace WellnessApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "AppDatabase.db");

            builder.Services.AddSingleton<DatabaseService>(_ => new DatabaseService(dbPath));

            //builder.Services.AddSingleton<ThemeRepository>();
            //builder.Services.AddSingleton<CategoryRepository>();
            //builder.Services.AddSingleton<GoalRepository>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<GoalPage>();
            builder.Services.AddTransient<AddPage>();
            builder.Services.AddTransient<CompletedGoalPage>();
            builder.Services.AddTransient<CalendarPage>();
            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<ExplorePage>();
            builder.Services.AddTransient<SignUpPage>();
            builder.Services.AddTransient<LoginPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
