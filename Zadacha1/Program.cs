using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> brack = new Stack<string>();
            string brackets = "(kjjlkj)[{kjhj}]   lk;lk()";
            foreach (char arg in brackets)
            {
                string argStr = arg.ToString();
                switch (argStr)
                {
                    case "(":
                        brack.Push(")"); break;
                    case "[":
                        brack.Push("]"); break;
                    case "{":
                        brack.Push("}"); break;
                    case ")":
                        if (brack.Contains(")"))
                        {
                            if (argStr == brack.Peek())
                            {
                                argStr = brack.Pop();
                                break;
                            }
                            else
                            {
                                brack.Push(")");
                            }
                        }
                        else
                        {
                            brack.Push(")");
                        }
                        break;
                    case "]":
                        if (brack.Contains("]"))
                        {
                            if (argStr == brack.Peek())
                            {
                                argStr = brack.Pop();
                                break;
                            }
                            else
                            {
                                brack.Push("]");
                            }
                        }
                        else
                        {
                            brack.Push("]");
                        }
                        break;
                    case "}":
                        if (brack.Contains("}"))
                        {
                            if (argStr == brack.Peek())
                            {
                                argStr = brack.Pop();
                                break;
                            }
                            else
                            {
                                brack.Push("}");
                            }
                        }
                        else
                        {
                            brack.Push("}");
                        }
                        break;
                }
            }
            if (brack.Count == 0)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не корректно");
            }
            Console.ReadKey();
        }

    }
}
