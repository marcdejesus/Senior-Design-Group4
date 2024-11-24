//using WellnessApp.Database.Items;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
//using WellnessApp.Database.Repository;
using WellnessApp.Database.Services;
using WellnessApp.Items;
using WellnessApp.Resources.Styles;

namespace WellnessApp
{
    public partial class ProfilePage : ContentPage
    {

        public ProfilePage()
        {
            InitializeComponent();
        }

        private void OnThemeSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
            }
            else
            {
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
            }
        }

        private async void OnProfileImageTapped(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Please select a profile picture"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                ProfileImage.Source = ImageSource.FromStream(() => stream);
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