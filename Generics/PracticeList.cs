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
    }
}
