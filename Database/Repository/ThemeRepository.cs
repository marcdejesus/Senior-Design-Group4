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
            await _database.Update(theme);
        }
        public async Task Delete(Theme theme)
        {
            await _database.Delete(theme);
        }
    }
}
