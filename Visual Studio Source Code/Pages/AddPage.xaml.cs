using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
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
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadCategories();
        }

        private async Task LoadCategories()
        {
            try
            {
                List<Category> categories = await _databaseService.GetInactiveCategories();
                if (categories == null || categories.Count == 0)
                {
                    Console.WriteLine("No categories found.");
                    return;
                }
                CategoryList.ItemsSource = categories;
                Console.WriteLine($"{categories.Count} categories loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
            }
        }

        private async void listView_ItemTapped_Category(object sender, ItemTappedEventArgs e)
        {
            var category = (Category)e.Item;
            var action = await DisplayActionSheet("Make a selection", "Cancel", null, "Add to TymeLyne");
            if (action == "Add to TymeLyne")
            {
                await _databaseService.AddCategoryToActive(category);
            }
            LoadCategories();
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