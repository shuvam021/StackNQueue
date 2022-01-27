using System;
namespace StackNQueue;
internal class Program
{
    static void Main(string[] args)
    {
        var app = new CustomStackProgram();
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
