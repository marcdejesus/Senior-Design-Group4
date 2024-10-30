using SQLite;

namespace WellnessApp
{
    public class Theme
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // Unique identifier for each theme

        public string Name { get; set; } // Name of the theme

        public string Description { get; set; } // Description of the theme

        
    }
}
