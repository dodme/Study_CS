using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._16_컬렉션
{
    // Stack
    /// 후입선출방식

    // 요소추가 : Push
    // 요소삭제 : Pop
    
    // ex) 상점 되돌리기 버튼

    class _03_Stack
    {
        public static void Main()
        {
            Stack stack = new Stack();

            stack.Push("stack입니다~!");
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Peek());


            //stack.Clear();

            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
