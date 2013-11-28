using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries.DataStructures.Abstract
{
    public interface ITree
    {
        INode Root { get; set; }
        void InsertNode(INode node);
    }
}
