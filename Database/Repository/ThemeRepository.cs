using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellnessApp.Database.Items;
using WellnessApp.Database.Services;


namespace WellnessApp.Database.Repository
{
    public class ThemeRepository
    {
        private readonly DatabaseService _database;

        public ThemeRepository(DatabaseService databaseService)
        {
            _database = databaseService;
        }

        public async Task<List<Theme>> GetThemes()
        {
            return await _database.GetThemes();
        }

        public async Task<Theme> GetByThemeId(int id)
        {
            return await _database.GetByThemeId(id);
        }

        public async Task Create(Theme theme)
        {
            await _database.CreateTheme(theme);
        }

        public async Task Update(Theme theme)
        {
            await _database.UpdateTheme(theme);
        }
        public async Task Delete(Theme theme)
        {
            await _database.DeleteTheme(theme);
        }

        //public async Task AddThemeToActive(Theme theme)
        //{
        //    int primKey = theme.ThemeId;

        //    Theme updatedTheme = new Theme
        //    {
        //        ThemeId = primKey,
        //        Name = theme.Name,
        //        Description = theme.Description,
        //        Status = "Active",
        //        Days = theme.Days
        //    };
        //    await _database.UpdateTheme(updatedTheme);

        //    List<Category> childCategories = await _database.GetCategoryByParentId(primKey);

        //    foreach (Category category in childCategories)
        //    {
        //        Category updatedCategory = new Category
        //        {
        //            CategoryId = category.CategoryId,
        //            Name = category.Name,
        //            Description = category.Description,
        //            ParentThemeId = category.ParentThemeId,
        //            Status = "Active",
        //            Days = category.Days
        //        };
        //        await _database.UpdateCategory(updatedCategory);
        //    }
        //}
    }
}
