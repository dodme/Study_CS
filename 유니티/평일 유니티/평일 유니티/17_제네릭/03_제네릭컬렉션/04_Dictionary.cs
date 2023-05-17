using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._17_제네릭._03_제네릭컬렉션
{
    class _04_Dictionary
    {
        static void Main() {new _04_Dictionary().Entry();}

        public void Entry()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "전사");
            dictionary.Add(16, "검사");
            dictionary.Add(32, "귀검사");

            Console.WriteLine(dictionary[16]);
            Console.WriteLine(dictionary.ElementAt(0));
            Console.WriteLine(dictionary.ElementAt(1));
            Console.WriteLine(dictionary.ElementAt(2));

            Console.WriteLine(dictionary.ContainsKey(16));

        }
    }
}
