using System;
using System.Collections.Generic;
    namespace Shorting
    {
        public class Shorting
    {
        public static void Main(string[] args)
        {
           var num = new Stack<int>();
            num.Push(56);
            num.Push(30);
            num.Push(70);

            foreach (int item in num)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Peek element: " + num.Peek());
            Console.WriteLine("Pop: " + num.Pop());
            Console.WriteLine("After Pop, Peek element: " + num.Peek());

        }
    }
}
