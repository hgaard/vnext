using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NemSigner.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class SampleTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }
        
        [Fact]
        public void CallMyCalssTest()
        {
            var hello = NemSigner.Class1.Hello();
            Assert.Equal(hello,"Hello");
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}


