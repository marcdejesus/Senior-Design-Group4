//using WellnessApp.Database.Items;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
//using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;
using WellnessApp.Items;
namespace WellnessApp
{
    public partial class AddPage : ContentPage
    {
        private readonly DatabaseService _databaseService;

        public AddPage(DatabaseService databaseService)
        {
            _databaseService = databaseService;

            InitializeComponent();

            //LoadGoals();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadThemes();
            LoadCategories();
            LoadGoals();
        }

        private async void listView_ItemTapped_Theme(object sender, ItemTappedEventArgs e)
        {

            var theme = (Theme)e.Item;
            var action = await DisplayActionSheet("Make a selection", "Cancel", null, "Add to TymeLyne");

            switch (action)
            {
                case "Add to TymeLyne":
                    await _databaseService.AddThemeToActive(theme);
                    break;
            }

            LoadThemes();
            LoadCategories();
            LoadGoals();
        }

        private async void listView_ItemTapped_Category(object sender, ItemTappedEventArgs e)
        {

            var category = (Category)e.Item;
            var action = await DisplayActionSheet("Make a selection", "Cancel", null, "Add to TymeLyne");

            switch (action)
            {
                case "Add to TymeLyne":
                    await _databaseService.AddCategoryToActive(category);
                    break;
            }

            LoadCategories();
            LoadGoals();
        }

        private async void listView_ItemTapped_Goal(object sender, ItemTappedEventArgs e)
        {

            var goal = (Goal)e.Item;
            var action = await DisplayActionSheet("Make a selection", "Cancel", null, "Add to TymeLyne");

            switch (action)
            {
                case "Add to TymeLyne":
                    await _databaseService.AddGoalToActive(goal);
                    break;
            }

            LoadGoals();
        }

        private async Task LoadThemes()
        {
            try
            {
                // Get themes asynchronously
                List<Theme> themes = await _databaseService.GetInactiveThemes();

                // Check if themes are null or empty
                //if (goals == null || goals.Count == 0)
                //{
                //    Console.WriteLine("No goals found.");
                //    return;
                //}

                // Update the UI
                ThemeList.ItemsSource = themes;
                Console.WriteLine($"{themes.Count} themes loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading themes: {ex.Message}");
            }
        }

        private async Task LoadCategories()
        {
            try
            {
                // Get themes asynchronously
                List<Category> categories = await _databaseService.GetInactiveCategories();

                // Check if themes are null or empty
                //if (goals == null || goals.Count == 0)
                //{
                //    Console.WriteLine("No goals found.");
                //    return;
                //}

                // Update the UI
                CategoryList.ItemsSource = categories;
                Console.WriteLine($"{categories.Count} categories loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
            }
        }
        private async Task LoadGoals()
        {
            try
            {
                // Get themes asynchronously
                List<Goal> goals = await _databaseService.GetInactiveGoals();

                // Check if themes are null or empty
                //if (goals == null || goals.Count == 0)
                //{
                //    Console.WriteLine("No goals found.");
                //    return;
                //}

                // Update the UI
                GoalList.ItemsSource = goals;
                Console.WriteLine($"{goals.Count} goals loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
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