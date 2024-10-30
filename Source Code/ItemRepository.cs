using System.Collections.Generic;
using System.Threading.Tasks;
using WellnessApp.Services;

namespace WellnessApp.Repositories
{
    public class ItemRepository
    {
        private readonly DatabaseService _databaseService;

        public ItemRepository(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        // Retrieve items for a specific theme
        public async Task<List<Item>> GetItemsForThemeAsync(int themeId)
        {
            return await _databaseService.GetItemsAsync(themeId);
        }

        // Add a new item
        public async Task AddItemAsync(Item item)
        {
            await _databaseService.AddItemAsync(item);
        }

        // Update an existing item
        public async Task UpdateItemAsync(Item item)
        {
            await _databaseService.UpdateItemAsync(item);
        }

        // Delete an item
        public async Task DeleteItemAsync(Item item)
        {
            await _databaseService.DeleteItemAsync(item);
        }
    }
}
