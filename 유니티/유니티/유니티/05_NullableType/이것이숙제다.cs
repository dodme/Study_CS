using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유니티._05_NullableType
{
    class 이것이숙제다
    {
        public static void Main()
        {
            Console.WriteLine("국어점수를 입력하세요.");
            int kor = int.Parse(Console.ReadLine());
            Console.WriteLine("영어점수를 입력하세요.");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("수학점수를 입력하세요.");
            int math = int.Parse(Console.ReadLine());


            Console.WriteLine($"국어점수는 {kor}입니다.");
            Console.WriteLine($"영어점수는 {eng}입니다.");
            Console.WriteLine($"수학점수는 {math}입니다.");

            int total = kor + eng + math;
            float average = (float)(kor + eng + math) / 3;

            Console.WriteLine($"점수의 총합은 {total}입니다.");
            Console.WriteLine($"점수의 평균은 {average}입니다.");

            
        }
    }
}
