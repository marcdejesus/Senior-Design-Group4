using System;
using Microsoft.Maui.Controls;

namespace WellnessApp
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            SetTheme(Application.Current.UserAppTheme);
        }

         private void SetTheme(AppTheme theme)
        {
            if (theme == AppTheme.Dark)
            {
                this.BackgroundColor = Colors.DarkGray;
            }
            else
            {
                this.BackgroundColor = Colors.White;
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

        private async void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SettingsPage");
        }
    }
}