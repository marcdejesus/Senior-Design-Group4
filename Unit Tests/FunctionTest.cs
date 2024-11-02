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
        public void GetCategoryBreakdown_Test()
        {
            // Arrange
            List<Category> categories = GetSampleCategories();

            // Act
            Function function = new Function();
            string actual = function.GetCategoryBreakDown(categories);

            //Assert
            string expected = "The goal categories you have selected to pursue are some Fitness, some Instrument, a few Studying, and one Language.";

            Assert.NotNull(actual);
            Assert.Equal(expected, actual);

        }

        //[Fact]
        //public async void AddInts_Test()
        //{
        //    Function fun = new Function();

        //    var expected = 5;
        //    var actual = fun.AddInts(2, 3);

        //    Assert.Equal(actual, expected);
        //}

        private List<Category> GetSampleCategories()
        {
            List<Category> output = new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    Name = "Strength Training",
                    Description = "description",
                    ParentTheme = "Fitness"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Flexibility and Mobility",
                    Description = "description",
                    ParentTheme = "Fitness"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Endurance and Stamina",
                    Description = "description",
                    ParentTheme = "Fitness"
                },

                new Category
                {
                    CategoryId = 4,
                    Name = "Practice and Routine",
                    Description = "description",
                    ParentTheme = "Instrument"
                },
                new Category
                {
                    CategoryId = 5,
                    Name = "Composition and Creativity",
                    Description = "description",
                    ParentTheme = "Instrument"
                },
                new Category
                {
                    CategoryId = 6,
                    Name = "Technique and Fundamentals",
                    Description = "description",
                    ParentTheme = "Instrument"
                },

                new Category
                {
                    CategoryId = 7,
                    Name = "Science and Math",
                    Description = "description",
                    ParentTheme = "Studying"
                },
                new Category
                {
                    CategoryId = 8,
                    Name = "Listening and Speaking",
                    Description = "description",
                    ParentTheme = "Studying"
                },

                new Category
                {
                    CategoryId = 9,
                    Name = "Technique and Fundamentals",
                    Description = "description",
                    ParentTheme = "Language"
                }
            };

            return output;
        }
    }
} 