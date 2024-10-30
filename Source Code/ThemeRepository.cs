using System.Collections.Generic;
using System.Threading.Tasks;
using WellnessApp.Services;

namespace WellnessApp.Repositories
{
    public class ThemeRepository
    {
        private readonly DatabaseService _databaseService;

        public ThemeRepository(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task GetThemeByIdAsync(int id)
        {
            await _databaseService.GetThemeByIdAsync(id);
        }

        // Retrieve all themes
        public async Task<List<Theme>> GetAllThemesAsync()
        {
            return await _databaseService.GetThemesAsync();
        }

        // Add a new theme
        public async Task AddThemeAsync(Theme theme)
        {
            await _databaseService.AddThemeAsync(theme);
        }

        // Update an existing theme
        public async Task UpdateThemeAsync(Theme theme)
        {
            await _databaseService.UpdateThemeAsync(theme);
        }

        // Delete a theme
        public async Task DeleteThemeAsync(Theme theme)
        {
            await _databaseService.DeleteThemeAsync(theme);
        }

        // Retrieve all items for a specific theme
        public async Task<List<Item>> GetItemsForThemeAsync(int themeId)
        {
            return await _databaseService.GetItemsAsync(themeId);
        }

        // Add a new item to a specific theme
        public async Task AddItemToThemeAsync(Item item)
        {
            await _databaseService.AddItemAsync(item);
        }

        // Update an existing item of a theme
        public async Task UpdateItemInThemeAsync(Item item)
        {
            await _databaseService.UpdateItemAsync(item);
        }

        // Delete an item from a theme
        public async Task DeleteItemFromThemeAsync(Item item)
        {
            await _databaseService.DeleteItemAsync(item);
        }

        // Clear all items from a theme
        public async Task ClearItemsFromThemeAsync(int themeId)
        {
            var items = await _databaseService.GetItemsAsync(themeId);
            foreach (var item in items)
            {
                await _databaseService.DeleteItemAsync(item);
            }
        }

       
    }
}
