using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WellnessApp.Database.Items
{
    [SQLite.Table("goal")]
    public class Goal
    {
        [PrimaryKey, AutoIncrement]
        public int GoalId { get; set; }

        public string Description { get; set; }

        public int ParentCatId { get; set; }

        public string Status { get; set; }

        public double Days { get; set; }
    }
}
