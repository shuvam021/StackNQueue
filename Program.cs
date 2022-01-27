using System;

namespace StackNQueue;

internal class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}
internal class StackNQueueProgram
{
    private Node top;
    public StackNQueueProgram()
    {
        this.top = null;
    }
    public void Push(int value)
    {
        Node node = new Node(value);
        if (this.top == null) node.next = null;
        else node.next = this.top;
        this.top = node;
        Console.WriteLine($"{value} pushed to stack");
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
    public void Peak()
    {
        if (this.top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine($"{this.top.data} is in the top of the stack");
    }
    public void Pop()
    {
        if (this.top == null)
        {
            Console.WriteLine("Stack is empty, Deletion is not possible");
            return;
        }
        Console.WriteLine($"Value popped is {this.top.data}");
        this.top = this.top.next;
    }
    public void IsEmpty()
    {
        while (this.top != null)
        {
            Peak();
            Pop();
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        var app = new StackNQueueProgram();
        app.Push(70);
        app.Push(30);
        app.Push(56);
        Console.WriteLine(">>>Peak(): ");
        app.Peak();
        Console.WriteLine(">>>Pop(): ");
        app.Pop();
        Console.WriteLine(">>>:IsEmpty(): ");
        app.IsEmpty();
        Console.Write(">>>: ");
        app.Display();
    }
}
