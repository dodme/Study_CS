using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._06_연산자
{
    // 논리연산자
    /// > && (AND)      : 둘 다 참이면 참   T && T = T
    /// > ||  (OR)      : 둘중 하나라도 참이면 참  T || F = T
    /// > !  (NOT)      : 진리값을 뒤짒습니다.  !T = F
    /// > 연산결과 : 논리값 / 진리값
    
    class _04_논리연산자
    {
        public static void Main()
        {
            /* bool A = true;
             bool B = true;

             Console.WriteLine(A && B);
             Console.WriteLine(true && false);
             Console.WriteLine(true && true);
             Console.WriteLine(false && false);


             Console.WriteLine(true || false);
             Console.WriteLine(true || true);
             Console.WriteLine(false || true);
             Console.WriteLine(false || false);*/

            int characterHp = 100;
            int monsterDamage = 10;

            Console.WriteLine(((characterHp - monsterDamage) > monsterDamage) && (characterHp <= 0));

        }
    }
}
