﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitCumulativePractice
{
    /*
        ✅Create a class called “Item” with the following properties:
            ✅“Name” (string).
            ✅A default and greedy constructor.

     */
    public class Item
    {
        public string Name { get; set; }


        public Item()
        {

        }
        public Item(string name)
        {
            Name = name;
        }
    }
}
