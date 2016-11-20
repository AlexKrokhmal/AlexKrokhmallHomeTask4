using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayForBubbleSorting = new int[] {4, 3, 2, 1, 6, 5};
            int[] arrayForInsertionSorting = (int[])arrayForBubbleSorting.Clone();

            var newTestQueue = new TestQueue();
            newTestQueue.TestTheQueue();

            var newTestStack = new TestStack();
            newTestStack.TestTheStack();


            Console.ReadLine();

        }
                
        static int[] InsertionSorting( int[] incomingArrayForInsertionSorting)
        {
            Console.WriteLine("\n\n***** Insetion Sorting *****\n");
            Console.WriteLine("Incoming array before sorting");
            PrintArray(incomingArrayForInsertionSorting);

            for (int i = 1; i < incomingArrayForInsertionSorting.Length; i++)
            {

                Console.WriteLine("\nIteration {0}:", i);
                PrintArray(incomingArrayForInsertionSorting);

                int j = i;

                while (j > 0 && incomingArrayForInsertionSorting[j] < incomingArrayForInsertionSorting[j - 1])
                {
                    incomingArrayForInsertionSorting = Swap(incomingArrayForInsertionSorting, j, j - 1);
                    j--;
                }                
            }

            Console.WriteLine("\nThe result is:");
            PrintArray(incomingArrayForInsertionSorting);
            
            return incomingArrayForInsertionSorting;
        }

        static int[] BubbleSorting(int[] incomingArrayForBubbleSorting)
        {
            bool swapWasDone = false;

            Console.WriteLine("***** Bubble Sorting *****\n");
            Console.WriteLine("Incoming array before sorting");
            PrintArray(incomingArrayForBubbleSorting);

            int iterationCounter = 1;

            do
            {
                swapWasDone = false;                

                Console.WriteLine("Iteration {0}:", iterationCounter);
                
                for (int i = 0; i < incomingArrayForBubbleSorting.Length - 1; i++)
                {
                    if (incomingArrayForBubbleSorting[i] > incomingArrayForBubbleSorting[i + 1])
                    {
                        incomingArrayForBubbleSorting = Swap(incomingArrayForBubbleSorting, i, i + 1);
                        swapWasDone = true;
                    }
                    Console.WriteLine("Step {0} result:", i + 1);
                    PrintArray(incomingArrayForBubbleSorting);
                }

                iterationCounter++;

            } while (swapWasDone);

            Console.WriteLine("\nThe result is:");
            PrintArray(incomingArrayForBubbleSorting);

            return incomingArrayForBubbleSorting;
        }


        static void PrintArray(int[] arrayForPrint)
        {            
            foreach (int i in arrayForPrint)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine();
        }

        static int[] Swap(int[] arrayForSwap, int firstIndexForSwap, int secondIndexForSwap)
        {
            arrayForSwap[firstIndexForSwap] = arrayForSwap[firstIndexForSwap] + arrayForSwap[secondIndexForSwap];
            arrayForSwap[secondIndexForSwap] = arrayForSwap[firstIndexForSwap] - arrayForSwap[secondIndexForSwap];
            arrayForSwap[firstIndexForSwap] = arrayForSwap[firstIndexForSwap] - arrayForSwap[secondIndexForSwap];
            
            return arrayForSwap;
        }
    }

    //Class to test the queue with lenght 5
    public class TestQueue
    {
        //Method that contains set of actions to test the Queue with lenght 5
        public void TestTheQueue()
        {
            var newQueue = new CircularBufferQueue(5);

            Console.WriteLine("-----------------\n");
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            int dequeuedValue = 0;
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(1);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(2);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(3);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(4);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(5);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(6);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(7);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(8);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(9);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            newQueue.Dequeue(out dequeuedValue);
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(10);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");
        }

    }

    public class CircularBufferQueue
    {
        private int[] arrayForQueue;
        private int queueHead;
        private int queueTail;
        private int numberOfUtilizedQueueElements;

        public CircularBufferQueue(int queueSize)
        {
            arrayForQueue = new int[queueSize];
            queueHead = 0;
            queueTail = 0;
            numberOfUtilizedQueueElements = 0;
        }

        public bool Dequeue(out int dequeuedValue)
        {
            bool returnValue = false;

            if (!IsEmpty())
            {
                dequeuedValue = arrayForQueue[queueHead];
                arrayForQueue[queueHead] = 0;
                queueHead = WhatIsNextCellIndexForTailOrHead(queueHead);
                numberOfUtilizedQueueElements--;

                returnValue = true;
            }
            else
            {
                Console.WriteLine("Cannot dequeue from the queue");
                dequeuedValue = 0;
            }

            return returnValue;
        }


        public void Enqueue(int valueToBeAddedToQueue)
        {
            if (!IsFull())
            {
                arrayForQueue[queueTail] = valueToBeAddedToQueue;
                queueTail = WhatIsNextCellIndexForTailOrHead(queueTail);
                numberOfUtilizedQueueElements++;
            }
            else
            {
                Console.WriteLine("Cannot enqueue the queue.");
            }
        }


        public bool IsFull()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == arrayForQueue.Length)
            {
                Console.WriteLine("The queue is full.");
                returnValue = true;
            }

            return returnValue;
        }

        private int WhatIsNextCellIndexForTailOrHead(int currentIndex)
        {
            int returnValue = 0;

            if (currentIndex < arrayForQueue.Length - 1)
            {
                returnValue = currentIndex + 1;
            }

            return returnValue;
        }

        public bool IsEmpty()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == 0)
            {
                Console.WriteLine("The queue is empty.");
                returnValue = true;
            }

            return returnValue;
        }

        public void PrintQueue()
        {
            Console.WriteLine();

            foreach (int i in arrayForQueue)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine("\n head: {0}\n tail: {1}\n count: {2}", queueHead, queueTail, numberOfUtilizedQueueElements);
            Console.WriteLine();
        }
    }

    public class TestStack
    {
        public void TestTheStack()
        {
            var newStack = new Stack(3);
            newStack.PrintStack();

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(5);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(6);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(7);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(8);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(9);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(10);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(11);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pool());
            newStack.PrintStack();
            Console.WriteLine("-----------------");
        }
    }

    public class Stack
    {
        private int[] arrayForStack;
        private int stackHead;
        private int stackTail;

        public Stack (int stackSize)
            {
            arrayForStack = new int[stackSize];
            stackHead = 0;
            stackTail = 0;            
            }

        public int Pool()
        {
            Console.WriteLine("\nTry to pool the element.");

            int valueToReturn = 0;

            if (!IsEmpty())
            {
                valueToReturn = arrayForStack[stackTail - 1];
                arrayForStack[stackTail - 1] = 0;
                stackTail--;                                
            }
            else
            {
                Console.WriteLine("Cannot pool element from the stack. The stack is empty.");                
            }

            return valueToReturn;
        }

        public void Push(int valueToAdd)
        {
            Console.WriteLine("\nTry to push the element.");

            if (!IsFull())
            {
                arrayForStack[stackTail] = valueToAdd;
                stackTail++;
            }
            else
            {
                Console.WriteLine("Cannot add value to the stack. The stack is already full.");
            }
        }
        
        public int Peek()
        {
            Console.WriteLine("\nTry to peek the element.");

            int valueToReturn = 0;

            if (!IsEmpty())
            {
                valueToReturn = arrayForStack[stackTail - 1];
            }
            else
            {
                Console.WriteLine("Cannot peek element from the stack. The stack is empty.");
            }

            return valueToReturn;    
        }

        public bool IsFull()
        {
            if (stackTail == arrayForStack.Length)
            {
                Console.WriteLine("The stack is full.");
                return true;
            }
            else
            {
                Console.WriteLine("The stack is not full.");
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (stackTail == 0)
            {
                Console.WriteLine("The stack is empty.");
                return true;
            }
            else
            {
                Console.WriteLine("The stack is not empty.");
                return false;
            }
        }

        public void PrintStack()
        {
            Console.WriteLine();
            foreach (int i in arrayForStack)
            {
                Console.Write("{0}  ", i);
            }
            Console.WriteLine();
        }

    }
}
