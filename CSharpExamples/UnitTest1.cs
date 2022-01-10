using Xunit;

namespace CSharpExamples
{
    public class UnitTest1
    {
        [Fact] // "Attributes"
        public void CanAddTenAnd20()
        {
            // Given
            int a = 10, b = 20, answer;
            // When
            answer = a + b; // SUT
            // Then
            Assert.Equal(30, answer);

        }

        [Theory]
        [InlineData(2,3,5)]
        [InlineData(10,2,12)]
        [InlineData(20,10,30)]
        public void CanAddOtherNumbers(int a, int b, int expected)
        {
            int answer = a + b;

            Assert.Equal(expected, answer);
        }


    }
}