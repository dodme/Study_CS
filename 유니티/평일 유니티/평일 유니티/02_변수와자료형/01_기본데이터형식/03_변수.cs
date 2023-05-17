using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유니티._02_변수와_자료형
{
    class _03_변수
    {
        public static void Main()
        {
            // TextGame

            // 카멜 표기법    : characterHp
            // 파스칼 표기법  : CharacterHp

            // 캐릭터가 몬스터를 공격합니다.
            int characterHp = 100;
            float character_Damage = 10.0f;

            // 몬스터가 반격합니다.
            int monsterHp = 50;
            float monster_Damage = 5.0f;


            Console.WriteLine("당신의 캐릭터가 몬스터를 공격합니다.");
            Console.WriteLine("몬스터가 " + character_Damage + "만큼 피해를 입었습니다.");

            monsterHp = monsterHp - (int)character_Damage;
            // 명시적 형변환 / Casting
            Console.WriteLine("몬스터의 Hp가 " + monsterHp + "로 감소하였습니다.");

            Console.WriteLine();

            Console.WriteLine("몬스터가 반격합니다.");
            Console.WriteLine($"몬스터가 {monster_Damage}만큼 피해를 입힙니다.");
            characterHp = characterHp - (int)monster_Damage;

            Console.WriteLine($"당신의 현재체력은 {characterHp} 입니다.");

        }
    }
}
