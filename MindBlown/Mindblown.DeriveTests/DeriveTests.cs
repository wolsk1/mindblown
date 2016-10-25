using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBlown.Derive;
using Xunit;

namespace Mindblown.DeriveTests
{
    [Trait("Owner","Imants Volkovs")]
    public class DeriveTests
    {
        private const string DerrivativeString = "deriv(u,t,2)-const(c)^const(2)*deriv(u,x,2)=const(0)";

        [Fact]
        public void Should_be_able_to_find_derivatives_from_string()
        {
            var variables = DerrivativeUtils.FindDerrivatives(DerrivativeString);
        }
    }
}
