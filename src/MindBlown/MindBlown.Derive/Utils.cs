using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MindBlown.Derive
{
    public static class DerrivativeUtils
    {
        private static readonly Regex DeriveRegex = new Regex("deriv[(](.*?)[)]");
        private static readonly Regex MethodRegex = new Regex("[(](.*?)[)]");

        public static void Transform(string expressionString)
        {
            var derivatives = FindDerrivatives(expressionString);
        }

        public static IEnumerable<DerrivativeExpression> FindDerrivatives(string expression)
        {
            var matches = DeriveRegex.Matches(expression);
            var derivatives = new List<DerrivativeExpression>();
            foreach (var match in matches)
            {
                var paramMatch = MethodRegex.Match(match.ToString());
                var parameterString = paramMatch.ToString();
                var parameters = ExtractParameters(parameterString);
                derivatives.Add(new DerrivativeExpression(
                    parameters[0],
                    parameters[1],
                    Convert.ToInt32(parameters[2])));
            }

            return derivatives;
        }

        private static string[] ExtractParameters(string methodExpression)
        {
            methodExpression = methodExpression.Replace("(", "");
            methodExpression = methodExpression.Replace(")", "");
            return methodExpression.Split(',');
        }
    }
}