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
    public void Dequeue()
    {
        if (this.top == null)
        {
            Console.WriteLine("The Queue is empty");
            return;
        }
        var temp = this.top;
        this.top = this.top.next;
        Console.WriteLine($"\n Item deleted is {temp.data}");
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