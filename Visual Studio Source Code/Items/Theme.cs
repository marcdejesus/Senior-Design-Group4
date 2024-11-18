﻿using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessApp.Items
{
    [Table("theme")]
    public class Theme
    {
        [PrimaryKey, AutoIncrement]
        public int ThemeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public double Days { get; set; }

    }
}
