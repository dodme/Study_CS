using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._12_구조체._02_튜플
{
    /// > 튜플 사용 방법 : 도구
    /// > NuGet 패키지 관리자
    /// > 패키지 관리자 콘솔
    /// > Install-Package System.ValueTuple 입력

    class _01_튜플
    {
        public static void Main()
        {
            new _01_튜플().Entry();
        }

        public void Entry()
        {
            // 튜플 - Tuple
            // 명명되지않은 구조체

            var unnamedTuple = (100, 10, "전사");
            //(int, string) unnamedTuple = (10, "Hello");

            Console.WriteLine(unnamedTuple.Item1);
            Console.WriteLine(unnamedTuple.Item2);

            var namedTuple = (Hp: 100, Damage: 10, Job :  "전사");

            Console.WriteLine(namedTuple.Hp);
            Console.WriteLine(namedTuple.Damage);
            Console.WriteLine(namedTuple.Job);
        }
    }
}
