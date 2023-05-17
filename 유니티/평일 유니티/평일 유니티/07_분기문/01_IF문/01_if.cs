using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._07_분기문._01_IF문
{
    // if문
    /// 만약에 ~라면
    /// > if(조건식)
    /// {
    ///     조건식이 참일때만 실행할 코드
    /// }

    class _01_if
    {
        public static void Main()
        {
            int characterHp = 100;
            int damage = 10;

            Console.WriteLine("몬스터를 마주쳤습니다.");
            Console.WriteLine("몬스터가 공격합니다.");
            characterHp -= damage;

            if (characterHp <= 0)
            {
                Console.WriteLine("Die");
            }


        }
    }
}
