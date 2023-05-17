using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._17_제네릭._02_제네릭클래스
{
    // 일반화 클래스

    class Sample<T>
    {
        public T value;

        public void SampleMethod(T value)
        {
            Console.WriteLine(value);
        }
    }

    class _01_제네릭클래스
    {
        public static void Main()
        {
            Sample<int> sample= new Sample<int>();
            sample.value = 100;
            sample.SampleMethod(10);

            // 형식 매개변수 제약 where T

        }
    }
}
