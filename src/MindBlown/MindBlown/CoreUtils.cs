using System;
using System.Collections.Generic;

namespace MindBlown
{
    public static class CoreUtils
    {
        public static double[,] GenerateResultMatrix(
            int xMin,
            int xMax,
            double xStep,
            int timeMin,
            int timeMax,
            double timeStep)
        {
            var xValueCount = (xMax - xMin)%xStep;
            var timeValueCount = (timeMax - timeMin) % timeStep;
            var valueMatrix = new double[Convert.ToInt32(xValueCount), Convert.ToInt32(timeValueCount)];

            return valueMatrix;
        }

        public static List<List<double>> GenerateValueMatrix(
            int xMin,
            int xMax,
            double xStep,
            int timeMin,
            int timeMax,
            double timeStep)
        {
            var xValueCount = (xMax - xMin) % xStep;
            var timeValueCount = (timeMax - timeMin) % timeStep;
            
            var xValues = new List<double>();
            var lastValue = 0d;

            for (var k = 0; k < xValueCount; k++)
            {
                if (k==0)
                {
                    lastValue = xMin + xStep;
                }
                else
                {
                    lastValue = lastValue + xStep;
                }

                xValues.Add(lastValue);
            }

            var timeValues = new List<double>();

            for (var i = 0; i < timeValueCount; i++)
            {
                if (i == 0)
                {
                    lastValue = timeMin + timeStep;
                }
                else
                {
                    lastValue = lastValue + timeStep;
                }

                timeValues.Add(lastValue);
            }

            return new List<List<double>>
            {
                xValues,
                timeValues
            };
        }
    }
}