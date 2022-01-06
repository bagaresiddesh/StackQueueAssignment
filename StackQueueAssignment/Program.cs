using System;
using System.Collections.Generic;

namespace StackQueueAssignment
{
    public class Program
    {
        static void Main()
        {
            //Creating stack of strings
            Stack<string> MyStack = new Stack<string>();

            MyStack.Push("ten");
            MyStack.Push("twenty");
            MyStack.Push("thirty");
            MyStack.Push("forty");
            MyStack.Push("fifty");

            Console.WriteLine("Items in MyStack: ");

            //Iterating the items in stack
            foreach (var item in MyStack)    
            {
                Console.WriteLine(item);
            }

            //Popping first element
            Console.WriteLine("\nPopping : {0}",MyStack.Pop());

            //Peeking the first element 
            Console.WriteLine("Peeking : {0}", MyStack.Peek());

            //Popping first element
            Console.WriteLine("Popping : {0}", MyStack.Pop());

            //Pushinging first element 
            Console.WriteLine("Pushing eighty");
            MyStack.Push("eighty");

            Console.WriteLine("\nItems in MyStack: ");
            
            //Iterating the items in stack
            foreach (var item in MyStack)
            {
                Console.WriteLine(item);
            }

            //Creating queue of strings
            Queue<string> MyQueue=new Queue<string>();

            MyQueue.Enqueue("Good Morning");
            MyQueue.Enqueue("hello");
            MyQueue.Enqueue("world");
            MyQueue.Enqueue("Siddesh");
            MyQueue.Enqueue("here");

            Console.WriteLine("\nItems in MyQueue: ");

            //Iterating the items in stack
            foreach (var item in MyQueue)
            {
                Console.WriteLine(item);
            }

            //Dequeueing first element
            Console.WriteLine("\nDequeue :{0}",MyQueue.Dequeue());

            //Peeking element
            Console.WriteLine("Peeking :{0}", MyQueue.Peek());

            //Enqueueing element
            Console.WriteLine("Enquing Bye");
            MyQueue.Enqueue("Bye");

            Console.WriteLine("\nItems in MyQueue: ");

            //Iterating the items in stack
            foreach (var item in MyQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
