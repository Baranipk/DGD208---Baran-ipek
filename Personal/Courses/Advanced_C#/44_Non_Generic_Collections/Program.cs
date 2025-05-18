using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Non_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Info
            //Collectionlar generic collections ve non-generic collections diye 2 ye ayrılır.
            // generic <> şeklinde tanımlananlardır.
            //using System.Collections; ile dahil etmeliyiz.


            /* 
             Array List
             SrtedList
             BitArray
            
             Hashtable
             Stack
             Queue
             
             */

            // boxing ve unboxing işlemi 

            //value ---> Ref / Object casting yaparsanız Boxing
            //Ref ----> value /  Unboxing.
            #endregion

            #region ArrayList
            //ArrayList array = new ArrayList() 
            //{
            //    15, 23.65, "deneme", "i" 
            //};

            //ArrayList array1 = new ArrayList()
            //{
            //    12, 3.5, "s", "a"
            //};

            ////string a =  (string)array[2];

            ////for (int i = 0; i < array.Count; i++)
            ////{
            ////    Console.WriteLine(array[i]);
            ////}

            //array.LastIndexOf(23.65); //sondan başlayarak index numarasını verir
            //array.IndexOf(23.65);  // index numarasını verir 
            //array.Contains("deneme"); // içerip içermediğini control eder
            //array.Clear(); // içini boşaltır temizler
            //array.AddRange(array1); // koleksiyonu sonuna ekler
            //array.Add("merhaba"); // içine girilen değeri sona ekler
            //array.Insert(2,"selam"); // istediğimiz indexe değer eklememizi sağlar
            //array.InsertRange(2,array1);// seçilen indexe kolleksiyonu ekler
            //array.Remove("deneme");//seçilen elemanı kaldırır
            //array.RemoveAt(2);// seçilen indexdeki elemanı kaldırır
            //array.RemoveRange(1,2);// seçilen indexdeki elemanları kaldırır
            //// array.Sort();//int32 değerlerini sıralar
            //array.Reverse();// koleksiyonu ters çevirir
            //array.ToArray();// arraye dönüştürür


            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SortedList
            //// Her eleman key ve value diye değer alır
            //// sorted list oluşturken keye atadığımız değerler aynı olmak zorunda
            //// eğer string bir key oluşturduysak listedeki her elaman o türden olması gerekmekde
            //// valuelar istediğimiz türde olabilir. ama keyler her zaman aynı türde olmak zorunda.



            //SortedList sorted = new SortedList()
            //{
            //    {"osman",45},
            //    {"mehmet",35},
            //    {"ali",12 },
            //    {"ahmet","tr" }
            //};

            //int a = (int)sorted["ali"];

            //// bir değişkene atamak için casting yapmak gerekir.

            ////metotları : 

            //sorted.Add("key", 4); // sortedliste eleman ekler
            //sorted.Contains("ahmet"); // keye göre bulunma durumunu kontrol eder.
            //sorted.ContainsValue(35); // valueya göre bulunma durumunu kontrol eder.
            //sorted.GetByIndex(0); // indexi verdiğimizde valuesunu döndürür.
            //sorted.GetKey(1); // indexi verdiğimizde bize keyini döndürüyor
            //sorted.IndexOfKey("ahmet");// indexof işlemini keye göre yapıyor
            //sorted.IndexOfValue("tr");// indexof işlemini valueya göre yapıyor
            //sorted.SetByIndex(1,"aslan");// indexe göre keyin değerini değiştirir

            //foreach (DictionaryEntry item in sorted) // DictionaryEntry yazarak değer tipini bulabiliriz 
            //                                         // yada dynamic yazarak runtimeda bulabiliriz. 
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}


            //Console.WriteLine();

            #endregion

            #region Hashtable


            //SortedList gibi key ve valuedan oluşuyor
            //key value değerlerini verirken istediğimiz türü kullanabiliriz kısıtlaması yok.
            //hashtable indexleme bulunmax indexe erişim olmaz.

            //Hashtable hashtable = new Hashtable()
            //{
            //    {"osman",25},
            //    {3.14,"pi" },
            //    {1,"bir"}
            //};

            #endregion

            #region Stack

            //LIFO last in first out mantığı ile oluşturulur
            //tabak mantığı ile örneklendirilir en üste koyulan tabak son girmesine rağmen ilk çıkar

            //Stack stack = new Stack();

            //stack.Push(65);
            //stack.Push("merhaba");
            //stack.Push(3.14);

            //Console.Write(stack.Pop());





            #endregion

            #region Queue

            //FIFO First in First out  

            //Queue queue = new Queue();
            //queue.Enqueue("selam");
            //queue.Enqueue(65);
            //queue.Enqueue(3.14);

            //// Console.WriteLine(queue.Peek());

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}



            #endregion

            #region BitArray

            byte[] a = { 5 }; // 00000101

            BitArray bit = new BitArray(a);

            Console.WriteLine(bit.Count);

            bit.Get(0); // elemanlarını almak için get metotunu kullanabilirsiniz

            for (int i = 0; i < bit.Count; i++)
            {
                Console.WriteLine(bit.Get(i));
            }


            #endregion

            Console.WriteLine();

            Console.ReadKey();
             
        }
    }
}
