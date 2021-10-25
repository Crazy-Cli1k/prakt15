using System;
using System.Collections;
namespace MyProgram
{
    class Program
    {
        public static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Queue Qu = new Queue();

            for (int i = 1; i <= n; i++)
            Qu.Enqueue(i);

            Console.Write("Содержимое очереди = ");
            while (Qu.Count != 0)
            Console.Write("{0} ", Qu.Dequeue());
        }
    }
}
