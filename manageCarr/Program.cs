﻿using manageCarr.ExtensionMethods;
using System;
using static manageCarr.Data_Structure_And_Algorithm.StackAndQueue.LearnStack;
using static manageCarr.DataStructureAndAlgorithm.StackAndQueue.LearnQueue;
using static manageCarr.DoublyLinkedList.DoublyLinkedList;

namespace manageCarr
{
    class Program
    {

        static void Main(string[] args)
        {
            //IMenu menu = new Menu();
            //menu.SelectFeature();

            #region Algorithm Sort
            IComparable[] arr = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            //Console.WriteLine("Quick sort");
            //arr.QuickSort(0, arr.Length - 1);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\nBubble sort");
            //arr.BubbleSort();
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}

            //Console.WriteLine("\nSelection sort");
            //arr.SelectionSort();
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}

            //Console.WriteLine("\nMerge sort");
            //arr.MergSort(0, arr.Length - 1);
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("\nInsertion sort");
            //arr.InsertionSort();
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            //IComparable requestSearch = 52;
            //Console.WriteLine("\nSo can tim trong mang la: " + requestSearch);
            //bool searchSuccessLoop = arr.BinarySearchLoop(0, arr.Length - 1, requestSearch);
            //bool searchSuccessRecursive = arr.BinarySearchRecursive(0, arr.Length - 1, requestSearch);
            //if (searchSuccessRecursive)
            //{
            //    Console.WriteLine("Found {0} in array", requestSearch);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found {0} in array", requestSearch);
            //}

            //Console.WriteLine("\nDoi sanh mau Brute Force:");

            //string requestString = "ABCCBACBABCABCA";
            //string wantFind = "BCA";
            //int amountFound = requestString.BruteForce(wantFind);

            //Console.WriteLine("String request: " + requestString);
            //Console.WriteLine("Found {0} {1} in string request", amountFound, wantFind);

            //Console.WriteLine();

            int value = 51;
            var foundValue = arr.LinearSearch(value);
            if (foundValue)
            {
                Console.WriteLine("Found: " + value + " in array.");
            }
            else
            {
                Console.WriteLine("not found");
            }


            #endregion

            #region Binary Tree
            //Node root = new Node();

            //root.InsertNode(15);
            //root.InsertNode(20);
            //root.InsertNode(8);
            //root.InsertNode(40);
            //root.InsertNode(7);
            //root.InsertNode(18);
            //root.InsertNode(19);
            //root.InsertNode(90);
            //root.InsertNode(50);

            //root.DisplayLeftNodeRight();

            //int searchRequest = 8;
            //bool searchNode = root.SearchNode(searchRequest);
            //Console.WriteLine();
            //if (searchNode)
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}
            //Console.WriteLine("\nDeleted");
            //root.DeleteNode(50);
            //root.DisplayLeftNodeRight();

            #endregion

            #region Linked List

            //Node linkList = new Node();

            //linkList.InsertLastNode(2);
            //linkList.InsertLastNode(6);
            //linkList.InsertLastNode(9);
            //linkList.InsertLastNode(11);
            //linkList.InsertLastNode(13);
            //linkList.InsertLastNode(20);

            //var nodeNew = linkList.InsertFirstNode(90);
            //nodeNew.InsertAfterNode(2, 69);


            //nodeNew.DisplayNode();
            //Console.WriteLine();

            //nodeNew.DeleteLastNode();
            //nodeNew.DisplayNode();

            #endregion

            #region Doubly Linked List
            //DoubleLinkedList list = new DoubleLinkedList
            //{
            //    Head = null,
            //    Tail = null
            //};

            //list.AddFirstNode(10);
            //list.AddFirstNode(9);
            //list.AddFirstNode(25);

            //list.AddLastNode(36);
            //list.AddLastNode(23);
            //list.DisplayNodeLeftToRight();
            //Console.WriteLine();

            //list.AddAfterNode(23, 33);

            //list.DisplayNodeLeftToRight();
            //Console.WriteLine();

            //list.DeleteNodeValue(33);
            //list.DisplayNodeLeftToRight();
            #endregion

            #region Stack

            //Stack stack = new Stack()
            //{
            //    Value = new int[50]
            //};

            //stack.Push(10);
            //stack.Push(15);
            //stack.Push(20);

            //stack.DisplayStack();
            //Console.WriteLine();
            //stack.Pop();

            //stack.DisplayStack();

            //Console.WriteLine();

            //stack.Push(100);
            //stack.DisplayStack();

            #endregion

            #region queue

            //Queue queue = new Queue();

            //queue.Enqueue(15);
            //queue.Enqueue(19);
            //queue.Enqueue(25);
            //queue.Enqueue(46);

            //queue.DisplayQueue();

            //Console.WriteLine();
            //queue.Dequeue();
            //queue.DisplayQueue();

            //Console.WriteLine();
            //queue.Dequeue();
            //queue.DisplayQueue();

            #endregion

            Console.ReadKey();
        }
    }
}
