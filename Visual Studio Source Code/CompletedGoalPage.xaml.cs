using System.Collections.Generic;

namespace WellnessApp
{
    public partial class CompletedGoalPage : ContentPage
    {

        public CompletedGoalPage()
        {
            InitializeComponent();
        }

        // Navigation button click handlers
        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage"); // Navigates to Home
        }

        private async void OnCalendarButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SearchPage");
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//AddPage");
        }

        private async void OnActivityButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ActivityPage");
        }

        private async void OnProfileButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProfilePage");
        }

    }

}