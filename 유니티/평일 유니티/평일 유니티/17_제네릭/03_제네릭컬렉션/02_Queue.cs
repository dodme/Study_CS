using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._17_제네릭._03_제네릭컬렉션
{
    class _02_Queue
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine(queue.Peek());

            queue.Dequeue();
            Console.WriteLine(queue.Peek());

        }
    }
}
