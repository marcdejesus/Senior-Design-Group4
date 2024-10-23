using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessApp
{
    public class ThemeRepository
    {
        private const string DB_NAME = "local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public ThemeRepository()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Theme>();
        }

        public async Task<List<Theme>> GetThemes()
        {
            return await _connection.Table<Theme>().ToListAsync();
        }

        public async Task<Theme> GetByThemeId(int id)
        {
             return await _connection.Table<Theme>().Where(x => x.ThemeId == id).FirstOrDefaultAsync();
        }

        public async Task Create(Theme theme)
        {
            await _connection.InsertAsync(theme); 
        }

        public async Task Update(Theme theme)
        {
            await _connection.UpdateAsync(theme);
        }
        public async Task Delete(Theme theme)
        {
            await _connection.DeleteAsync(theme);
        }
    }
}
