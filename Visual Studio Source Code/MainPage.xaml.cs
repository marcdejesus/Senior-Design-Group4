﻿using System.Collections.Generic;

namespace WellnessApp
{
    public partial class MainPage : ContentPage
    {

        private readonly ThemeRepository _themeRepo;

        public MainPage(ThemeRepository dbService)
        {
            InitializeComponent();
            _themeRepo = dbService;

            //statusMessage.Text = "";
            if (_themeRepo.GetThemes() == null) // Try setting this condtion to 'true' if the second time running the program and clicking the button doesn't show any results. make sure to switch it back afterwards though.
            {
                //Application.Current?.CloseWindow(Application.Current.MainPage.Window);

                _themeRepo.Create(new Theme { Name = "Studying", Description = "Sample Text" });
                _themeRepo.Create(new Theme { Name = "Fitness", Description = "Sample Text" });
                _themeRepo.Create(new Theme { Name = "Language", Description = "Sample Text" });
                _themeRepo.Create(new Theme { Name = "Instrument", Description = "Sample Text" });
                _themeRepo.Create(new Theme { Name = "Mental Wellness", Description = "Sample Text" });
            }
        }

        public async void ShowThemesClicked(object sender, EventArgs e)
        {

            List<Theme> themes = await _themeRepo.GetThemes();
            ThemeList.ItemsSource = themes;

            //Task.Run(async () => ThemeList.ItemsSource = await _dbService.GetThemes());

        }

    }

}
