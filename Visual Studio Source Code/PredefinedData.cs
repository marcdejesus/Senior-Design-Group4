using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellnessApp.Items;

namespace WellnessApp.Database.Services
{
    public static class PredefinedData
    {
        // Predefined Theme data
        public static List<Theme> Themes => new List<Theme>
        {
            new Theme { ThemeId = 1, Name = "Fitness", Description = "//TODO" },
            new Theme { ThemeId = 2, Name = "Studying", Description = "//TODO" },
            new Theme { ThemeId = 3, Name = "Language", Description = "//TODO" },
            new Theme { ThemeId = 4, Name = "Instrument", Description = "//TODO" },
            new Theme { ThemeId = 5, Name = "Mental Awareness", Description = "//TODO" }
        };

        // Predefined Category data
        public static List<Category> Categories => new List<Category>
        {
            new Category { CategoryId = 1, Name = "Strength Training", Description = "//TODO", ParentThemeId = 1 }

        };

        // Predefined Goals data
        public static List<Goal> Goals => new List<Goal>
        {
            new Goal { GoalId = 1, Description = "Complete a bodyweight squat for 1 minute", ParentCatId = 1  },
            new Goal { GoalId = 1, Description = "Get that dub", ParentCatId = 1, Status = "Completed" },
            new Goal { GoalId = 1, Description = "Get a Victory Royale in sqauds with the boys", ParentCatId = 1, Status = "Active"  }
        };
    }
}
