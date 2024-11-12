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
    public class GoalRepository
    {
        private readonly DatabaseService _database;
        public GoalRepository(DatabaseService databaseService)
        {
            _database = databaseService;
        }

        // Get goals for category
        public async Task<List<Goal>> GetGoalsForTheme(int id)
        {
            return await _database.GetGoalById(id);
        }
    }
}
