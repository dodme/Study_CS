using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class 쑥제2
    {
        public static void Main()
        {
            // 사용자에게 두개의 숫자 입력받기
            Console.WriteLine("두개의 수를 입력하세요.");
            int inputNum1 = int.Parse(Console.ReadLine());
            int inputNum2 = int.Parse(Console.ReadLine());

            // 왠지 이렇게 작동할것같은 유클리드호제법
            while (inputNum2 != 0)
            {
                int temp = inputNum1 % inputNum2;
                inputNum1 = inputNum2;
                inputNum2 = temp;
            }
            // 최대공약수 출력
            Console.WriteLine($"최대공약수는 {inputNum1}입니다.");

        }
    }
}
