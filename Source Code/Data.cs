using System.Collections.Generic;

namespace WellnessApp
{
    public static class PredefinedData
    {
        public static List<Theme> Themes => new List<Theme>
        {
            new Theme { Id = 1, Name = "Studying", Description = "//TODO" },
            new Theme { Id = 2, Name = "Fitness", Description = "//TODO" },
            new Theme { Id = 3, Name = "Language", Description = "//TODO" },
            new Theme { Id = 4, Name = "Instrument", Description = "//TODO" },
            new Theme { Id = 5, Name = "Mental Awareness", Description = "//TODO" }
        };

        public static List<Item> Items => new List<Item>
        {
            new Item { Name = "Pomodoro Timer", Description = "//TODO", ThemeId = 1 }

            //new Item { Name = "Weight Training", Description = "//TODO", ThemeId = 2 },
            
        };
    }
}
