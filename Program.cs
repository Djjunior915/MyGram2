using System;

using MyGram.MyClasses;


namespace MyGram
{
    class Program
    {
        static void Main()
        {
            CommentsDTO comment = new CommentsDTO();
            comment.TheComment = "This is a comment";


            Console.WriteLine("The value of my first property is: " + comment.TheComment);
            
        }
    }
}
