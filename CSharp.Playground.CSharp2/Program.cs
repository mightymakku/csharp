namespace CSharp.Playground.CSharp2
{
    using System;
    using Generics;

    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantiating new GenericValueStack...");
            GenericValueTypeStack<double> stack = new GenericValueTypeStack<double>(3);

            Console.WriteLine("Pushing value \"3.14\"");
            stack.Push(3.14);

            Console.WriteLine("Pushing value \"42\"");
            stack.Push(42);

            Console.WriteLine("Popping value...");
            Console.WriteLine(string.Format("Popped value \"{0}\".", stack.Pop()));

            Console.WriteLine("Popping value...");
            Console.WriteLine(string.Format("Popped value \"{0}\".", stack.Pop()));

            Console.ReadKey();
        }
    }
}
