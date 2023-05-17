using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._02_생성자종료자
{
    // 객체지향 프로그래밍 언어의 3대 특성
    /// 다형성
    /// 상속성
    /// 은닉성(캡슐화)

    class Character
    {
        public enum CharacterJob
        { 
            Warrior,
            Mage,
            Archor,
        }

        public string NickName;
        public int Hp;
        public int Damage;
        public int Level;
        public CharacterJob Job;

        public Character(string nickName, int hp, int damage, CharacterJob job, int level = 1)
        {
            NickName = nickName;
            Hp = hp;
            Damage = damage;
            Job = job;
            Level = level;
        }

        public void PrintCharacterInfo()
        {
            Console.WriteLine($"닉네임 : {NickName}");
            Console.WriteLine($"Hp : {Hp}");
            Console.WriteLine($"Damage : {Damage}");
            Console.WriteLine($"Job : {Job}");
            Console.WriteLine($"Level : {Level}");
        }

    }

    class Monster
    {
        public enum MonsterType
        {
            RedSlime,
            YellowSlime,
            BlueSlime,
        }

        public string Name;
        public int Hp;
        public int Damage;
        public int Level;
        public MonsterType Job;


    }

    class _02_생성자
    {
        public static void Main()
        {
            Character player = new Character("김민자", 100, 10, Character.CharacterJob.Warrior);
            
        }
    }
}
