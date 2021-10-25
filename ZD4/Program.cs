using System;
using System.Collections;
using System.IO;
using System.Text;

namespace MyProgram
{
    public class People
    {
        public string f;
        public string i;
        public string o;
        public int age;
        public float massa;

        public People(string f1, string i1, string o1, int age1, float massa1)
        {
            string f = f1;
            string i = i1;
            string o = o1;
            int age = age1;
            float massa = massa1;
        }
    }
    class Program
    {
        public static void Prov_40(string f1, string i1, string o1, int age1, float massa1)
        {
            People p1 = new People(f1, i1, o1, age1, massa1);
            if (p1.age < 40)
                Console.WriteLine(p1.f + "\t" + p1.i + "\t" + p1.o + "\t" + p1.age + "\t" + p1.massa);
        }
        public static void Prov2_40(string f1, string i1, string o1, int age1, float massa1)
        {
            People p1 = new People(f1, i1, o1, age1, massa1);
            if (p1.age > 40)
                Console.WriteLine(p1.f + "\t" + p1.i + "\t" + p1.o + "\t" + p1.age + "\t" + p1.massa);
        }

        public static void Main()
        {
            StreamReader sr = new StreamReader("t.txt");
            Queue people = new Queue();
            string str;
            People p1;
            Console.WriteLine("Возраст менее 40 лет");

            while (!sr.EndOfStream) 
            {
                str = sr.ReadLine();
                string[] str_mass = str.Split(' ');

                Prov_40(str_mass[0], str_mass[1], str_mass[2], int.Parse(str_mass[3]), float.Parse(str_mass[4]));

                Prov2_40(str_mass[0], str_mass[1], str_mass[2], int.Parse(str_mass[3]), float.Parse(str_mass[4]));
            }

            sr.Close();

        }
    }
}
