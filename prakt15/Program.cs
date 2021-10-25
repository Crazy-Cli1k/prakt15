using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            string s = Console.ReadLine();

            if (Int32.TryParse(s, out n))
            {

                Stack<int> numb = new Stack<int>(n);
                for(int i=1; i<=n; i++)
                {
                    numb.Push(i);
                }

                Console.WriteLine("Верхний элемент стека = "+ numb.Peek());

                Console.WriteLine("Размерность стека "+ numb.Count());

                Console.Write("Содержимое стека = ");
                foreach(int item in numb)
                {
                    Console.Write(item+" ");
                }
    
                numb.Clear();
                Console.WriteLine("\nНовая размерность стека "+numb.Count());
            }
            else Console.WriteLine("Ошибка!");

            Console.ReadKey();
        }
    }
}
