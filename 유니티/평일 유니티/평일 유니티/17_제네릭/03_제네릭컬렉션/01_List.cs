using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._17_제네릭._03_제네릭컬렉션
{
    // 제네릭컬렉션
    /// ArrayList -> List<T>
    /// Queue -> Queue<T>
    /// Stack -> Stack<T>
    /// Hashtable -> Dictionary<T Key, T Value>

    class _01_List
    {
        public static void Main()
        {
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list[0]);

            list.Insert(2, 999);
            Console.WriteLine(list[2]);
            Console.WriteLine(list.Count);


            list.RemoveAt(list[0]);
            Console.WriteLine(list[0]);
        }
    }
}
