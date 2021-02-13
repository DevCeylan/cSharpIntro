using System;
using System.Collections.Generic;
using System.Text;

namespace c7_GenericsPractice
{
    class MyDictionary<T, U>
    {
        T[] keys;
        U[] values;

        // constructor
        public MyDictionary()
        {
            // Arrays are initialized empty
            keys = new T[0];
            values = new U[0];
        }

        public void Add(T key, U value)
        {
            // Keeping previous values
            T[] tempKey = keys;
            U[] tempValue = values;

            // Recreate by increasing capacities by 1
            keys = new T[keys.Length + 1];
            values = new U[values.Length + 1];

            // Copy previous
            for (int i = 0; i < tempValue.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            // Add new key-value at last index
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

    }
}
