using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._07_분기문._02_Switch문
{
    class _02_switch
    {
        enum Key
        { 
            W,
            S,
            D,
            A,
        }

        public static void Main()
        {
            Key key = Key.W;

            switch (key)
            {
                case Key.W:
                    Console.WriteLine("앞");
                    break;
                case Key.S:
                    Console.WriteLine("뒤");
                    break;
                case Key.A:
                    Console.WriteLine("왼");
                    break;
                case Key.D:
                    Console.WriteLine("오");
                    break;

            }
        }
    }
}
