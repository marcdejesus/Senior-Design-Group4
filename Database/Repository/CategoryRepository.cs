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
    public class CategoryRepository
    {
        private readonly DatabaseService _database;
        public CategoryRepository(DatabaseService databaseService)
        {
            _database = databaseService;
        }

        //public async Task AddCategoryToActive(Category category)
        //{
        //    int primKey = category.CategoryId;

        //    Category updatedCategory = new Category
        //    {
        //        CategoryId = primKey,
        //        Name = category.Name,
        //        Description = category.Description,
        //        ParentThemeId = category.ParentThemeId,
        //        Status = "Active",
        //        Days = category.Days
        //    };
        //    await _database.UpdateCategory(updatedCategory);

        //    List<Goal> childGoals = await _database.GetGoalByParentId(primKey);

        //    foreach (Goal goal in childGoals)
        //    {
        //        Goal updatedGoal = new Goal
        //        {
        //            GoalId = goal.GoalId,
        //            Description = goal.Description,
        //            ParentCatId = goal.ParentCatId,
        //            Status = "Active",
        //            Days = goal.Days
        //        };
        //        await _database.UpdateGoal(updatedGoal);
        //    }
        //}
    }
}
