using System;

namespace MindBlown
{
    public static class DeriveTheories
    {
        /// <summary>
        /// Returns u(x+h,t)
        /// Expression - T^2*U(x+xStep,t)+2(1-T)*U(x,t)+T^2*U(x-xStep,t)-U(x,t-timeStep)
        /// </summary>
        public static double StepAheadTimeX(
            double tau,
            double initial,
            double xStepAhead,
            double xStepBack,
            double timeStepBack)
        {
            return Math.Pow(tau, 2)*xStepAhead
                   + 2*(1 - tau)
                   *initial + Math.Pow(tau, 2)
                   *xStepBack - timeStepBack;
        }

        public static double TimeStepVirtual(
            double currentStepValue,
            double timeStep,
            double funtionValue)
        {
            return currentStepValue - 2*timeStep*funtionValue;
        }

        /// <summary>
        /// Returns point value between next and last value
        /// Example expression - u(x,t) = u(x + stepValue, t) - 2 * u(x,t) + u(x - stepValue, t)
        /// </summary>
        /// <param name="nextValue">Next value</param>
        /// <param name="currentValue">Current value</param>
        /// <param name="lastValue">Last value</param>
        /// <param name="stepValue">Step value</param>
        /// <returns></returns>
        public static double CentralDifference(
            double nextValue,
            double currentValue,
            double lastValue,
            double stepValue)
        {
            return (nextValue - 2*currentValue + lastValue)/Math.Pow(stepValue, 2);
        }

        /// <summary>
        /// Hyperbolic equatation
        /// Examlple u(x,i + timeStep) = tau^2 * u(x + xStep,t) + 2 * (1 - r^2) * u(x,t) + r^2 * u(x-xStep,t) -u(x,t - timeStep)
        /// </summary>
        /// <param name="tau"></param>
        /// <param name="xAhead"></param>
        /// <param name="current"></param>
        /// <param name="xBack"></param>
        /// <param name="timeBack"></param>
        /// <returns></returns>
        public static double HyperblolicEquatation(
            double tau,
            double xAhead,
            double current,
            double xBack,
            double timeBack)
        {
            var tauSquare = Math.Pow(tau, 2);

            return tauSquare*xAhead + 2*(1 - tauSquare)*current + tauSquare*xBack - timeBack;
        }
    }
}