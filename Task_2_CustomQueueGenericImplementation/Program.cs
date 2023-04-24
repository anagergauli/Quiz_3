//Task_2, Quiz_3

//custom queue implementation
//adding and removing elements
//with and without parametrized constructors

using System;
using System.Collections.Generic;

public class CustomQueue<T>
{
    private List<T> elements;

    public CustomQueue()
    {
        elements = new List<T>();
    }

    public CustomQueue(int capacity)
    {
        elements = new List<T>(capacity);
    }

    public int Count => elements.Count;

    public bool IsEmpty => Count == 0;

    public void Enqueue(T element) //adding elements
    {
        elements.Add(element);
    }

    public T Dequeue() //removing elements
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T element = elements[0];
        elements.RemoveAt(0);
        return element;
    }

    public void Clear() //removing all elements
    {
        elements.Clear();
    }
}
