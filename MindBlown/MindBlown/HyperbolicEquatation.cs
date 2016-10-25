namespace MindBlown
{
    public static class HyperbolicEquatation
    {
        public static bool IsStable(
            double constantValue,
            double timeStep,
            double xStep)
        {
            return timeStep < xStep / constantValue;
        }

        public static double Tau(
            double constantValue,
            double timeStep,
            double xStep)
        {
            return constantValue * timeStep / xStep;
        }
    }
}