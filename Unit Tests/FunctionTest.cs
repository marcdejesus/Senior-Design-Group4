using System;
using Xunit;
using SQLite;
using WellnessApp;
using Moq;
using System.Security.Cryptography;
using Autofac.Extras.Moq;

namespace WellnessAppTest
{
    public class FunctionTest 
    {

        [Fact]
        public async void SelectAll_Test()
        {
            Function fun = new Function();

            var expected = 5;
            var actual = fun.AddInts(2, 3);

            Assert.Equal(actual, expected);
        }

        private List<Theme> GetSampleThemes()
        {
            List<Theme> output = new List<Theme>
            {
                new Theme
                {
                    ThemeId = 1,
                    Name = "Fitness",
                    Description = "Fitness description"
                },
                new Theme
                {
                    ThemeId = 2,
                    Name = "Studying",
                    Description = "Studying description"
                },
                new Theme
                {
                    ThemeId = 3,
                    Name = "Languages",
                    Description = "Languages description"
                }
            };

            return output;
        }
    }
} 