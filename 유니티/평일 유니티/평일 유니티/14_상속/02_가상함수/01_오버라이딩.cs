using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._02_가상함수
{
    // 오버 로딩? OverLoading
    /// > 이름을 같게 하여 함수를 중복정의 하는것
    
    // 오버라이딩 ? OverRiding
    /// > 부모에 있는 메서드를 자식클래스에서 재정의 하는것을 기대한다
    
    // 가상메서드
    /// virtual

    class Character
    {
        protected string nickName;
        protected int hp;
        protected int damage;

        public virtual void Attack()
        {
            Console.WriteLine("Character가 공격합니다.");
        }
    }

    class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine("전사가 공격합니다.");
        }
    }
    
    
    class Mage : Character
    {
        public override void Attack()
        {
            Console.WriteLine("마법사가 공격합니다.");
        }
    }

    class _01_오버라이딩
    {
        public static void Main()
        {
            Character player = new Warrior();
            player.Attack();



        }
    }
}

// 숙제
/// Character 클래스를 정의합니다.
/// Character는 이름, 무기를 가집니다.
/// Character를 상속받은 Warrior, Mage, Archer를 정의하고,
/// Warrior는 방어력을 가지며,
/// Mage는 마력을 가지며,
/// Archer는 회피력을 가집니다.

// -- output --
/// 캐릭터 이름 : 
/// 사용중인 무기 : 
