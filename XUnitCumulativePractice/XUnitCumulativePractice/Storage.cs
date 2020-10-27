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
        public string ItemList  { get; set; }
        Item ItemList = new Item("Apple");
        public void AddItem()
        {
            Contents.Add(ItemList);
        }
        public void RemoveItem()
        {

        }
      
	


        public Storage()
        {
            Contents = new List<Item>();
        }
    }
}
