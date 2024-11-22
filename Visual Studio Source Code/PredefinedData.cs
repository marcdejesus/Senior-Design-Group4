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
            new Theme { ThemeId = 1, Name = "Fitness", Description = "//TODO", Status = "Active"},
            new Theme { ThemeId = 2, Name = "Studying", Description = "//TODO", Status = "Inactive" },
            new Theme { ThemeId = 3, Name = "Language", Description = "//TODO", Status = "Inactive" },
            new Theme { ThemeId = 4, Name = "Instrument", Description = "//TODO", Status = "Active"},
            new Theme { ThemeId = 5, Name = "Mental Awareness", Description = "//TODO", Status = "Inactive" }
        };

        // Predefined Category data
        public static List<Category> Categories => new List<Category>
        {
            new Category { CategoryId = 1, Name = "Strength Training", Description = "//TODO", ParentThemeId = 1, Status = "Active" },
            new Category { CategoryId = 2, Name = "Endurance Training", Description = "//TODO", ParentThemeId = 1, Status = "Inactive" },
            new Category { CategoryId = 3, Name = "Fliexibility Training", Description = "//TODO", ParentThemeId = 1, Status = "Inactive" },

            new Category { CategoryId = 4, Name = "Material Review", Description = "//TODO", ParentThemeId = 2, Status = "Inactive" },
            new Category { CategoryId = 5, Name = "Self Assessment", Description = "//TODO", ParentThemeId = 2, Status = "Inactive" },
            new Category { CategoryId = 6, Name = "Group Study", Description = "//TODO", ParentThemeId = 2, Status = "Inactive" },

            new Category { CategoryId = 7, Name = "Speaking", Description = "//TODO", ParentThemeId = 3, Status = "Inactive" },
            new Category { CategoryId = 8, Name = "Listening", Description = "//TODO", ParentThemeId = 3, Status = "Inactive" },
            new Category { CategoryId = 9, Name = "Reading/Writing", Description = "//TODO", ParentThemeId = 3, Status = "Inactive" }

        };

        // Predefined Goals data
        public static List<Goal> Goals => new List<Goal>
        {
            new Goal { GoalId = 1, Description = "Complete a bodyweight squat for 1 minute", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 2, Description = "Do 20 push ups", ParentCatId = 1, Status = "Completed" },
            new Goal { GoalId = 3, Description = "Hold a plank for 1 minute", ParentCatId = 1, Status = "Active"  },

            new Goal { GoalId = 4, Description = "Endurance Training 1", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 5, Description = "Endurance Training 2", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 6, Description = "Endurance Training 3", ParentCatId = 2, Status = "Inactive" },

            new Goal { GoalId = 7, Description = "Flexibility Training 1", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 8, Description = "Flexibility Training 2", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 9, Description = "Flexibility Training 3", ParentCatId = 3, Status = "Inactive" },



            new Goal { GoalId = 10, Description = "Material Review 1", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 11, Description = "Material Review 2", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 12, Description = "Material Review 3", ParentCatId = 4, Status = "Inactive" },

            new Goal { GoalId = 13, Description = "Self Assessment 1", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 14, Description = "Self Assessment 2", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 15, Description = "Self Assessment 3", ParentCatId = 5, Status = "Inactive" },

            new Goal { GoalId = 16, Description = "Group Study 1", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 17, Description = "Group Study 2", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 18, Description = "Group Study 3", ParentCatId = 6, Status = "Inactive" },



            new Goal { GoalId = 19, Description = "Speaking 1", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 20, Description = "Speaking 2", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 21, Description = "Speaking 3", ParentCatId = 7, Status = "Inactive" },

            new Goal { GoalId = 22, Description = "Listening 1", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 23, Description = "Listening 2", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 24, Description = "Listening 3", ParentCatId = 8, Status = "Inactive" },

            new Goal { GoalId = 25, Description = "Reading/Writing 1", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 26, Description = "Reading/Writing 2", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 27, Description = "Reading/Writing 3", ParentCatId = 9, Status = "Inactive" }
        };
    }
}
