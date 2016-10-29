using System;
using MindBlown;

namespace Console
{
    internal class Program
    {
        private const string DerrivativeString = "deriv(u,t,2)-const(c)^const(2)*deriv(u,x,2)=const(0)";

        static void Main(string[] args)
        {
            //var derivatives = DerrivativeUtils.FindDerrivatives(DerrivativeString);

            var constant = 7;
            var xValue = 1;
            var fx = Math.Cos(3*xValue);
            var gx = xValue;

            var timeStep = 0.1;
            var xStep = 0.01;

            var xMinValue = 0;
            var xMaxValue = 1;
            var timeMinValue = 0;
            var timeMaxValue = 0;

            //TODO get tau that is stable
            var tau = HyperbolicEquatation.Tau(constant, timeStep, xStep);
            var isStable = HyperbolicEquatation.IsStable(constant, timeStep, xStep);
            var valueMatrix = CoreUtils.GenerateValueMatrix(
                xMinValue,
                xMaxValue,
                xStep,
                timeMinValue,
                timeMaxValue,
                timeStep);
            var resultMatrix = CoreUtils.GenerateResultMatrix(
                xMinValue,
                xMaxValue,
                xStep,
                timeMinValue,
                timeMaxValue,
                timeStep);

            //RESULT will be matrix between 0 and some other number
            //Point count will be determined by step values
        }
    }
}
