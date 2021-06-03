using System;

using MyGram.MyClasses;


namespace MyGram
{
    class Program
    {
        static void Main()
        {
            DateTime myDateTimeVariable = new DateTime(2021,6,3);
            DateTime myDateTimeVariable2 = DateTime.Now;

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            Console.WriteLine(result);
        }
    }
}
