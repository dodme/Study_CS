using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._16_컬렉션
{
    // Queue
    /// 선입선출 방식(FIFO)
    /// 요소를 원하는 위치에 삽입할순 없으나,
    /// 맨뒤에 요소를 추가하고, 맨앞에서 삭제됩니다.

    // 요소추가 : EnQueue
    // 요소삭제 : DeQueue

    class _02_Queue
    {
        public static void Main()
        {
            Queue queue = new Queue();

            queue.Enqueue("EnQueue입니다~!");
            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Count);

            Console.WriteLine(queue.Peek());

            foreach (object o in queue)
            {
                Console.WriteLine(o);
            }

            queue.Dequeue();

            foreach (object o in queue)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();
            queue.Clear();

            foreach (object o in queue)
            {
                Console.WriteLine(o);
            }

        }
    }
}
