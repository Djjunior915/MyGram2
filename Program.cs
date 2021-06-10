using System;
using System.Collections.Generic;
using MyGram.MyClasses;


namespace MyGram
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("The values of the array of the following:");
            foreach(var item in myArray)
            {
                Console.Write(item + ", ");
            }

            List<string> myList = new List<string>();
            myList.Add("Value1");
            myList.Add("Value2");
            myList.Add("Value3");
            myList.Add("Value4");
            myList.Add("Value5");
            myList.Add("Value6");
            myList.Add("Value7");
            myList.Add("Value8");
            myList.Add("Value9");
            myList.Add("Value10");

            Console.WriteLine("");
            Console.WriteLine("The values of the list of the following:");
            foreach (var item in myList)
            {
                Console.Write(item + ", ");
            }

        }
    }
}
