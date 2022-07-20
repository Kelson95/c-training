using System.Collections;
using System.Collections.Generic;

namespace Lesson_23_Colections_Queue_and_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //uszeregowany zbior 1,2,3,4,5,6,7... 
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(9);
            Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());    //out of queue
            Console.WriteLine(queue.Peek());


            Console.WriteLine("             ");
            Console.WriteLine("----------------");
            Console.WriteLine("            ");

            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(6);
            stack.Push(11);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            stack.Push(9);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());


            Console.ReadKey();
        }
    }
}