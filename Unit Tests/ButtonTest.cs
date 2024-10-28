using System;
using Xunit;
using WellnessApp;

namespace WellnessAppTest
{
    public class ButtonTest
    {
        [Fact]
        public async void SelectAll_ButtonTest()
        {
            
            ThemeRepository themeRep = new ThemeRepository();

            List<Theme> themes = await themeRep.GetThemes();

            Assert.Empty(themes);


        }
    }
}