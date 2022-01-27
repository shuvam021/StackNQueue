using System;
namespace StackNQueue;

internal class CustomStackProgram
{
    private Node top;
    public CustomStackProgram()
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