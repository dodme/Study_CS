using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유니티._03_입력
{
    class _01_입력
    {
        // 입력
        /// > 개발자가 정해준 데이터가 아닌 사용자가 런타임중에 값을 초기화 하는것


        public static void Main()
        {
            /*string inputStr;

            inputStr = Console.ReadLine();
            // Console.ReadLine() : 표준 입력 함수
            Console.WriteLine("당신이 입력한 값은 : " + inputStr);*/

            Console.WriteLine("정수를 입력하세요.");
            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine("당신이 입력한 값은 : " + inputNum);


        }
    }
}
