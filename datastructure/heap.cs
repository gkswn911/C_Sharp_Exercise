using System;
using System.Collections;
using System.Collections.Generic;

public class MaxHeap 
{
    private List<int> A = new List<int>();

    // Heap Add
    public void Add(int value)
    {
        // Add
        A.Add(value);

        // 버블 Up
        int i = A.Count - 1;
        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (A[parent] < A[i]) // MinHeap에선 반대
            {
                Swap(parent, i);
                i = parent;
            }
            else
            {
                break;
            }
        }
    }

    // Heap Delete
    public int RemoveOne()
    {
        // Node가 없을 시
        if (A.Count == 0)
            throw new InvalidOperationException();

        int root = A[0];
            
        A[0] = A[A.Count - 1];
        A.RemoveAt(A.Count - 1);

        // 버블 Down
        int i = 0;
        int last = A.Count - 1;
        while (i < last)
        {
            int child = i*2 + 1;

            if (child < last && 
                A[child] < A[child + 1]) // MinHeap에선 반대
                child = child + 1;

            if (child > last || 
               A[i] >= A[child]) // MinHeap에선 반대
               break;
                
            Swap(i, child);
            i = child;                                    
        }

        return root;
    }

    private void Swap(int i, int j)
    {
        int t = A[i];
        A[i] = A[j];
        A[j] = t;
    }
}