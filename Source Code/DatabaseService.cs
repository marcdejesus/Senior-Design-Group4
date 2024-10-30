using SQLite;
using SQLitePCL;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WellnessApp.Tests;

namespace WellnessApp.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Theme>().Wait();
            _database.CreateTableAsync<Item>().Wait();
        }

        //Database initialization
        public async Task InitializeDatabaseAsync()
        {
            // Check if there are any themes in the database
            var themes = await GetThemesAsync();
            if (themes.Count == 0)
            {
                // Preload themes
                foreach (var theme in PredefinedData.Themes)
                {
                    await AddThemeAsync(theme);
                }

                // Preload items, ensuring you set the ThemeId correctly
                foreach (var item in PredefinedData.Items)
                {
                    await AddItemAsync(item);
                }
            }
        }

        // Theme methods
        public async Task<Theme> GetThemeByIdAsync(int id)
        {
            return await _database.Table<Theme>().FirstOrDefaultAsync(t => t.Id == id);
        }

        public Task<List<Theme>> GetThemesAsync()
        {
            return _database.Table<Theme>().ToListAsync();
        }

        public Task<int> AddThemeAsync(Theme theme)
        {
            return _database.InsertAsync(theme);
        }

        public Task<int> UpdateThemeAsync(Theme theme)
        {
            return _database.UpdateAsync(theme);
        }

        public Task<int> DeleteThemeAsync(Theme theme)
        {
            return _database.DeleteAsync(theme);
        }

        // Item methods
        public Task<List<Item>> GetItemsAsync(int themeId)
        {
            return _database.Table<Item>().Where(i => i.ThemeId == themeId).ToListAsync();
        }

        public Task<int> AddItemAsync(Item item)
        {
            return _database.InsertAsync(item);
        }

        public Task<int> UpdateItemAsync(Item item)
        {
            return _database.UpdateAsync(item);
        }

        public Task<int> DeleteItemAsync(Item item)
        {
            return _database.DeleteAsync(item);
        }

    }
}