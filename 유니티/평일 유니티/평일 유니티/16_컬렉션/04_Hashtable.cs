using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._16_컬렉션
{
    // Hashtable
    /// Key, Value
    
    // ex) 로그인시스템

    class _04_Hashtable
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("키미노", "나마에와");
            hashtable.Add("오늘의 숙제는?", "자료구조");
            hashtable.Add(1, 100);
            hashtable.Add("대검", "대검은 아파요~!");

            hashtable["지팡이"] = "쓸데없이 큽니다.";

            Console.WriteLine(hashtable["대검"]);

            
        }
    }
}
