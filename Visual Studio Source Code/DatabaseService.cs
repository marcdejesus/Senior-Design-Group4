using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellnessApp.Items;


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
            foreach (var theme in await GetThemes())
            {
                await DeleteTheme(theme);
            }
            foreach (var category in await GetCategories())
            {
                await DeleteCategory(category);
            }
            foreach (var goal in await GetGoals())
            {
                await DeleteGoal(goal);
            }

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
        public async Task<List<Theme>> GetInactiveThemes()
        {
            return await _database.Table<Theme>().Where(t => t.Status == "Inactive").ToListAsync();
        }
        public async Task UpdateTheme(Theme theme)
        {
            await _database.UpdateAsync(theme);
        }

        public async Task CreateTheme(Theme theme)
        {
            await _database.InsertAsync(theme);
        }
        public async Task DeleteTheme(Theme theme)
        {
            await _database.DeleteAsync(theme);
        }

        public async Task AddThemeToActive(Theme theme)
        {
            int primKey = theme.ThemeId;

            Theme updatedTheme = new Theme
            {
                ThemeId = primKey,
                Name = theme.Name,
                Description = theme.Description,
                Status = "Active",
                Days = theme.Days
            };
            await UpdateTheme(updatedTheme);

            List<Category> childCategories = await GetCategoryByParentId(primKey);

            foreach (Category category in childCategories)
            {
                await AddCategoryToActive(category);
            }
        }

        // Category Methods
        public async Task<List<Category>> GetCategories()
        {
            return await _database.Table<Category>().ToListAsync();
        }
        public async Task<List<Category>> GetCategoryById(int id)
        {
            return await _database.Table<Category>().Where(t => t.CategoryId == id).ToListAsync();
        }
        public async Task<List<Category>> GetCategoryByParentId(int parentId)
        {
            return await _database.Table<Category>().Where(t => t.ParentThemeId == parentId).ToListAsync();
        }

        public async Task<List<Category>> GetInactiveCategories()
        {
            return await _database.Table<Category>().Where(t => t.Status == "Inactive").ToListAsync();
        }

        public async Task<List<Category>> GetActiveCategories()
        {
            return await _database.Table<Category>().Where(t => t.Status == "Active").ToListAsync();
        }

        public async Task UpdateCategory(Category category)
        {
            await _database.UpdateAsync(category);
        }

        public Task<int> CreateCategory(Category category)
        {
            return _database.InsertAsync(category);
        }
        public async Task DeleteCategory(Category category)
        {
            await _database.DeleteAsync(category);
        }

        public async Task AddCategoryToActive(Category category)
        {
            int primKey = category.CategoryId;

            Category updatedCategory = new Category
            {
                CategoryId = primKey,
                Name = category.Name,
                Description = category.Description,
                ParentThemeId = category.ParentThemeId,
                Status = "Active",
                Days = category.Days
            };
            await UpdateCategory(updatedCategory);

            List<Goal> childGoals = await GetGoalByParentId(primKey);

            foreach (Goal goal in childGoals)
            {
                await AddGoalToActive(goal);
            }

        }

        // Goal Methods
        public Task<List<Goal>> GetGoals()
        {
            return _database.Table<Goal>().ToListAsync();
        }
        public Task<List<Goal>> GetGoalById(int id)
        {
            return _database.Table<Goal>().Where(i => i.GoalId == id).ToListAsync();
        }
        public Task<List<Goal>> GetGoalByParentId(int parentId)
        {
            return _database.Table<Goal>().Where(i => i.ParentCatId == parentId).ToListAsync();
        }

        public async Task<List<Goal>> GetActiveGoals()
        {
            return await _database.Table<Goal>().Where(t => t.Status == "Active").ToListAsync();
        }
        public async Task<List<Goal>> GetCompletedGoals()
        {
            return await _database.Table<Goal>().Where(t => t.Status == "Completed").ToListAsync();
        }
        public async Task<List<Goal>> GetInactiveGoals()
        {
            return await _database.Table<Goal>().Where(t => t.Status == "Inactive").ToListAsync();
        }

        public async Task UpdateGoal(Goal goal)
        {
            await _database.UpdateAsync(goal);
        }
        public Task<int> CreateGoal(Goal goal)
        {
            return _database.InsertAsync(goal);
        }
        public async Task DeleteGoal(Goal goal)
        {
            await _database.DeleteAsync(goal);
        }

        public async Task AddGoalToActive(Goal goal)
        {
            Goal updatedGoal = new Goal
            {
                GoalId = goal.GoalId,
                Description = goal.Description,
                ParentCatId = goal.ParentCatId,
                Status = "Active",
                Days = goal.Days,
                StartDate = DateTime.Now.ToString("M/d/yyyy")
            };
            await UpdateGoal(updatedGoal);
        }

        public async Task AddGoalToCompleted(Goal goal)
        {
            Goal updatedGoal = new Goal
            {
                GoalId = goal.GoalId,
                Description = goal.Description,
                ParentCatId = goal.ParentCatId,
                Status = "Completed",
                Days = goal.Days,
                EndDate = DateTime.Now.ToString("M/d/yyyy")
            };
            await UpdateGoal(updatedGoal);
        }

        public async Task AbandonGoal(Goal goal)
        {
            Goal updatedGoal = new Goal
            {
                GoalId = goal.GoalId,
                Description = goal.Description,
                ParentCatId = goal.ParentCatId,
                Status = "Inactive",
                Days = 0,
                StartDate = null,
                EndDate = null
            };
            await UpdateGoal(updatedGoal);
        }
    }
}

