﻿using System;
using System.Collections.Generic;
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

     */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Storage myStorage = new Storage();
            //Item myitem1 = new Item("Pineapple");
            //Item myitem2 = new Item("Grapes");
            //Item myitem3 = new Item("Pears");
            //Item myitem4 = new Item("Peach");
            //myStorage.AddItem(myitem1);
            //myStorage.AddItem(myitem2);
            //myStorage.AddItem(myitem3);
            //myStorage.AddItem(myitem4);
            //myStorage.DisplayOutput();
            //myStorage.RemoveItem();
            //myStorage.DisplayOutput();
                                   
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
