using System;

using MyGram.MyClasses;


namespace MyGram
{
    class Program
    {
        static void Main()
        {
            DateTime myFirstDateVariable = new DateTime(2021, 6, 10);
            DateTime mySecondDateVariable = new DateTime(2010, 6, 10);

            int result = DateTime.Compare(myFirstDateVariable, mySecondDateVariable);

            //1 = First date is greater than the secomd
            //0 = Means the two dates are equal
            //-1 = First date is not greater than the second

            if (result == 1)
            {
                Console.WriteLine("First date is greater");
            } else
            {
                Console.WriteLine("Second date is greater");

            }
        }
    }
}
