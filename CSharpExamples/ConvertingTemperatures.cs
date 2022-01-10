using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Xunit;

namespace CSharpExamples
{
    public class ConvertingTemperatures
    {
        [Theory]
        [InlineData(212, 100.01F)]
        [InlineData(32, 0)]
        [InlineData(98, 36.67F)]
        public void CanConvertFromFToC(float tempInF, float expected)
        {
            // given
            // create an instance of the class
            var converter = new TemperatureConverter();

            // when
            float tempInC = converter.ConvertToC(tempInF);

            // then
           Assert.Equal<float>(expected, tempInC);
        }
    }
}
