using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T> //generic class
    {
        T[] items;
        T[] tempArray;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //T[] tempArray = items;
            tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //eklenmek istenen eleman ekleniyor
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
