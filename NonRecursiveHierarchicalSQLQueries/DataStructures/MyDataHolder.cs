using NonRecursiveHierarchicalSQLQueries.DataStructures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries.DataStructures
{
    public class MyDataHolder : INode
    {
        public string Name { get; private set; }
        public MyDataHolder(string name)
        {
            Name = name;
        }
    }
}
