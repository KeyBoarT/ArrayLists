using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before getting started we must add System.Collections namespace to our program, else program will returns an error
            //Unlike lists and Arrays, ArrayLists do not have to have a specific type, ArrayLists may take many types at the same time
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Veni");
            arrayList.Add("Vici");
            arrayList.Add(12);
            //Thus, you learned how to add values in ArrayList's

            //Adding multiple values to ArraList
            //Howewer, in this way you can add just one type at the same time
            arrayList.AddRange(new string[] { "New York", "Los Santos", "Hollywood" });

            //Reaching to members of ArrayList
            foreach(var item in arrayList) { Console.WriteLine(item); }

            //Reaching to member of ArrayLits by index
            Console.WriteLine(arrayList[1]);

            //Let's sort ArrayList's
            int[] numbersArray = new int[] { 12, 14, 16, 24, 24, 1, -1 };
            ArrayList numberArrayList = new ArrayList(numbersArray);
            //You should know that the 'Sort' method works if all member types are integers, else it don't work
            numberArrayList.Sort();
            foreach (var item in numberArrayList) { Console.WriteLine(item); }

            //Binary Search in ArrayLists
            int indexOf12 = numberArrayList.BinarySearch(12);
            Console.WriteLine(indexOf12);
            //It writes '2' because we sorted 'numberArrayList' above, don't forget

            //Reversing ArrayLists
            numberArrayList.Reverse();
            foreach(var item in numberArrayList) { Console.WriteLine(item); }
            //As you can see it has been reversed

            //Clearing ArrayLists
            numberArrayList.Clear();
            Console.ReadKey();
        }
    }
}
