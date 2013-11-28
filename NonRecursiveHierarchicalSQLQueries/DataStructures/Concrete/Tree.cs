using NonRecursiveHierarchicalSQLQueries.DataStructures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries.DataStructures.Concrete
{
    public class Tree : ITree
    {
        public INode Root { get; set; }

        #region Constructors
        public Tree()
        {
        }
        #endregion Constructors
        public void InsertNode(INode node)
        {
   
        }
    }
}
