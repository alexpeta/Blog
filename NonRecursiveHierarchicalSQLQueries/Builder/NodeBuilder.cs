using NonRecursiveHierarchicalSQLQueries.DataStructures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries.Builder
{
    public class NodeBuilder<T> 
        where T : INode
    {

        //private List<>

        public NodeBuilder<T> Instance 
        {
            get
            {
                return new NodeBuilder<T>();
            }
        }
        private NodeBuilder()
        {
        }

        public NodeBuilder<T> WithChild(T childValue)
        {
            return this;
        }

    }
}
