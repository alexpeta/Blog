using NonRecursiveHierarchicalSQLQueries.DataStructures.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries.DataStructures
{
    public class SimpleTreeNode : Node<MyDataHolder>
    {
        public SimpleTreeNode(MyDataHolder value) 
            : base(value)
        {
        }
    }
}
