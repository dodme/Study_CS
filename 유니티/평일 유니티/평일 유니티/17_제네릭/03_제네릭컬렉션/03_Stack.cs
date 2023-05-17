using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._17_제네릭._03_제네릭컬렉션
{
    class _03_Stack
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("private이다.");
            stack.Push("기본값은");
            stack.Push("접근제한자");

            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());

            stack.Clear();
            stack.Pop();


        }
    }
}
