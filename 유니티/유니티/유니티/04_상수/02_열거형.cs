using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유니티._04_상수
{
    // 열거형
    /// > 상수들의 집합
    /// > enum

    class _02_열거형
    {

        // index 순서
        enum CharacterJob
        { 
            전사,
            마법사,
            궁수,
            도적,
        }

        public static void Main()
        {

            CharacterJob job = CharacterJob.전사;
            Console.WriteLine(job);

            job = CharacterJob.도적;
            Console.WriteLine(job);



        }
    }
}
