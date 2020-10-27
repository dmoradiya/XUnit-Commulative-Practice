using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests
    {
        /*
            ✅Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
            This is to say, we should be testing (Theories):

         */

        //###################### Test Data for Valid Integer ###################
        [Theory]
        [InlineData("2",true)]
        [InlineData("hi",false)]
        [InlineData("2hi",false)]
        [InlineData("2-1",false)]
        [InlineData("$21",false)]

        //###################### Test Data for Valid Integer In Between 0 - 100 ############################
        [InlineData("-1", false)]
        [InlineData("0", false)]
        [InlineData("1", false)]
        [InlineData("50", true)]
        [InlineData("99", false)]
        [InlineData("100", true)]
        [InlineData("101", false)]

        //###################### Test Data for Valid Integer In Between 0 - 100 And Even ############################
        [InlineData("10", true)]
        [InlineData("40", true)]
        [InlineData("90", true)]
        [InlineData("25", false)]
        [InlineData("97", false)]
        
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
