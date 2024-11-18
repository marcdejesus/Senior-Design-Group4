using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellnessApp.Items;

namespace WellnessApp
{
    public class Function
    {
        //public int AddInts(int x, int y)
        //{
        //    return x + y;
        //}

        public string GetCategoryBreakDown(List<Category> categories) 
        {
            string result = "The goal categories you have selected to pursue are ";

            int totalLength = categories.Count;
            int fitnessCount = 0;
            int instrumentCount = 0;
            int studyingCount = 0;
            int languageCount = 0;
            int wellnessCount = 0;

            //foreach (var category in categories) 
            //{
            //    if (category.ParentTheme == "Fitness") fitnessCount++;
            //    else if (category.ParentTheme == "Studying") studyingCount++;
            //    else if (category.ParentTheme == "Instrument") instrumentCount++;
            //    else if (category.ParentTheme == "Language") languageCount++;
            //    else if (category.ParentTheme == "Wellness") wellnessCount++;
            //    else continue;
            //}

            if (fitnessCount > 0) result += CategoryQuantifier(fitnessCount, totalLength) + "Fitness, ";

            if (instrumentCount > 0) result += CategoryQuantifier(instrumentCount, totalLength) + "Instrument, ";

            if (studyingCount > 0) result += CategoryQuantifier(studyingCount, totalLength) + "Studying, ";

            if (wellnessCount > 0) result += CategoryQuantifier(wellnessCount, totalLength) + "Wellness, ";

            if (languageCount > 0) result += "and " + CategoryQuantifier(languageCount, totalLength) + "Language.";

            return result;
        }

        public string CategoryQuantifier(int count, int total)
        {
            string result = "";
            double percent = Convert.ToDouble(count) / Convert.ToDouble(total);

            if (percent >= 0.5) result = "mostly ";
            else if (percent >= 0.33) result = "some ";
            else if (count == 1) result = "one ";
            else result = "a few ";

            return result;
        }
    }
}
