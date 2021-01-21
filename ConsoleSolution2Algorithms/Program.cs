using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

            //SinglyLinkedList<string> ListS = new SinglyLinkedList<string>();
            //ListS.AddFirst("cu");
            //ListS.AddFirst("ca");
            //ListS.AddFirst("beludo");
            //ListS.PrintList();

            //DOUBLY LINKED LISTS

            //DoublyLinkedList<int> ListD = new DoublyLinkedList<int>();
            //ListD.AddFirst(5);
            //ListD.AddFirst(3);
            //ListD.AddFirst(7);
            //ListD.AddFirst(9);
            //ListD.PrintList();

            //END OF LINKED LISTS

            //STACKS

            //StackArrayBased<int> ArrStack = new StackArrayBased<int>();
            //ArrStack.Push(1);
            //ArrStack.Push(10);
            //ArrStack.Push(100);
            //ArrStack.Push(1000);

            //foreach (var item in ArrStack)
            //{
            //    Console.WriteLine(item);
            //}

            //StackLinkedListBased<int> LinkStack = new StackLinkedListBased<int>();
            //LinkStack.Push(1);
            //LinkStack.Push(11);
            //LinkStack.Push(111);
            //LinkStack.Push(1111);

            //foreach (var item in LinkStack)
            //{
            //    Console.WriteLine(item);
            //}

            //BUILT-IN STACK

            //Stack mozo = new Stack();

            //mozo.Push(1);
            //mozo.Push(11);
            //mozo.Push(111);
            //mozo.Push(1111);

            //foreach (var item in mozo)
            //{
            //    Console.WriteLine(item);
            //}

            //mozo.Push("beludo");
            //mozo.Push("ca");
            //mozo.Push("cu");

            //foreach (var item in mozo)
            //{
            //    Console.WriteLine(item);
            //}

            //END OF STACKS

            //QUEUES

            //ArrayBasedQueue<int> arrQueue = new ArrayBasedQueue<int>();

            //arrQueue.Enqueue(1);
            //arrQueue.Enqueue(11);
            //arrQueue.Enqueue(111);
            //arrQueue.Enqueue(1111);

            //foreach (var item in arrQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //CircularQueue<int> circQueue = new CircularQueue<int>();
            //circQueue.Enqueue(1);
            //circQueue.Enqueue(11);
            //circQueue.Enqueue(111);
            //circQueue.Enqueue(1111);

            //foreach (var item in circQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //BUILT-IN QUEUES

            //Queue<int> mozo = new Queue<int>(128);
            //mozo.Enqueue(1);
            //mozo.Enqueue(11);
            //mozo.Enqueue(111);
            //mozo.Enqueue(1111);
            //mozo.Enqueue(11111);

            //Console.WriteLine($"Peek of Queue: {mozo.Peek()}");

            //mozo.Dequeue();

            //Console.WriteLine($"Peek of Queue: {mozo.Peek()}");

            //foreach (var item in mozo)
            //{
            //    Console.WriteLine($"Printing Queue Values: {item}");
            //}

            //LINEAR SEARCH

            //var customerList = new List<LinearSearchCustomer>()
            //{
            //    new LinearSearchCustomer {Age = 3, Name = "Ann"},
            //    new LinearSearchCustomer {Age = 16, Name = "Bill"},
            //    new LinearSearchCustomer {Age = 20, Name = "Rose"},
            //    new LinearSearchCustomer {Age = 14, Name = "Rob"},
            //    new LinearSearchCustomer {Age = 28, Name = "Bill"},
            //    new LinearSearchCustomer {Age = 14, Name = "John"},
            //};

            //var intList = new List<int>()
            //{
            //    1, 4, 2, 7, 5, 9, 12, 3, 2, 1
            //};

            //bool contains = intList.Contains(3);

            //bool contains2 = customerList.Contains(new LinearSearchCustomer { Age = 14, Name = "Rob" }, new CustomersComparer());


            //bool exists = customerList.Exists(LinearSearchCustomer => LinearSearchCustomer.Age == 28);

            //int min = intList.Min();
            //int max = intList.Max();

            //int youngestCustomerAge = customerList.Min(LinearSearchCustomer => LinearSearchCustomer.Age);

            //LinearSearchCustomer bill = customerList.Find(LinearSearchCustomer => LinearSearchCustomer.Name == "Bill");

            //BINARY SEARCH

            //int[] binaryArrTest = new int[10] { 99, 23, 43, 54, 32, 65, 534, 564, 241, 01 };

            //Array.Sort(binaryArrTest);

            //foreach (var item in binaryArrTest)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Achou o Numero? " + BinarySearch.BinarySearchTest(binaryArrTest, 23));
            //Console.WriteLine("Achou o Numero? " + BinarySearch.BinarySearchTest(binaryArrTest, 33));

            //SYMBOL TABLES

        }
    }
}
