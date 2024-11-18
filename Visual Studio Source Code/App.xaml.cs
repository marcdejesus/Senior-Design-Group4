using WellnessApp.Database.Services;
//using WellnessApp.Database.Repository;
namespace WellnessApp
{
    public partial class App : Application
    {
        //internal static object ThemeRepository;

        public App(MainPage mainPage)
        {
            InitializeComponent();

            

            MainPage = new AppShell();
        }
    }
}
