using System.Collections.Generic;
using Syncfusion.Maui.Calendar;

namespace WellnessApp
{
    public partial class SearchPage : ContentPage
    {

        public SearchPage()
        {
            InitializeComponent();
            SfCalendar calendar = new SfCalendar();
            this.Content = calendar;
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