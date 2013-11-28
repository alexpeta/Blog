using NonRecursiveHierarchicalSQLQueries.DataStructures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries.DataStructures.Concrete
{
    public class Node<T> 
        where T : INode
    {
        #region Properties
        public int LeftIndex { get; set; }
        public int RightIndex { get; set; }
        public T Value { get; private set; }
        public List<Node<T>> Children { get; private set; }
        #endregion Properties

        #region Constructors
        public Node(T nodeValue)
        {
            this.Value = nodeValue;
            Children = new List<Node<T>>();
        }
        #endregion Constructors

        #region Public Methods
        public virtual void InsertChild(Node<T> child)
        {
            Children.Add(child);
        }

        public void MarkTree(ref int index)
        {
            LeftIndex = index++;

            foreach (var child in this.Children)
            {
                child.MarkTree(ref index);
            }

            RightIndex = index;
        }

        public void Visit(Action<Node<T>> action)
        {
            action(this);
            foreach (var child in Children)
            {
                child.Visit(action);
            }
        }
        #endregion Public Methods
    }
}
