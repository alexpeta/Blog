using NonRecursiveHierarchicalSQLQueries.DataStructures;
using NonRecursiveHierarchicalSQLQueries.DataStructures.Abstract;
using NonRecursiveHierarchicalSQLQueries.DataStructures.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursiveHierarchicalSQLQueries
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating the tree
            SimpleTreeNode root = new SimpleTreeNode(new MyDataHolder("Basket"));

            SimpleTreeNode fruitsNode = new SimpleTreeNode(new MyDataHolder("Fruits"));
            SimpleTreeNode appleNode = new SimpleTreeNode(new MyDataHolder("Apple"));
            SimpleTreeNode cherryNode = new SimpleTreeNode(new MyDataHolder("Cherry"));
            SimpleTreeNode bananaNode = new SimpleTreeNode(new MyDataHolder("Banana"));

            fruitsNode.InsertChild(appleNode);
            fruitsNode.InsertChild(cherryNode);
            fruitsNode.InsertChild(bananaNode);

            root.InsertChild(fruitsNode);

            SimpleTreeNode veggies = new SimpleTreeNode(new MyDataHolder("Veggies"));
            SimpleTreeNode tomato = new SimpleTreeNode(new MyDataHolder("Tomato"));
            SimpleTreeNode onion = new SimpleTreeNode(new MyDataHolder("Onion"));

            veggies.InsertChild(tomato);
            veggies.InsertChild(onion);

            root.InsertChild(veggies);


            //mark the tree left and right indexes
            int start = 0;
            root.MarkTree(ref start);


            //create a visit action delegate that will print to console
            //because the visit allows us to add any action delegate here
            //this is the place where we could create an action that inserts in our database.
            Action<Node<MyDataHolder>> consoleWriteAction = (node) =>
            {
                Console.WriteLine("{0}\tl={1} r={2}", node.Value.Name, node.LeftIndex, node.RightIndex);
            };

            root.Visit(consoleWriteAction);

            Console.ReadLine();

        }
    }
}
