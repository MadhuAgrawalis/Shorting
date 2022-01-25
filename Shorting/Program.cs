using System;

namespace Shorting
{
    using System;


    public class StackUsingLinkedlist
    {


        private class Node
        {

            public int data;


            public Node link;
        }


        Node top;
        public StackUsingLinkedlist()
        {
            this.top = null;
        }


        public void push(int x)
        {

            Node temp = new Node();


            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }


            temp.data = x;


            temp.link = top;


            top = temp;
        }


        public bool isEmpty()
        {
            return top == null;
        }


        public int peek()
        {

            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }


        public void pop()
        {

            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }


            top = (top).link;
        }

        public void display()
        {

            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {


                    Console.Write("{0}->", temp.data);


                    temp = temp.link;
                }
            }
        }
    }


    public class GFG
    {
        public static void Main(String[] args)
        {

            StackUsingLinkedlist obj = new StackUsingLinkedlist();


            obj.push(70);
            obj.push(30);
            obj.push(56);



            obj.display();


            Console.Write("\nTop element is {0}\n", obj.peek());


            obj.pop();
            obj.pop();


            obj.display();


            Console.Write("\nTop element is {0}\n", obj.peek());
        }
    }
}
 