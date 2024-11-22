//using WellnessApp.Database.Items;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
//using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;
using WellnessApp.Items;
namespace WellnessApp
{
    public partial class CompletedGoalPage : ContentPage
    {
        private readonly DatabaseService _databaseService;


        public CompletedGoalPage(DatabaseService databaseService)
        {
            _databaseService = databaseService;

            InitializeComponent();

            //LoadGoals();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadGoals();
        }

        private async Task LoadGoals()
        {
            try
            {
                // Get themes asynchronously
                List<Goal> goals = await _databaseService.GetCompletedGoals();

                // Check if themes are null or empty
                if (goals == null || goals.Count == 0)
                {
                    Console.WriteLine("No goals found.");
                    return;
                }

                // Update the UI
                GoalList.ItemsSource = goals;
                Console.WriteLine($"{goals.Count} goals loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading themes: {ex.Message}");
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

    }
}

