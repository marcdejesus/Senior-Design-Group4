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
            LoadCategories();
            CategoryList.ItemTapped += OnCategoryTapped;
        }

        private async Task LoadCategories()
        {
            try
            {
                List<Category> categories = await _databaseService.GetActiveCategories();
                CategoryList.ItemsSource = categories;
                Console.WriteLine($"{categories.Count} categories loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
            }
        }

        private async void OnCategoryTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Category category)
            {
                await Shell.Current.GoToAsync($"//GoalPage?CategoryId={category.CategoryId}");
                // Deselect the item
                ((ListView)sender).SelectedItem = null;
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

        //private async void OnGoalButtonClicked(object sender, EventArgs e)
        //{
            //var navParam = new Dictionary<string, object>
            //{
            //    {"_databaseService", _databaseService }
            //};
            //await Shell.Current.GoToAsync("//GoalPage");
        //}

        private async void OnCompletedButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CompletedGoalPage");
        }
    }

}
