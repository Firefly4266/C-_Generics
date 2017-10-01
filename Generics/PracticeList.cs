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
    }
}
