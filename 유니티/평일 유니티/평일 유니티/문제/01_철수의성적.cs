using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _01_철수의성적
    {
        public static void Main()
        {
            Console.WriteLine("국어점수를 입력하세요.");
            int kor = int.Parse(Console.ReadLine());
        
            Console.WriteLine("영어점수를 입력하세요.");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("수학점수를 입력하세요.");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine($"국어점수 : {kor}");
            Console.WriteLine($"영어점수 : {eng}");
            Console.WriteLine($"수학점수 : {math}");



        }
    }
}
