using System.Collections.Generic;

namespace WellnessApp
{
    public partial class MainPage : ContentPage
    {

        private readonly ThemeRepository _themeRepo;

        public MainPage(ThemeRepository dbService)
        {
            InitializeComponent();
            _themeRepo = dbService;
        }

        public async void ShowThemesClicked(object sender, EventArgs e)
        {

            //statusMessage.Text = "";
            if (_themeRepo.GetThemes() == null)
            {
                Application.Current?.CloseWindow(Application.Current.MainPage.Window);

                await _themeRepo.Create(new Theme { Name = "Studying", Description = "Sample Text" });
                await _themeRepo.Create(new Theme { Name = "Fitness", Description = "Sample Text" });
                await _themeRepo.Create(new Theme { Name = "Language", Description = "Sample Text" });
                await _themeRepo.Create(new Theme { Name = "Instrument", Description = "Sample Text" });
                await _themeRepo.Create(new Theme { Name = "Mental Wellness", Description = "Sample Text" });
            }

            List<Theme> themes = await _themeRepo.GetThemes();
            ThemeList.ItemsSource = themes;

            //Task.Run(async () => ThemeList.ItemsSource = await _dbService.GetThemes());

        }

    }

}
