using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS18._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести строку со скобками");
            string bracket = Console.ReadLine();
            Console.WriteLine(Bracket(bracket) ? "Введено верно" : "Введено не верно");
            Console.ReadKey();
        }
        static bool Bracket(string bracket)
        {
            string s = "[{(]})";
            Stack<char> sb = new Stack<char>();
            foreach (var i in bracket)
            {
                int b = s.IndexOf(i);

                if (b >= 0 && b <= 2)
                    sb.Push(i);

                if (b > 2)
                {
                    if (sb.Count == 0 || sb.Pop() != s[b - 3])
                        return false;
                }
            }
            if (sb.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
