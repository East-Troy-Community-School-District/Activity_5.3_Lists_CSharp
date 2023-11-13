/// <summary>
/// Provides methods for finding the Mean, Median, and Mode
/// of a list of doubles.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianModeLists
{
    class Statistics
    {
        /// <summary>
        /// Calculates the mean of the numbers provided.
        /// </summary>
        /// <param name="list">A list of doubles.</param>
        /// <returns>The mean of the numbers.</returns>
        public static double Mean(List<double> list)
        {
            double total = 0.0;
            foreach (double number in list)
            {
                total += number;
            }
            return total / list.Count;
        }

        /// <summary>
        /// Calculates the median for the provided numbers.
        /// </summary>
        /// <param name="list">An list of doubles.</param>
        /// <returns>The median of the data set.</returns>
        public static double Median(List<double> list)
        {
            list.Sort();
            int middleIndex = list.Count / 2;
            if (list.Count % 2 == 1)
            {
                return list[middleIndex];
            }
            return (list[middleIndex] + list[middleIndex - 1]) / 2;
        }

        /// <summary>
        /// Calculates the mode of the provided data set. Will only
        /// report one of the modes if multiple are present.
        /// </summary>
        /// <param name="list">An list of doubles.</param>
        /// <returns>The mode of the numbers.</returns>
        public static double Mode(List<double> list)
        {
            int modeCount = 0;
            double mode = 0.0;
            for (int i = 0; i < list.Count; i++)
            {
                int newModeCount = 1;
                double possibleMode = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (possibleMode == list[j])
                    {
                        newModeCount++;
                    }
                }
                if (newModeCount > modeCount)
                {
                    mode = possibleMode;
                    modeCount = newModeCount;
                }
            }
            return mode;
        }
    }
}
