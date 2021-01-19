using System;

namespace ConsoleSolution2Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArraysReview mozo = new ArraysReview();

            //mozo.ArrayDemo();
            
            

            int[] array = new int[10] { 55,5,2,3,4,8,1,6,13,-1};

            //BUBBLE SORT:

            //Console.WriteLine("UNSORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //BubbleSort.BubbleSortThis(array);

            //Console.WriteLine("SORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}


            //END OF BUBBLE SORT

            //SELECTION SORT

            //Console.WriteLine("UNSORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //SelectionSort.SelectionSortThis(array);

            //Console.WriteLine("SORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF SELECTION SORT

            //INSERTION SORT

            //Console.WriteLine("UNSORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //InsertionSort.InsertionSortThis(array);

            //Console.WriteLine("SORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF INSERTION SORT

            //SHELL SORT

            //Console.WriteLine("UNSORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //ShellSort.ShellSortThis(array);            

            //Console.WriteLine("SORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF SHELL SORT

            //MERGE SORT

            //Console.WriteLine("UNSORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //MergeSort.MergeSortThis(array);

            //Console.WriteLine("SORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF MERGE SORT

            //QUICK SORT

            //Console.WriteLine("UNSORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //QuickSort.QuickSortThis(array);

            //Console.WriteLine("SORTED: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF QUICK SORT

            //BUILT IN LIST

            //ListBuiltIn.RunList();
            //ListBuiltIn.ApiMembers();

            //END OF BUILT IN LIST

            //NODES

            //NodeReview first = new NodeReview() { Value = 5 };
            //var second = new NodeReview() { Value = 1 };

            //first.Next = second;

            //var third = new NodeReview() { Value = 3 };

            //second.Next = third;

            //NodeReview.PrintLinkedList(first);

            //END OF NODES

            //LINKED LISTS
            //SINGLY LINKED LISTS

            //SinglyLinkedList<int> List = new SinglyLinkedList<int>();
            //List.AddFirst(5);
            //List.AddFirst(6);
            //List.AddFirst(7);
            //List.AddFirst(8);
            //List.AddLast(5);
            //List.AddLast(6);

            SinglyLinkedList<string> ListS = new SinglyLinkedList<string>();
            ListS.AddFirst("cu");
            ListS.AddFirst("ca");
            ListS.AddFirst("beludo");
            ListS.PrintList();


        }
    }
}
