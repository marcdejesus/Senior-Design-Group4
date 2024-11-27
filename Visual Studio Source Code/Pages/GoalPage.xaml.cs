using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using WellnessApp.Database.Services;
using WellnessApp.Items;

namespace WellnessApp
{
    [QueryProperty(nameof(CategoryId), "CategoryId")]
    public partial class GoalPage : ContentPage
    {
        private readonly DatabaseService _databaseService;
        private int _categoryId;

        public int CategoryId
        {
            get => _categoryId;
            set
            {
                _categoryId = value;
                //LoadGoals();
            }
        }

        public GoalPage(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            InitializeComponent();
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
                var allGoals = await _databaseService.GetActiveGoals();
                var categoryGoals = allGoals.Where(g => g.ParentCatId == CategoryId).ToList();
                GoalList.ItemsSource = categoryGoals;
                Console.WriteLine($"{categoryGoals.Count} goals loaded for category {CategoryId}.");

                if (categoryGoals.Count() == 0)
                {
                    foreach (var category in await _databaseService.GetCategories())
                    {
                        if (category.CategoryId == CategoryId) 
                        { 
                            _databaseService.AddCategoryToCompleted(category);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Goal goal)
            {
                var action = await DisplayActionSheet("Make a selection", "Cancel", null, "Complete", "Abandon");

                switch (action)
                {
                    case "Complete":
                        await _databaseService.AddGoalToCompleted(goal);
                        break;
                    case "Abandon":
                        await _databaseService.AbandonGoal(goal);
                        break;
                }
                
                await LoadGoals();
            }
        }

        // Navigation button click handlers
        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }

        private async void OnCalendarButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CalendarPage");
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