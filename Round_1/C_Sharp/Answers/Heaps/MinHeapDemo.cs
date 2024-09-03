using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.Heaps
{
    public static class MinHeapDemo
    {
        public static void Demo()
        {
            var list = new List<int>()
            {
                2, 3, 1
            };
            var minHeap = new MinHeap(list);
            WriteLine(minHeap.Peek());
        }
    }

    public class MinHeap
    {
        public List<int> heap = new List<int>();

        public MinHeap(List<int> array)
        {
            heap = buildHeap(array);
        }

        // Time: O(n)
        // Space: O(1))
        public List<int> buildHeap(List<int> array)
        {
            int firstParentIndex = (array.Count - 2) / 2;       // bottom most parent
            if (firstParentIndex == 0)
            {
                firstParentIndex = 1;
            }
            for(var i = firstParentIndex - 1; i >= 0; i --)
            {
                siftDown(i, array.Count - 1, array);
            }
            return array;
        }

        // Time: O(log n)
        // Space: O(1))
        public void siftDown(int currentIdx, int endIdx, List<int> heap)
        {
            int leftChildIndex = (currentIdx * 2) + 1;;  
            var lastIndex = heap.Count - 1;
            while(leftChildIndex <= endIdx)
            {
                int rightChildIndex = leftChildIndex +  1;
                if (rightChildIndex <= endIdx)
                {
                    // consider right child also
                }
                else
                {
                    rightChildIndex = -1;
                }

                var indexToSwap = - 1;
                // two children - right less than left
                if (rightChildIndex != -1 && heap[rightChildIndex] < heap[leftChildIndex]) 
                {
                    indexToSwap = rightChildIndex;
                }
                // two children - left less than right or just one left child
                else //if  (rightChildIndex != -1 && heap[rightChildIndex] > heap[leftChildIndex])
                {
                    indexToSwap = leftChildIndex;
                }

                if (heap[indexToSwap] < heap[currentIdx])
                {
                    Swap(indexToSwap, currentIdx, heap);
                    currentIdx = indexToSwap;
                    leftChildIndex = (currentIdx * 2) + 1;;  
                }
                else
                {
                    break;
                }
            }
        }

        // Time: O(log n)
        // Space: O(1))
        public void siftUp(int currentIndex, List<int> heap)
        {
            int parentIndex = CalculateParentIndex(currentIndex);     // drops decimal points and takes floor
            while (currentIndex > 0 && heap[parentIndex] > heap[currentIndex]) // breaks min heap property
            {
                Swap(parentIndex, currentIndex, heap);
                currentIndex = parentIndex;
                parentIndex = CalculateParentIndex(currentIndex);
            }
        }

        private int CalculateParentIndex(int currentIndex)
        {
            // Time: O(1) formula
            // Space: O(1))
            return (currentIndex - 1) / 2;
        }

        // Time: O(1)
        // Space: O(1))
        public int Peek()
        {           
            heap = buildHeap(heap);
            return heap[0];
        }

        // Time: O(log n)
        // Space: O(1))
        public int Remove()
        {
            var lastIndex = heap.Count - 1;  
            // swap first and last 
            Swap(0, lastIndex, heap);

            // pop last - previous root
            var last = heap[lastIndex];
            heap.RemoveAt(lastIndex);

            // sift down
            siftDown(0, heap.Count - 1, heap);

            return last;
        }


        // Time: O(log n)
        // Space: O(1))
        public void Insert(int value)
        {
            heap.Add(value);    
            var currentIndex = heap.Count - 1;     
            siftUp(currentIndex, heap);   
            //MinHeapify(currentIndex);
        }

        // Time: O(1)
        // Space: O(1))
        private void Swap(int i, int j, List<int> heap)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] =  temp; 
        }
    }
}