using Microsoft.Maui.Controls;

namespace WellnessApp.Resources.Styles
{
    public class LightTheme : ResourceDictionary
    {
        public LightTheme()
        {
            this.Add("BackgroundColor", Color.FromArgb("#FFFFFF"));
            this.Add("TextColor", Color.FromArgb("#000000"));
            // Add other light theme resources here
        }
    }
}