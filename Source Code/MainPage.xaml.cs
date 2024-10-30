using System.Collections.Generic;
using WellnessApp.Repositories;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using WellnessApp.Services;

namespace WellnessApp
{
    public partial class MainPage : ContentPage
    {

        private List<Item> _items;
        public int? SelectedThemeId { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            
            
        }

        private async void LoadThemes()
        {
            // Ensure ThemeRepository is initialized
            if (App.ThemeRepository != null)
            {
                List<Theme> themes = await App.ThemeRepository.GetAllThemesAsync();
                ThemeList.ItemsSource = themes;
            }
            else
            {
                await DisplayAlert("Error", "Theme repository is not initialized.", "OK");
            }
        }

        private async void OnSelectThemeClicked(object sender, EventArgs e)
        {
            try
            {
                //SelectedThemeId = _currentTheme.Id;
                await Shell.Current.GoToAsync(("//Studying"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load Page: {ex.Message}");
            }
            
        }

        public void ShowThemesClicked(object sender, EventArgs e)
        {

            LoadThemes();
            
        }

        

        //TODO Find way to reset Main Page when returning from a different page

    }

}
