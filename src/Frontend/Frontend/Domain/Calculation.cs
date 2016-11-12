using System;
using System.Collections.Generic;
using MindBlown;

namespace Frontend.Domain
{
    public class Calculation
    {
        public double Constant { get; set; }
        public double XValue { get; set; }

        public double FxValue { get; set; }
        public double GxValue { get; set; }

        public double TimeStep { get; set; }
        public double XStep { get; set; }
        public double Tau { get; set; }
        public bool IsStable { get; set; }

        public double XMinValue { get; set; }
        public double XMaxValue { get; set; }
        public double TimeMinValue { get; set; }
        public double TimeMaxValue { get; set; }

        public List<List<double>> ValueMatrix { get; set; }
        public List<List<double>> ResultMatrix { get; set; }

        public void Calculate()
        {
            Constant = 7;
            XValue = 1;
            FxValue = Math.Cos(3 * XValue);
            GxValue = XValue;

            TimeStep = 0.1;
            XStep = 0.01;

            XMinValue = 0;
            XMaxValue = 1;
            TimeMinValue = 0;
            TimeMaxValue = 1;
            
            Tau = HyperbolicEquatation.Tau(Constant, TimeStep, XStep);
            IsStable = HyperbolicEquatation.IsStable(Constant, TimeStep, XStep);
            //TODO matrix is not filled
            ValueMatrix = CoreUtils.GenerateValueMatrix(
                XMinValue,
                XMaxValue,
                XStep,
                TimeMinValue,
                TimeMaxValue,
                TimeStep);
            ResultMatrix = CoreUtils.GenerateResultMatrix();
            //ResultMatrix = CoreUtils.GenerateResultMatrix(
            //    XMinValue,
            //    XMaxValue,
            //    XStep,
            //    TimeMinValue,
            //    TimeMaxValue,
            //    TimeStep);
        }
    }
}