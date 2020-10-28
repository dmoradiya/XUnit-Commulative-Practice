using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    /*
        ✅Add a tests file to the XUnit project called Storage_Tests.cs.
            ✅Test the addition of items (Fact):
            ✅(Arrange) Create an Item named “TestItem” and an empty Storage. 
            ✅(Act) Add the Item to the Storage using the AddItem() method.
            (Assert) Assert that the list has a count of 1
            ✅(Assert) Assert that the item in Storage.Contents is “TestItem”.
            ✅Test the removal of items (Fact):	
            (Arrange) Create a Storage prepopulated with 5 Items. 
            (Arrange) Create an object reference variable to the last item in the Contents list.
            (Act) Run RemoveItem() on the Storage. 
            (Assert) Assert that the count of the Contents has dropped by 1 (is 4)
            (Assert) Assert that the object reference is no longer in the list.

     */
    public class Storage_Tests
    {
        [Fact]
        public void Addition()
        {
            // Arrange
            Item testItem = new Item("Banana");
            Storage testStorage = new Storage();

            // Act
            testStorage.AddItem(testItem);

            // Assert
            //Assert.Equal(1,testStorage.Contents.Count);
            // Assert
            Assert.Contains(testItem, testStorage.Contents);
        }



    }
}
