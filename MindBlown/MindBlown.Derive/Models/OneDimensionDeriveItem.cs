using System;

namespace MindBlown.Derive.Models
{
    public struct OneDimensionDeriveItem
    {
        private int elementCount;

        public OneDimensionDeriveItem(int initialValue, double stepValue, int valueAmplitude, string variableName, MathExpression expression)
        {
            InitialValue = initialValue;
            StepValue = stepValue;
            Expression = expression;
            elementCount = valueAmplitude * 2;
            VariableName = variableName;
        }

        public double InitialValue { get; }

        public double StepValue { get; }

        public string VariableName { get; }

        public MathExpression Expression { get; set; }

        public double GetStepValue(int elementIndex)
        {
            var elementValue = -1;
            Expression.SetVariableValue(VariableName, elementValue);
            throw new NotImplementedException();
        }
    }
}