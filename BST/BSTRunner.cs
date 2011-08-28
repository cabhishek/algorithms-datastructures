using System;

namespace CodingPractice.BST
{
    public static class BSTRunner
    {
        public static void run()
        {
            //var bst = new BST();
            //bst.Insert(5);
            //bst.Insert(8);
            //bst.Insert(3);
            //bst.Insert(1);
            //bst.Insert(10);
            //bst.Insert(12);

            //Console.WriteLine(bst.NumberOfNodes());
            //Console.WriteLine(bst.NodeCount());
            //Console.WriteLine(bst.IsThere(156));
            //Console.WriteLine(bst.Retrive(12));

            TempBST node = new TempBST();
            /*node.insert(10);
            node.insert(7);
            node.insert(15);
            node.insert(5);
            node.insert(12);
            node.insert(18);
            node.insert(1);*/
            
            //node.balance();
            node.insert(10);
            node.insert(5);
            node.insert(18);
            node.insert(7);
            node.insert(12);
            node.insert(4);
            node.delete(5);

            node.PrintRootToLeavePath();
        
            //Console.WriteLine(node.getNodeLevel(10));
        }
    }
}