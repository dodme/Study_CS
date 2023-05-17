using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._03_추상매서드
{
    // 추상메서드
    /// 모든 자식클래스에서 반드시 해당 메서드를 재정의 해야 하는것
    /// abstract

    // 추상클래스
    /// 추상 메서드를 1개이상 가지고 있는 클래스
    /// 인스턴스화 할 수 없다(객체를 만들 수 없다)
    /// 정적필드엔 선언 불가!
    /// 추상클래스에 대한 메모리가 불안정하기때문에 정적함수도 올 수 없다.


    // 옵저버패턴

    abstract class MonsterBase
    {
        public abstract void Attack();
        // public abstract static void Sample();
    }

    class Slime : MonsterBase
    {
        public override void Attack()
        {
            Console.WriteLine("공격당했졍");
        }
    }

    class Dragon : MonsterBase()
    {
        public override void Attack()
        {
        }
    }

    class _01_추상클래스
    {
        public static void Main()
        {
            MonsterBase monster = new Slime();
            monster.Attack();
        }
    }
}


// 문제!
/// 에어컨을 만듭니다.
/// Machien - Aircon

// Machine
/// 전원 on/off
/// Repair() 수리

// Aircon
/// 온도 조절기능


// 숙제
/// 캐릭터 애니메이션 클래스를 구현합니다.
/// 모든 캐릭터는 Idle(), Walk(), Run(), Jump(), Die()를 가지고있어야 하며
/// 
/// 전사는 듬직한 애니메이션, 또한 전사는 Slash애니메이션을 가지고,
/// 마법사는 귀여운 애니메이션, Explosion 애니메이션을 가지고,
/// 궁수는 센치한 애니메이션을 가집니다, Sniping 애니메이션을 가집니다.




