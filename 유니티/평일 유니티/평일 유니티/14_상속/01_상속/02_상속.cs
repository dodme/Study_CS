using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._01_상속
{
    class MonsterBase
    {
        public string Name;
        public int Hp;
        public int Damage;

        // @@@ 중요 @@@ : 생성자는 상속이 되지 않는다!
        public void SetMosnterStat(string name, int hp, int damage)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine(Name + "이 공격합니다.");
        }
    }

    class Slime : MonsterBase
    {
        public Slime() : base(10)
        {
            Attack();
        }

        public void Pastlife()
        {
            Console.WriteLine("전생했더니 내가 슬라임???!?!?!??!");
        }
    }

    class Dragon : MonsterBase
    {
        public void Strong()
        {
            Console.WriteLine("쌥니다.");
        }
    }

    class _02_상속
    {
        public static void Main()
        {
            //MonsterBase monster[] = new Slime();
            MonsterBase slime = new Slime();
            slime.SetMosnterStat("슬라임", 100, 10);
            Dragon dragon = new Dragon();

            
        }
    }
}
