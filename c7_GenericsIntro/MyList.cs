using System;
using System.Collections.Generic;
using System.Text;

namespace c7_GenericsIntro
{
    class MyList<T>
    {
        T[] items; // needs to be created when an object of MyList created.

        // constructor
        public MyList() 
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // copy "items"
            items = new T[items.Length + 1];
            // get old elements:
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            // add new element:
            items[items.Length - 1] = item;
        }
    }
}
