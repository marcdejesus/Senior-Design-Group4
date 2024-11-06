using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellnessApp.Database.Items;


namespace WellnessApp.Database.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Theme>().Wait();
            _database.CreateTableAsync<Category>().Wait();
            _database.CreateTableAsync<Goal>().Wait();
            _ = InitializeDatabaseAsync();
            
        }

       

        //Database initialization
        public async Task InitializeDatabaseAsync()
        {
            // Check if there are any themes in the database
            var themes = await GetThemes();
            if (themes.Count == 0)
            {
                try
                {
                    // Preload themes
                    foreach (var theme in PredefinedData.Themes)
                    {
                        await CreateTheme(theme);
                    }

                    // Preload categories
                    foreach (var category in PredefinedData.Categories)
                    {
                        await CreateCategory(category);
                    }

                    // Preload goals
                    foreach (var goal in PredefinedData.Goals)
                    {
                        await CreateGoal(goal);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while preloading data: {ex.Message}");
                }
            }
        }

        // Theme Methods
        public async Task<List<Theme>> GetThemes()
        {
            return await _database.Table<Theme>().ToListAsync();
        }

        public async Task<Theme> GetByThemeId(int id)
        {
            return await _database.Table<Theme>().Where(x => x.ThemeId == id).FirstOrDefaultAsync();
        }

        public async Task CreateTheme(Theme theme)
        {
            await _database.InsertAsync(theme);
        }

        public async Task Update(Theme theme)
        {
            await _database.UpdateAsync(theme);
        }
        public async Task Delete(Theme theme)
        {
            await _database.DeleteAsync(theme);
        }

        // Category Methods
        public async Task<Category> GetCategoryById (int id)
        {
            return await _database.Table<Category>().FirstOrDefaultAsync(t => t.CategoryId == id);
        }

        public Task<int> CreateCategory (Category category)
        {
            return _database.InsertAsync(category);
        }

        // Goal Methods
        public Task<List<Goal>> GetGoalById(int id)
        {
            return _database.Table<Goal>().Where(i => i.GoalId == id).ToListAsync();
        }

        public Task<int> CreateGoal (Goal goal)
        {
            return _database.InsertAsync(goal);
        }
    }
}

