using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //creat a generic class
    public class PracticeList<T>
    {
        //create an array of generic type "T"
        private T[] items;

        //add a constructor to our generic class
        public PracticeList()
        {
            items = new T[0];
        }
        //add a get method to our generic class. Notice "GetItem" is of type "T" (generic type) and takes "int" index as an input parameter because an array index is of integer type.
        public T GetItem(int index)
        {
            return items[index];
        }
        //create an "Add" method that actually creates a larger array.
        public void Add(T newItem)
        {
            //The new array will have the size of the original plus 1.
            T[] newItems = new T[items.Length + 1];

            //use a for loop to iterate through the original array assigning it's values to the new array.
            for (int i = 0; i < items.Length; i++)
            {
                //assign the items from the original array to the new array
                newItems[i] = items[i];

                //add new item to the expanded array (which has a defined length of length + 1).  So length - 1 is the last position in the array and where we will store our new item. 
                newItems[newItems.Length - 1] = newItem;

                //assign the new array to the old array variable to keep the existing code intact.
                items = newItems;
            }
        }
    }
}
