using Stack.Model;
using System;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack<int> simpleStack = new SimpleStack<int>();
            simpleStack.Push(5);
            simpleStack.Push(3);
            simpleStack.Push(1);

            Console.WriteLine(simpleStack.Pop());
            Console.WriteLine(simpleStack.Peek());
            Console.WriteLine(simpleStack);
            Console.WriteLine();

            Console.ReadKey();
            Console.WriteLine();

            LinkedStack<int> linkedStack = new LinkedStack<int>(5);
            linkedStack.Push(3);
            linkedStack.Push(1);

            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack);

            Console.ReadKey();
            Console.WriteLine();

            ArrayStack<string> arrayStack = new ArrayStack<string>("Test1",10);
            arrayStack.Push("Test2");
            arrayStack.Push("Test3");
            arrayStack.Push("Test4");
            arrayStack.Push("Test5");
            arrayStack.Push("Test6");
            arrayStack.Push("Test7");
            arrayStack.Push("Test8");
            arrayStack.Push("Test9");
            arrayStack.Push("Test10");
            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack);

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
