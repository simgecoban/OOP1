using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary <K,V>
    {
        K[] keys;
        K[] tempKeysArray;
        V[] values;
        V[] tempValuesArray;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }

        public void Add(K key,V value)
        {
            tempKeysArray = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i <tempKeysArray.Length; i++)
            {
               keys[i] = tempKeysArray[i];

            }
            keys[keys.Length - 1] = key;

            tempValuesArray = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < tempValuesArray.Length; i++)
            {
                values[i] = tempValuesArray[i];
            }

            values[values.Length - 1] = value;




        }

        public int kLength
        {
            get { return keys.Length; }
        }

        public K[] key
        {
            get { return keys; }
        }

        public int vLength
        {
            get { return values.Length; }
        }

        public V[] value
        {
            get { return values; }
        }

    }
}
