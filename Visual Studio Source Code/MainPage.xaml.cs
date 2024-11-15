//using WellnessApp.Database.Items;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
//using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;
using WellnessApp.Items;

namespace WellnessApp
{
    public partial class MainPage : ContentPage
    {

        private readonly DatabaseService _databaseService;

        public MainPage(DatabaseService databaseService)
        {
            _databaseService = databaseService;

            InitializeComponent();

            //LoadThemes();
        }

        private async Task LoadThemes()
        {
            try
            {
                // Get themes asynchronously
                List<Theme> themes = await _databaseService.GetThemes();

                // Check if themes are null or empty
                if (themes == null || themes.Count == 0)
                {
                    Console.WriteLine("No themes found.");
                    return;
                }

                // Update the UI
                ThemeList.ItemsSource = themes;
                Console.WriteLine($"{themes.Count} themes loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading themes: {ex.Message}");
            }
        }

        public async void ShowThemesClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked!");
            try
            {
                await LoadThemes();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ShowThemesClicked: {ex.Message}");
            }
        }

        // Navigation button click handlers
        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage"); // Navigates to Home
        }

        private async void OnCalendarButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CalendarPage");
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//AddPage");
        }

        private async void OnExploreButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ExplorePage");
        }

        private async void OnProfileButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProfilePage");
        }

        private async void OnGoalButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//GoalPage");
        }

        private async void OnCompletedButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CompletedGoalPage");
        }
    }

}
