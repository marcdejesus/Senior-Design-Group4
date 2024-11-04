using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading.Tasks;
using WellnessApp;

namespace WellnessApp.Tests
{
    [TestMethod]

    public class ProfilePageTests
    {
        private Mock<INavigationService> _navigationServiceMock;
        private ProfilePage _profilePage;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            _navigationServiceMock = new Mock<INavigationService>();
            _profilePage = new ProfilePage(_navigationServiceMock.Object);
        }

        [TestMethod]
        public async Task OnHomeButtonClicked_ShouldNavigateToMainPage()
        {
            await Task.Run(() => _profilePage.OnHomeButtonClicked(null, EventArgs.Empty));

            _navigationServiceMock.Verify(
                service => service.NavigateToAsync("//MainPage"),
                Times.Once,
                "The method did not navigate to the main page as expected.");
        }

        [TestMethod]
        public async Task OnSearchButtonClicked_ShouldNavigateToSearchPage()
        {
            await Task.Run(() => _profilePage.OnSearchButtonClicked(null, EventArgs.Empty));

            _navigationServiceMock.Verify(
                service => service.NavigateToAsync("//SearchPage"),
                Times.Once,
                "The method did not navigate to the search page as expected.");
        }

        [TestMethod]
        public async Task OnAddButtonClicked_ShouldNavigateToAddPage()
        {
            await Task.Run(() => _profilePage.OnAddButtonClicked(null, EventArgs.Empty));

            _navigationServiceMock.Verify(
                service => service.NavigateToAsync("//AddPage"),
                Times.Once,
                "The method did not navigate to the add page as expected.");
        }

        [TestMethod]
        public async Task OnActivityButtonClicked_ShouldNavigateToActivityPage()
        {
            await Task.Run(() => _profilePage.OnActivityButtonClicked(null, EventArgs.Empty));

            _navigationServiceMock.Verify(
                service => service.NavigateToAsync("//ActivityPage"),
                Times.Once,
                "The method did not navigate to the activity page as expected.");
        }

        [TestMethod]
        public async Task OnProfileButtonClicked_ShouldNavigateToProfilePage()
        {
            await Task.Run(() => _profilePage.OnProfileButtonClicked(null, EventArgs.Empty));

            _navigationServiceMock.Verify(
                service => service.NavigateToAsync("//ProfilePage"),
                Times.Once,
                "The method did not navigate to the profile page as expected.");
        }
    }
}
