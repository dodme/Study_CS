using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._16_컬렉션
{
    // 컬렉션
    /// 같은셩격의 여러 데이터를 담아둔 자료구조
    /// ArrayList, Queue, Stack, Hashtable
    /// using System.Collections;

    // ArrayList
    /// 배열과 가장 유사한 컬렉션
    /// 하지만 배열과는 다르게,
    /// 크기 조절이 가능하며, 검색, 요소추가, 요소삭제가 용이하다.
    /// 순서값을 가집니다.

    // List<자료형>
    /// object형식이 아닌 선택한 자료형만 담을 수 있는 컬렉션

    class _01_ArrayList
    {
        public static void Main()
        {
            // int[] arrNum = new int[5];  

            ArrayList arrayList = new ArrayList() { 10, 20, 30 };

            // ArrayList.Add(object o) : 요소 추가

            arrayList.Add("문자열");
            arrayList.Add(10.4f);

            //arrList.Count : 요소의 갯수
            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[2]);

            arrayList.RemoveAt(0); // 요소 삭제
            Console.WriteLine(arrayList[0]);

            //arrList.Clear(); // 모든 요소 삭제
            Console.WriteLine();

            Console.WriteLine(arrayList[1]);
            arrayList.Insert(1, "중간삽입");
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[2]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }

        }
    }
}
