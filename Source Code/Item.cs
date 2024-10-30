using SQLite;

namespace WellnessApp
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int ThemeId { get; set; } // Foreign key associated with a theme

    }
}