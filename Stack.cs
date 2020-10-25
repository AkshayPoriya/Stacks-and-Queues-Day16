// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya "/>
// --------------------------------------------------------------------------------------------------------------------
namespace Stack_and_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementation of stack data structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Stack<T> where T:IComparable
    {
        /// <summary>
        /// The linked list
        /// </summary>
        LinkedList<T> linkedList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack{T}"/> class.
        /// </summary>
        public Stack()
        {
            linkedList = new LinkedList<T>();
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(T data)
        {
            linkedList.PushFront(data);
        }

        /// <summary>
        /// Traverses this instance.
        /// </summary>
        public void Traverse()
        {
            linkedList.Traverse();
        }
    }
}
