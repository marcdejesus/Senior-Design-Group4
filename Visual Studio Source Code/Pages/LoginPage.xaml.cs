using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace WellnessApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnbackButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProfilePage");
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignUpPage");
        }
        private void OnPageTapped(object sender, EventArgs e)
        {
            // Dismiss the keyboard by unfocusing the ContentPage
            this.Unfocus();
        }
    }
}
