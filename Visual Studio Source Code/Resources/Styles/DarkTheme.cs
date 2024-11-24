using Microsoft.Maui.Controls;

namespace WellnessApp.Resources.Styles
{
    public class DarkTheme : ResourceDictionary
    {
        public DarkTheme()
        {
            this.Add("BackgroundColor", Color.FromArgb("#000000"));
            this.Add("TextColor", Color.FromArgb("#FFFFFF"));
            // Add other dark theme resources here
        }
    }
}