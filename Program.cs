// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya "/>
// --------------------------------------------------------------------------------------------------------------------
namespace Stack_and_Queue
{
    using System;

    /// <summary>
    /// Contains Main Function
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            Console.WriteLine("Peak value: " + stack.Peak());
            stack.Push(56);
            stack.Traverse();
            stack.Pop();
            Console.WriteLine("Stack after pop operation: ");
            stack.Traverse();
        }
    }
}
