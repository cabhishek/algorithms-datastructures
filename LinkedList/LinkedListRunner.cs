namespace CodingPractice.LinkedList
{
    public static class LinkedListRunner
    {
        public static void run()
        {
            //var unsortedLinkedList = new UnsortedLinkedList();
            //unsortedLinkedList.insert(5);
            //unsortedLinkedList.insert(55);
            //unsortedLinkedList.insert(15);

            //Console.WriteLine(unsortedLinkedList.isThere(55));
            //Console.WriteLine(unsortedLinkedList.isThere(554));

            var unsortedLinkedList = new UnsortedLinkedList();
            unsortedLinkedList.insert(8);
            unsortedLinkedList.insert(4);
            unsortedLinkedList.insert(16);
            unsortedLinkedList.insert(6);
            unsortedLinkedList.insert(2);
      

			unsortedLinkedList.recursiveReverse();

			unsortedLinkedList.Print();

            //Console.WriteLine(sortedLinkedList.isThere(55));
            //Console.WriteLine(sortedLinkedList.isThere(554));
            //sortedLinkedList.reverse();
            //sortedLinkedList.printList();
            //sortedLinkedList.printReversed();

            //sortedLinkedList.printReversed();

            //var sortedLinkedList = new CircularSortedLinkedList();
            //sortedLinkedList.insert(5);
            //sortedLinkedList.insert(55);
            //sortedLinkedList.insert(15);
            //sortedLinkedList.insert(10);

            //Console.WriteLine(sortedLinkedList.isThere(55));
            //Console.WriteLine(sortedLinkedList.isThere(554));
        }
    }
}