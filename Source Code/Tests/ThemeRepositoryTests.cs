using Microsoft.VisualStudio.TestTools.UnitTesting;
using WellnessApp;
using WellnessApp.Repositories;
using WellnessApp.Services;
using WellnessApp.Tests;


[TestClass]
public class ThemeRepositoryTests
{
    private readonly ThemeRepository _repository;
    private readonly DatabaseService _database;

    public ThemeRepositoryTests()
    {
        _repository = new ThemeRepository(SqlDatabaseSetup.TestContext);
    }

    [TestMethod]
    public async Task AddThemeAsync_ShouldAddTheme()
    {
        // Arrange
        var newTheme = new Theme { Name = "New Theme", Description = "A new test theme" };

        // Act
        await _repository.AddThemeAsync(newTheme);
        var themes = await _repository.GetAllThemesAsync();

        // Assert
        Assert.IsNotNull(themes);
        Assert.AreEqual(1, themes.Count);
        Assert.AreEqual("New Theme", themes[0].Name);
    }

    [TestMethod]
    public async Task GetAllThemesAsync_ShouldReturnAllThemes()
    {
        // Arrange: Add some test data
        await _repository.AddThemeAsync(new WellnessApp.Theme {Id = 1, Name = "Theme 1", Description = "Description 1" });
        await _repository.AddThemeAsync(new WellnessApp.Theme {Id = 2, Name = "Theme 2", Description = "Description 2" });

        // Act
        var themes = await _repository.GetAllThemesAsync();

        // Assert
        Assert.IsNotNull(themes);
        Assert.AreEqual(2, themes.Count);
    }

    [TestMethod]
    public async Task GetThemeByIdAsync_ShouldReturnCorrectTheme()
    {
        // Arrange: Add a test theme
        var theme = new WellnessApp.Theme { Id = 1,Name = "Unique Theme", Description = "Unique description" };
        await _repository.AddThemeAsync(theme);
        int themeId = theme.Id;
        // Act
        var retrievedTheme = await _database.GetThemeByIdAsync(1);

        // Assert
        Assert.IsNotNull(retrievedTheme);
        Assert.AreEqual(theme.Id, retrievedTheme.Id);
        Assert.AreEqual("Unique Theme", retrievedTheme.Name);
    }

   

    [TestMethod]
    public async Task DeleteThemeAsync_ShouldRemoveTheme()
    {
        // Arrange: Add a test theme
        var theme = new Theme { Name = "Theme to Delete", Description = "Delete this theme" };
        await _repository.AddThemeAsync(theme);

        // Act
        await _repository.DeleteThemeAsync(theme);
        var retrievedTheme = await _database.GetThemeByIdAsync(theme.Id);

        // Assert
        Assert.IsNull(retrievedTheme);
    }
}
