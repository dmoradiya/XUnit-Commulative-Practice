﻿using System;
using System.ComponentModel.DataAnnotations;

namespace XUnitCumulativePractice
{
    /*
        ✅Create a method in XUnitCumulativePractice.Program.cs called ValidateOneToOneHundredEven() that will accept a string (“1” or “20” etc.)  as a parameter.
        ✅Validate that the string:
        ✅Is an integer (numeric, will safely parse to int).
        ✅Is between 1 and 100.
        ✅Is even.
        ✅If it is, return true. Otherwise return false.
        Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
        This is to say, we should be testing (Theories):

     */
    public class Program
    {
        public static void Main(string[] args)
        {
            ValidateOneToOneHundredEven("1");
            ValidateOneToOneHundredEven("100");
            ValidateOneToOneHundredEven("0");
            ValidateOneToOneHundredEven("101");
            ValidateOneToOneHundredEven("50");
            ValidateOneToOneHundredEven("-2");
                                   
        }

       

        public static bool ValidateOneToOneHundredEven(string stringInput)
        {
            bool valid = false;
            try
            {
                int intInput = int.Parse(stringInput);
                if (intInput > 0 && intInput <= 100)
                {
                    if (intInput % 2 == 0)
                    {
                        Console.WriteLine("even");
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("odd");
                        valid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter any number in between 1 to 100");
                    valid = false;
                }
                return valid;
            }
            catch (System.FormatException)
            {

                return false;
            }

            
        }

    }
}
