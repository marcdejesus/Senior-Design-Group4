using System;
using Microsoft.Maui.Controls;

namespace WellnessApp
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            // Set initial mode based on current app theme
            ModeSwitch.IsToggled = Application.Current.UserAppTheme == AppTheme.Dark;
            UpdateModeLabel(Application.Current.UserAppTheme);
            SetTheme(Application.Current.UserAppTheme);
        }

        private void OnModeSwitchToggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (e.Value)
                {
                    Application.Current.UserAppTheme = AppTheme.Dark;
                    SetTheme(AppTheme.Dark);
                }
                else
                {
                    Application.Current.UserAppTheme = AppTheme.Light;
                    SetTheme(AppTheme.Light);
                }
                UpdateModeLabel(Application.Current.UserAppTheme);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during theme change
                Console.WriteLine($"Error changing theme: {ex.Message}");
            }
        }

        private void SetTheme(AppTheme theme)
        {
            try
            {
                // Set the theme for the current page
                if (theme == AppTheme.Dark)
                {
                    this.BackgroundColor = Colors.DarkGray;
                }
                else
                {
                    this.BackgroundColor = Colors.White;
                }

                // Set the theme for all pages in the navigation stack
                var navigationStack = Application.Current.MainPage.Navigation?.NavigationStack;
                if (navigationStack != null)
                {
                    foreach (var page in navigationStack)
                    {
                        if (theme == AppTheme.Dark)
                        {
                            page.BackgroundColor = Colors.DarkGray;
                        }
                        else
                        {
                            page.BackgroundColor = Colors.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during theme setting
                Console.WriteLine($"Error setting theme: {ex.Message}");
            }
        }

        private void UpdateModeLabel(AppTheme theme)
        {
            ModeLabel.Text = theme == AppTheme.Dark ? "Dark Mode" : "Light Mode";
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