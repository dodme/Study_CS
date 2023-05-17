using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._13_배열
{
    // 배열
    /// 동일한 변수들의 집합
    /// 연속된 메모리들의 시작주소를 참조하는 변수


    // 자료형[] 배열변수이름 = new 자료형[배열의크기];

    class _01_배열
    {
        public static void Main()
        {
            // 방법1.
            int[] arrNum = new int[5];
            // 배열의 요소 / Element

            //int num1;
            //int num2;
            //int num3;
            //int num4;
            //int num5;

            arrNum[0] = 10;
            arrNum[1] = 20;
            arrNum[2] = 30;
            arrNum[3] = 40;
            arrNum[4] = 50;

            // 배열의 모든요소를 순회하는 반복문1.
            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.WriteLine(arrNum[i]);
            }

            // 2.
            foreach (object o in arrNum)
            {
                Console.WriteLine(o);
            }

            // 방법2.
            int[] arrNum2 = new int[3] { 10, 12, 2 };

            Console.WriteLine(arrNum2[0]);

            // 방법3.
            int[] arrNum3 = new int[] { 10, 12, 2 };

            Console.WriteLine(arrNum3[0]);

            // 방법4.
            int[] arrNum4 = { 10, 12, 2 };

            Console.WriteLine(arrNum4[0]);

        }
    }
}


// 숙제
/// > int형 배열 myArray는 30개의 엘리먼트를 가지고있습니다.
/// 각 엘리먼트에 31 ~ 60의 데이터를 넣어서 출력해주세요!
