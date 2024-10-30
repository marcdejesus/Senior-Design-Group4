using Microsoft.VisualStudio.TestTools.UnitTesting;
using WellnessApp;
using WellnessApp.Repositories;
using WellnessApp.Tests;

[TestClass]
public class ItemRepositoryTests
{
    private readonly ItemRepository _repository;

    public ItemRepositoryTests()
    {
        _repository = new ItemRepository(SqlDatabaseSetup.TestContext);
    }

    [TestMethod]
    public async Task AddItemAsync_ShouldAddItem()
    {
        // Arrange
        var newItem = new Item { Name = "New Item", ThemeId = 1 };

        // Act
        await _repository.AddItemAsync(newItem);
        var items = await _repository.GetItemsForThemeAsync(newItem.ThemeId);

        // Assert
        Assert.IsNotNull(items);
        Assert.AreEqual(1, items.Count);
        Assert.AreEqual("New Item", items[0].Name);
    }

    // Additional tests for ItemRepository...
}
