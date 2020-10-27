using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests
    {
        /*
            ?Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
            This is to say, we should be testing (Theories):

         */

        // Test for Valid Integer
        [Theory]
        [InlineData("2",true)]
        [InlineData("hi",false)]
        [InlineData("2hi",false)]
        [InlineData("2-1",false)]
        public void ValidateOneToOneHundredEven_Test(string input, bool expected)
        {
            // Arrange 
            bool output;

            // Act 
            output = Program.ValidateOneToOneHundredEven(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }
    }
}
