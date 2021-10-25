using System;
using System.Collections;
using System.IO;

namespace MyProgram
{
    class Program
    {
        public static void Main()
        {
            StreamReader sr = new StreamReader("t.txt");
            string str = sr.ReadToEnd();
            sr.Close();

            Stack SK = new Stack();
            bool checker = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') SK.Push(i);
                else if (str[i] == ')') 
                {
 
                    if (SK.Count == 0)
                    { checker = false; 
                      Console.WriteLine("Возможно в позиции " + i + "лишняя ) скобка"); }
                    else SK.Pop(); 
                }
            }

            if (SK.Count == 0) 
            { if (checker) 
              Console.WriteLine("скобки сбалансированы"); 
            }
            else
            {
                Console.Write("Возможно лишняя ( скобка в позиции:");
                while (SK.Count != 0)
                {
                    Console.Write("{0} ", (int)SK.Pop());
                }
                Console.WriteLine();

                StreamWriter sr2 = new StreamWriter("t.txt");
                for (int i = 0; i < str.Length; i++)
                {
                    while (SK.Count != 0)
                    {
                        if (i == (int)SK.Pop())
                        {

                        }
                        else
                            Console.WriteLine(str[i]);
                    }
                }       
            }
            Console.ReadKey();
        }
    }
}
