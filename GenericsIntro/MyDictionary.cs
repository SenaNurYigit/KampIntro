using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<T>
    {
        T[] keys;
        T[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values= new T[0];

        }

        public void Add(T item)
        {
            T[] tempArray = keys;
            keys=new T[keys.Length+1];

            T[] tempArray2 = values;
            values=new T[values.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = tempArray[i];
            }
            keys[keys.Length-1] = item;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = tempArray2[i];
            }
            values[values.Length - 1] = item;
        }

    }
}
