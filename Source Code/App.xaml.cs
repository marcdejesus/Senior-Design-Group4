using System.Security.Cryptography.X509Certificates;
using WellnessApp.Repositories;
using WellnessApp.Services;
using System.IO;
using Microsoft.Maui.Controls;

namespace WellnessApp
{
    public partial class App : Application
    {

        public static ThemeRepository ThemeRepository { get; private set; }
        public static ItemRepository ItemRepository { get; private set; }

        public App(MainPage mainPage)
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "themes.db3");
            var databaseService = new DatabaseService(dbPath);

            ThemeRepository = new ThemeRepository(databaseService);
            ItemRepository = new ItemRepository(databaseService);


            // Initialize the database with predefined data
            Task.Run(async () =>
            {
                await databaseService.InitializeDatabaseAsync(); // Ensure the tables are created
               
            }).Wait();

            // Load main page
            MainPage = new AppShell();
        }
    }
}
