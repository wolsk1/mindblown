using System;

namespace MindBlown
{
    public class DerivedExpression : IDerivedExpression
    {
        private double[] valueParams;

        public DerivedExpression(MathExpression expression, params double[] valueParams)
        {
            this.valueParams = valueParams;
            Expression = expression;
        }

        public int DeriveLevel { get; set; }

        public MathExpression Expression { get; set; }
    }
}