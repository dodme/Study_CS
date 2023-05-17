using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._07_분기문._01_IF문
{
    class ifelseifelse
    {
        enum State
        {
            Idle,
            Walk,
            Run,
            Jumping,
        }

        public static void Main()
        {
            State state = State.Idle;

            if (state == State.Idle)
                Console.WriteLine("대기");
            else if (state == State.Walk)
                Console.WriteLine("걷기");
            else if (state == State.Run)
                Console.WriteLine("달리기");
            else if (state == State.Jumping)
                Console.WriteLine("점프");
            else
                Console.WriteLine("어떠한 상태도 아닙니다.");
        }
    }
}
