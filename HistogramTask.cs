using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new string[31];
            int count = 1;
            for (int i = 0; i < days.Length;i++)
            {
                days[i] = count.ToString();
                count++;
            }
            var birthCounts = new double[31];
           
            foreach (var namet in names)
            {
                if(name == namet.Name)
                {
                    if (namet.BirthDate.Day == 1) continue;
                    birthCounts[namet.BirthDate.Day-1]++;
                }
            }

            return new HistogramData(name, days, birthCounts);



            //return new HistogramData(
            //    string.Format("Рождаемость людей с именем '{0}'", name), 
            //    new string[0], 
            //    new double[0]);
        }
    }
}