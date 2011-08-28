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

            var sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.insert(8);
            sortedLinkedList.insert(4);
            sortedLinkedList.insert(16);
            sortedLinkedList.insert(58);
            sortedLinkedList.insert(11);
            sortedLinkedList.insert(12);
            sortedLinkedList.insert(3);
            sortedLinkedList.insert(1);


            //Console.WriteLine(sortedLinkedList.isThere(55));
            //Console.WriteLine(sortedLinkedList.isThere(554));
            //sortedLinkedList.reverse();
            //sortedLinkedList.printList();
            //sortedLinkedList.printReversed();

            sortedLinkedList.reverseKth(3);
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