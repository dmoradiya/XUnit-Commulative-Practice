using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitCumulativePractice
{
    /*
         ✅Create a class called “Storage” with the following properties and methods:
            ✅“Contents” (list of Items).
            ✅AddItem() will accept an item and add it to the “Contents” list.
            ✅RemoveItem() will remove the most recent addition to the “Contents” list.
            ✅A default constructor.

     */
    public class Storage
    {
        public List<Item> Contents { get; set; }
        
        public void AddItem(Item item)
        {
            Contents.Add(item);
        }
        public void RemoveItem()
        {
            Contents.RemoveAt(Contents.Count-1);
        }

        public void DisplayOutput()
        {
            foreach (Item items in Contents)
            {
                Console.WriteLine(items.Name);
            }
        }

        public Storage()
        {
            Contents = new List<Item>();
        }
    }
}
