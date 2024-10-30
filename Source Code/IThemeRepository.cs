using WellnessApp;

public interface IThemeRepository
{
    Task<Theme> GetThemeByIdAsync(int id);
    // Other method signatures
}
