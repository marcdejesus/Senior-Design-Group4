using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WellnessApp
{
    [SQLite.Table("category")]
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ParentThemeId { get; set; }

        public string Status { get; set; }

        public double Days { get; set; }
    }
}
