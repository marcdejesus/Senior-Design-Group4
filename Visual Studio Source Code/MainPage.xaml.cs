using System.Collections.Generic;
using WellnessApp.Database.Items;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;


namespace WellnessApp
{
    public partial class MainPage : ContentPage
    {

        private readonly ThemeRepository _themeRepository;

        public MainPage(ThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
            
            InitializeComponent();
             

        }




        private async Task LoadThemes()
        {
            try
            {
                // Get themes asynchronously
                List<Theme> themes = await _themeRepository.GetThemes();

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


    }

}
