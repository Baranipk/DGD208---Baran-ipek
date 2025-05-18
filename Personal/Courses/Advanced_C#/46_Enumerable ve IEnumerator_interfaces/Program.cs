using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Enumerable_ve_IEnumerator_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MyList list = new MyList();
            list.Add(15);
            list.Add("merhaba");
            list.Add(12.5);


            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
    class MyEnumuretor : IEnumerator
    {

        ArrayList array;

        int index = -1;

        public MyEnumuretor(ArrayList array)
        {
            this.array = array;
        }

        public object Current => array[index];

        public bool MoveNext()
        {
            index += 2;
            return index < array.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    class MyList :IEnumerable 
    {
        ArrayList array;

        public MyList()
        {
            array = new ArrayList();
        }

        public object this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Add(object value)
        {
            array.Add(value);
        }

        public void Clear() 
        {
            array.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumuretor(array);
        }
    }
}
