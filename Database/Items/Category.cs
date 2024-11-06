using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WellnessApp.Database.Items
{
    [SQLite.Table("category")]
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ParentTheme { get; set; }
    }
}
