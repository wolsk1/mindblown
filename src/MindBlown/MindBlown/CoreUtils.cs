using System;
using System.Collections.Generic;

namespace MindBlown
{
    public static class CoreUtils
    {
        public static List<List<double>> GenerateResultMatrix()
            //double xMin,
            //double xMax,
            //double xStep,
            //double timeMin,
            //double timeMax,
            //double timeStep)
        {
            //var xValueCount = (xMax - xMin)%xStep;
            //var timeValueCount = (timeMax - timeMin) % timeStep;
            //var valueMatrix = new double[Convert.ToInt32(xValueCount), Convert.ToInt32(timeValueCount)];
            var valueMatrix = new List<List<double>>();

            return valueMatrix;
        }

        public static List<List<double>> GenerateValueMatrix(
            double xMin,
            double xMax,
            double xStep,
            double timeMin,
            double timeMax,
            double timeStep)
        {
            var xValueCount = (xMax - xMin) % xStep;
            var timeValueCount = (timeMax - timeMin) % timeStep;
            
            var xValues = new List<double> {xMin};
            var lastValue =  xMin;

            do
            {
                lastValue = lastValue + xStep;
                xValues.Add(lastValue);
            } while (lastValue < xMax);

            lastValue = timeMin;
            var timeValues = new List<double> { timeMin };
            do
            {
                lastValue = lastValue + timeStep;
                timeValues.Add(lastValue);
            } while (lastValue < timeMax);

            //for (var k = 0d; k < xValueCount; k = k + xStep)
            //{
            //    if (k==0)
            //    {
            //        lastValue = xMin + xStep;
            //    }
            //    else
            //    {
            //        lastValue = lastValue + xStep;
            //    }

            //    xValues.Add(lastValue);
            //}

            

            //for (var i = 0d; i < timeValueCount; i = i + timeStep)
            //{
            //    if (i == 0)
            //    {
            //        lastValue = timeMin + timeStep;
            //    }
            //    else
            //    {
            //        lastValue = lastValue + timeStep;
            //    }

            //    timeValues.Add(lastValue);
            //}

            return new List<List<double>>
            {
                xValues,
                timeValues
            };
        }
    }
}