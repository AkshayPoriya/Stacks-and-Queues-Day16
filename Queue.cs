// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Stack_and_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Queue<T> where T:IComparable
    {
        /// <summary>
        /// The linked list
        /// </summary>
        LinkedList<T> linkedList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// </summary>
        public Queue()
        {
            this.linkedList = new LinkedList<T>();
        }

        /// <summary>
        /// Enqueus the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueu(T data)
        {
            linkedList.PushBack(data);
        }

        /// <summary>
        /// Traverses this instance.
        /// </summary>
        public void Traverse()
        {
            this.linkedList.Traverse();
        }

        /// <summary>
        /// Dequeus this instance.
        /// </summary>
        public void Dequeu()
        {
            linkedList.PopFront();
        }
    }
}
