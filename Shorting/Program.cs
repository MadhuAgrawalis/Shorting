using System;
using System.Collections.Generic;
    namespace Shorting
    {
        public class Shorting
    {
        public static void Main(string[] args)
        {
           Queue <int> num = new Queue<int>();
            num.Enqueue(56);
            num.Enqueue(30);
            num.Enqueue(70);

            foreach (int item in num)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Peek element: " + num.Peek());
            Console.WriteLine("Dequeue: " + num.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + num.Peek());

        }
    }
}
