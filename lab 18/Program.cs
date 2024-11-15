using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку со скобками: ");
            string str = Console.ReadLine();
            Console.WriteLine("Скобки расставлены корректно?: {0}",Check(str));
            Console.ReadKey();


        }
        static bool Check(string str)
        {

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                {'(',')'},
                {'{','}'},
                {'[',']'}
            };
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(sk[c]);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
