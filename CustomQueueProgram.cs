using System;
namespace StackNQueue;

internal class CustomQueueProgram
{
    private Node top;
    public void Enqueue(int item)
    {
        var node = new Node(item);
        if (this.top == null) this.top = node;
        else
        {
            var temp = this.top;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        Console.WriteLine($"inserted into list {node.data}");
    }
    public void Display()
    {
        var temp = this.top;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
}