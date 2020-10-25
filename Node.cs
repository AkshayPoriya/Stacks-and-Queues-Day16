// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Stack_and_Queue
{
    /// <summary>
    /// Basic building block of LinkedList
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// The data
        /// </summary>
        public T data;

        /// <summary>
        /// The next Node
        /// </summary>
        public Node<T> next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
